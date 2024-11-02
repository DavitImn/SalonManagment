using Bunifu.Framework.UI;
using MonProfProj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonProfProj
{
    public partial class FormGeneral : Form
    {
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        private Font activeFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Font normalFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color normalColor = System.Drawing.Color.FromArgb(255, 255, 255);

        private bool sideBoxExpend = false;


        public FormGeneral()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(1000,550);
            
            SwapForms<formMainPanel>();
        }

        #region ButtonsVisual
        private void ResetButtons()
        {
            MainButton.Iconimage = global::MonProfProj.Properties.Resources.dashboard;
            VisitDateButton.Iconimage = global::MonProfProj.Properties.Resources.visitDate;
            IncomesButton.Iconimage = global::MonProfProj.Properties.Resources.income;
            ExpensesButton.Iconimage = global::MonProfProj.Properties.Resources.expenses;
            ViewIncomesButton.Iconimage = global::MonProfProj.Properties.Resources.viewIncomes;
            ViewExpensesButton.Iconimage = global::MonProfProj.Properties.Resources.viewExpenses;
            MastersButton.Iconimage = global::MonProfProj.Properties.Resources.women;

            MainButton.TextFont = normalFont;
            VisitDateButton.TextFont = normalFont;
            IncomesButton.TextFont = normalFont;
            ExpensesButton.TextFont = normalFont;
            ViewIncomesButton.TextFont = normalFont;
            ViewExpensesButton.TextFont = normalFont;
            MastersButton.TextFont = normalFont;

            MainButton.Textcolor = normalColor;
            VisitDateButton.Textcolor = normalColor;
            IncomesButton.Textcolor = normalColor;
            ExpensesButton.Textcolor = normalColor;
            ViewIncomesButton.Textcolor = normalColor;
            ViewExpensesButton.Textcolor = normalColor;
            MastersButton.Textcolor = normalColor;
        }
        private void SetActiveButton(BunifuFlatButton activeButton, Image activeImage, Color activeColor)
        {
            ResetButtons();
            activeButton.Iconimage = activeImage;
            activeButton.TextFont = activeFont;
            activeButton.Textcolor = activeColor;
        }
        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            if (sideBoxExpend)
            {
                pnSideBox.Width = 210;
                sideBoxExpend = false;
            }
            else
            {
                pnSideBox.Width = 55;
                sideBoxExpend = true;
            }
        }
        #endregion
        #region Resizer
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnBackGround.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion
        #region Drager
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTopBox_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void SwapForms<MiForm>() where MiForm : Form, new()
        {
            Form windForm;
            windForm = pnContainer.Controls.OfType<MiForm>().FirstOrDefault();
            if (windForm == null)
            {
                windForm = new MiForm();
                windForm.TopLevel = false;
                windForm.FormBorderStyle = FormBorderStyle.None;
                windForm.Dock = DockStyle.Fill;
                pnContainer.Controls.Add(windForm);
                pnContainer.Tag = windForm;
                windForm.Show();
                windForm.BringToFront();
            }
            else
            {
                windForm.BringToFront();
            }

        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(MainButton, global::MonProfProj.Properties.Resources.dashboard___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formMainPanel>();

        }

        private void VisitDateButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(VisitDateButton, global::MonProfProj.Properties.Resources.visitDate___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formVisitDate>();

        }

        private void IncomesButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(IncomesButton, global::MonProfProj.Properties.Resources.income___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formIncomes>();
        }

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(ExpensesButton, global::MonProfProj.Properties.Resources.expenses___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formExpenses>();
        }

        private void ViewIncomesButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(ViewIncomesButton, global::MonProfProj.Properties.Resources.viewIncomes___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formViewIncomes>();
        }

        private void ViewExpensesButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(ViewExpensesButton, global::MonProfProj.Properties.Resources.viewExpenses___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formViewExpenses>();
        }

        private void MastersButton_Click(object sender, EventArgs e)
        {
            SetActiveButton(MastersButton, global::MonProfProj.Properties.Resources.women___ACT, System.Drawing.Color.FromArgb(123, 88, 198));
            SwapForms<formMasters>();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else 
            {
                Rectangle workingArea = Screen.FromControl(this).WorkingArea;
                this.MaximumSize = new Size(workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnTopBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                Rectangle workingArea = Screen.FromControl(this).WorkingArea;
                this.MaximumSize = new Size(workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
            }
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
