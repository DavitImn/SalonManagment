namespace MonProfProj
{
    partial class formMainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnBestMaster = new System.Windows.Forms.Panel();
            this.pnTotalIncomesMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LbTotalIncomes = new System.Windows.Forms.Label();
            this.pnTotalExpensesMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTotalExpenses = new System.Windows.Forms.Label();
            this.pnBestCategory = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnTotalIncomesMain.SuspendLayout();
            this.pnTotalExpensesMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnBestMaster, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnTotalIncomesMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnTotalExpensesMain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnBestCategory, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnBestMaster
            // 
            this.pnBestMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.pnBestMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBestMaster.Location = new System.Drawing.Point(942, 10);
            this.pnBestMaster.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnBestMaster.Name = "pnBestMaster";
            this.pnBestMaster.Size = new System.Drawing.Size(307, 236);
            this.pnBestMaster.TabIndex = 3;
            // 
            // pnTotalIncomesMain
            // 
            this.pnTotalIncomesMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.pnTotalIncomesMain.Controls.Add(this.label1);
            this.pnTotalIncomesMain.Controls.Add(this.LbTotalIncomes);
            this.pnTotalIncomesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTotalIncomesMain.Location = new System.Drawing.Point(10, 10);
            this.pnTotalIncomesMain.Margin = new System.Windows.Forms.Padding(10);
            this.pnTotalIncomesMain.Name = "pnTotalIncomesMain";
            this.pnTotalIncomesMain.Size = new System.Drawing.Size(294, 236);
            this.pnTotalIncomesMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Incomes";
            // 
            // LbTotalIncomes
            // 
            this.LbTotalIncomes.AutoSize = true;
            this.LbTotalIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalIncomes.ForeColor = System.Drawing.SystemColors.Control;
            this.LbTotalIncomes.Location = new System.Drawing.Point(15, 55);
            this.LbTotalIncomes.Name = "LbTotalIncomes";
            this.LbTotalIncomes.Size = new System.Drawing.Size(206, 29);
            this.LbTotalIncomes.TabIndex = 0;
            this.LbTotalIncomes.Text = "TOTAL INCOME";
            this.LbTotalIncomes.Click += new System.EventHandler(this.TotalIncomes_Click);
            // 
            // pnTotalExpensesMain
            // 
            this.pnTotalExpensesMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.pnTotalExpensesMain.Controls.Add(this.label2);
            this.pnTotalExpensesMain.Controls.Add(this.LbTotalExpenses);
            this.pnTotalExpensesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTotalExpensesMain.Location = new System.Drawing.Point(314, 10);
            this.pnTotalExpensesMain.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnTotalExpensesMain.Name = "pnTotalExpensesMain";
            this.pnTotalExpensesMain.Size = new System.Drawing.Size(304, 236);
            this.pnTotalExpensesMain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Expenses";
            // 
            // LbTotalExpenses
            // 
            this.LbTotalExpenses.AutoSize = true;
            this.LbTotalExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalExpenses.ForeColor = System.Drawing.SystemColors.Control;
            this.LbTotalExpenses.Location = new System.Drawing.Point(18, 55);
            this.LbTotalExpenses.Name = "LbTotalExpenses";
            this.LbTotalExpenses.Size = new System.Drawing.Size(206, 29);
            this.LbTotalExpenses.TabIndex = 2;
            this.LbTotalExpenses.Text = "TOTAL INCOME";
            this.LbTotalExpenses.Click += new System.EventHandler(this.LbTotalExpenses_Click);
            // 
            // pnBestCategory
            // 
            this.pnBestCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.pnBestCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBestCategory.Location = new System.Drawing.Point(628, 10);
            this.pnBestCategory.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnBestCategory.Name = "pnBestCategory";
            this.pnBestCategory.Size = new System.Drawing.Size(304, 236);
            this.pnBestCategory.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1259, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMainPanel";
            this.Text = "formMainPanel";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnTotalIncomesMain.ResumeLayout(false);
            this.pnTotalIncomesMain.PerformLayout();
            this.pnTotalExpensesMain.ResumeLayout(false);
            this.pnTotalExpensesMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnTotalExpensesMain;
        private System.Windows.Forms.Panel pnTotalIncomesMain;
        private System.Windows.Forms.Panel pnBestMaster;
        private System.Windows.Forms.Panel pnBestCategory;
        private System.Windows.Forms.Label LbTotalIncomes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbTotalExpenses;
        private System.Windows.Forms.Button button1;
    }
}