using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MonProfProj.Db;
using Hourglass;

namespace MonProfProj
{
    public partial class formVisitDate : Form
    {
        private readonly DbConnection _sqlConnection;
        private List<Appointment> appointments = new List<Appointment>();

        public formVisitDate()
        {
            _sqlConnection = new DbConnection();
            InitializeComponent();
            this.Load += new EventHandler(this.formVisitDate_Load);
        }

        private void formVisitDate_Load(object sender, EventArgs e)
        {
            LoadData();
            hgScheduler1.Render(); // Render the scheduler for the current date
        }

        public class Appointment
        {
            public int AppointmentId { get; set; }
            public string Text { get; set; }
            public string Description { get; set; }
            public int CategoryId { get; set; }
            public string CategoryName { get; set; } // New property for category name
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int MasterId { get; set; }
            public string MastersName { get; set; }
        }

        // Retrieve appointments from the database
        private List<Appointment> GetAppointmentsFromDatabase()
        {
            var appointments = new List<Appointment>();
            using (var connection = _sqlConnection.GetConnection())
            {
                connection.Open();

                // Modified query to join Appointment with Master and Category to get MastersName and CategoryName
                string query = @"
                 SELECT a.AppointmentId, a.Text, a.Description, a.CategoryId, 
                        c.CategoryName, a.StartDate, a.EndDate, m.MastersName
                 FROM Appointment a
                 LEFT JOIN Master m ON a.MasterId = m.MasterId
                 LEFT JOIN Category c ON a.CategoryId = c.CategoryId"; // Join with Category table

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new Appointment
                            {
                                AppointmentId = reader.GetInt32(0),
                                Text = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                CategoryId = reader.GetInt32(3),
                                CategoryName = reader.IsDBNull(4) ? "Uncategorized" : reader.GetString(4), // Get CategoryName
                                StartDate = reader.GetDateTime(5),
                                EndDate = reader.GetDateTime(6),
                                MastersName = reader.IsDBNull(7) ? null : reader.GetString(7)
                            });
                        }
                    }
                }
            }
            return appointments;
        }

        // Load data into the scheduler
        void LoadData()
        {
            appointments = GetAppointmentsFromDatabase();

            foreach (var ev in hgScheduler1.GetEvents().ToList())
            {
                hgScheduler1.RemoveEvent(ev);
            }

            foreach (var appointment in appointments)
            {
                hgScheduler1.AddEvent(new Hourglass.HourglassEvent
                {
                    Id = appointment.AppointmentId.ToString(),
                    BackColor = Color.Crimson,
                    Start = appointment.StartDate,
                    End = appointment.EndDate,
                    Text = $"{appointment.MastersName} - {appointment.CategoryName} - {appointment.Text}",  // Include CategoryName
                    Tooltip = $"Master:{appointment.MastersName}   PhoneNumb:{appointment.Description}"
                });
            }
        }
        // View change buttons

        private void ChangeView(Hourglass.ViewTypes viewType)
        {
            hgScheduler1.Options.ViewType = viewType;
            hgScheduler1.Options.StartDate = DateTime.Now;
            hgScheduler1.Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selection = hgScheduler1.GetSelection();

            if (selection != null && selection.start.HasValue && selection.end.HasValue)
            {
                var addEvents = new formAddEvents
                {
                    start = selection.start.Value,
                    end = selection.end.Value
                };

                // Subscribe to the DataSaved event
                addEvents.DataSaved += (s, args) =>
                {
                    // Reload data after a new event is saved
                    LoadData();
                };

                addEvents.Show();
            }
            else
            {
                var addEvents = new formAddEvents
                {

                };
                addEvents.Show();
            }

            hgScheduler1.Refresh();
        }
        private void hgScheduler1_OnEventEdit(object Sender, RangeCalendarEvent e)
        {
            // Check if the event text is empty or the ID is invalid
            if (string.IsNullOrWhiteSpace(e.@event.Text) || string.IsNullOrEmpty(e.@event.Id))
            {
                MessageBox.Show("Invalid appointment ID or text.");
                e.Cancel = true;
                return;
            }

            // Attempt to parse the appointment ID
            if (int.TryParse(e.@event.Id, out int appointmentId))
            {
                // Update the appointment in memory (if you are keeping an in-memory list of appointments)
                var appointment = appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
                if (appointment != null)
                {
                    appointment.Text = e.@event.Text;
                    appointment.Description = e.@event.Text;
                    appointment.StartDate = e.@event.Start;
                    appointment.EndDate = e.@event.End; // Update end date in memory

                    // Update the appointment in the SQL database
                    try
                    {
                        using (var connection = _sqlConnection.GetConnection())
                        {
                            connection.Open();
                            using (var command = new SqlCommand("UPDATE Appointment SET StartDate = @StartDate, EndDate = @EndDate WHERE AppointmentId = @AppointmentId", connection))
                            {
                                command.Parameters.AddWithValue("@StartDate", e.@event.Start);
                                command.Parameters.AddWithValue("@EndDate", e.@event.End);
                                command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                                if (command.ExecuteNonQuery() == 0)
                                {
                                    MessageBox.Show("No rows were updated. Appointment might not exist.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating appointment: {ex.Message}");
                    }

                    // Reload data after editing to reflect changes
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Invalid appointment ID.");
            }



        }

        private void DayButton_Click(object sender, EventArgs e) => ChangeView(Hourglass.ViewTypes.Day);

        private void WeekButton_Click_2(object sender, EventArgs e) => ChangeView(Hourglass.ViewTypes.Week);
        private void MonthButton_Click_2(object sender, EventArgs e) => ChangeView(Hourglass.ViewTypes.Month);

        private void calendar2_ValueChanged(object sender, EventArgs e)
        {
            hgScheduler1.Options.StartDate = calendar2.Value;
            hgScheduler1.Render();

        }
    }
}