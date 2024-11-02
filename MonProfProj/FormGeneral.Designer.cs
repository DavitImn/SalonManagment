namespace MonProfProj
{
    partial class FormGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            this.pnBackGround = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnSideBox = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MastersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ViewExpensesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ViewIncomesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExpensesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.IncomesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.VisitDateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MainButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnTopBox = new System.Windows.Forms.Panel();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.DashBoardButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnBackGround.SuspendLayout();
            this.pnSideBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnTopBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBackGround
            // 
            this.pnBackGround.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBackGround.Controls.Add(this.pnContainer);
            this.pnBackGround.Controls.Add(this.pnSideBox);
            this.pnBackGround.Controls.Add(this.pnTopBox);
            this.pnBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnBackGround.Name = "pnBackGround";
            this.pnBackGround.Size = new System.Drawing.Size(1396, 648);
            this.pnBackGround.TabIndex = 0;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(210, 30);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1186, 618);
            this.pnContainer.TabIndex = 2;
            this.pnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainer_Paint);
            // 
            // pnSideBox
            // 
            this.pnSideBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.pnSideBox.Controls.Add(this.tableLayoutPanel1);
            this.pnSideBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideBox.Location = new System.Drawing.Point(0, 30);
            this.pnSideBox.Margin = new System.Windows.Forms.Padding(0);
            this.pnSideBox.Name = "pnSideBox";
            this.pnSideBox.Size = new System.Drawing.Size(210, 618);
            this.pnSideBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MastersButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ViewExpensesButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ViewIncomesButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ExpensesButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.IncomesButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.VisitDateButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogoutButton, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MastersButton
            // 
            this.MastersButton.Activecolor = System.Drawing.Color.Transparent;
            this.MastersButton.BackColor = System.Drawing.Color.Transparent;
            this.MastersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MastersButton.BorderRadius = 0;
            this.MastersButton.ButtonText = "Masters";
            this.MastersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MastersButton.DisabledColor = System.Drawing.Color.Gray;
            this.MastersButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MastersButton.Iconimage = global::MonProfProj.Properties.Resources.women;
            this.MastersButton.Iconimage_right = null;
            this.MastersButton.Iconimage_right_Selected = null;
            this.MastersButton.Iconimage_Selected = null;
            this.MastersButton.IconMarginLeft = 0;
            this.MastersButton.IconMarginRight = 0;
            this.MastersButton.IconRightVisible = true;
            this.MastersButton.IconRightZoom = 0D;
            this.MastersButton.IconVisible = true;
            this.MastersButton.IconZoom = 90D;
            this.MastersButton.IsTab = false;
            this.MastersButton.Location = new System.Drawing.Point(2, 372);
            this.MastersButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.MastersButton.Name = "MastersButton";
            this.MastersButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MastersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.MastersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.MastersButton.selected = false;
            this.MastersButton.Size = new System.Drawing.Size(208, 50);
            this.MastersButton.TabIndex = 6;
            this.MastersButton.Text = "Masters";
            this.MastersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MastersButton.Textcolor = System.Drawing.Color.White;
            this.MastersButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MastersButton.Click += new System.EventHandler(this.MastersButton_Click);
            // 
            // ViewExpensesButton
            // 
            this.ViewExpensesButton.Activecolor = System.Drawing.Color.Transparent;
            this.ViewExpensesButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewExpensesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewExpensesButton.BorderRadius = 0;
            this.ViewExpensesButton.ButtonText = "View Expenses";
            this.ViewExpensesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewExpensesButton.DisabledColor = System.Drawing.Color.Gray;
            this.ViewExpensesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ViewExpensesButton.Iconimage = global::MonProfProj.Properties.Resources.viewExpenses;
            this.ViewExpensesButton.Iconimage_right = null;
            this.ViewExpensesButton.Iconimage_right_Selected = null;
            this.ViewExpensesButton.Iconimage_Selected = null;
            this.ViewExpensesButton.IconMarginLeft = 0;
            this.ViewExpensesButton.IconMarginRight = 0;
            this.ViewExpensesButton.IconRightVisible = true;
            this.ViewExpensesButton.IconRightZoom = 0D;
            this.ViewExpensesButton.IconVisible = true;
            this.ViewExpensesButton.IconZoom = 90D;
            this.ViewExpensesButton.IsTab = false;
            this.ViewExpensesButton.Location = new System.Drawing.Point(2, 311);
            this.ViewExpensesButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.ViewExpensesButton.Name = "ViewExpensesButton";
            this.ViewExpensesButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ViewExpensesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ViewExpensesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.ViewExpensesButton.selected = false;
            this.ViewExpensesButton.Size = new System.Drawing.Size(208, 50);
            this.ViewExpensesButton.TabIndex = 5;
            this.ViewExpensesButton.Text = "View Expenses";
            this.ViewExpensesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewExpensesButton.Textcolor = System.Drawing.Color.White;
            this.ViewExpensesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewExpensesButton.Click += new System.EventHandler(this.ViewExpensesButton_Click);
            // 
            // ViewIncomesButton
            // 
            this.ViewIncomesButton.Activecolor = System.Drawing.Color.Transparent;
            this.ViewIncomesButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewIncomesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewIncomesButton.BorderRadius = 0;
            this.ViewIncomesButton.ButtonText = "View Incomes";
            this.ViewIncomesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewIncomesButton.DisabledColor = System.Drawing.Color.Gray;
            this.ViewIncomesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ViewIncomesButton.Iconimage = global::MonProfProj.Properties.Resources.viewIncomes;
            this.ViewIncomesButton.Iconimage_right = null;
            this.ViewIncomesButton.Iconimage_right_Selected = null;
            this.ViewIncomesButton.Iconimage_Selected = null;
            this.ViewIncomesButton.IconMarginLeft = 0;
            this.ViewIncomesButton.IconMarginRight = 0;
            this.ViewIncomesButton.IconRightVisible = true;
            this.ViewIncomesButton.IconRightZoom = 0D;
            this.ViewIncomesButton.IconVisible = true;
            this.ViewIncomesButton.IconZoom = 90D;
            this.ViewIncomesButton.IsTab = false;
            this.ViewIncomesButton.Location = new System.Drawing.Point(2, 250);
            this.ViewIncomesButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.ViewIncomesButton.Name = "ViewIncomesButton";
            this.ViewIncomesButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ViewIncomesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ViewIncomesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.ViewIncomesButton.selected = false;
            this.ViewIncomesButton.Size = new System.Drawing.Size(208, 50);
            this.ViewIncomesButton.TabIndex = 4;
            this.ViewIncomesButton.Text = "View Incomes";
            this.ViewIncomesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewIncomesButton.Textcolor = System.Drawing.Color.White;
            this.ViewIncomesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewIncomesButton.Click += new System.EventHandler(this.ViewIncomesButton_Click);
            // 
            // ExpensesButton
            // 
            this.ExpensesButton.Activecolor = System.Drawing.Color.Transparent;
            this.ExpensesButton.BackColor = System.Drawing.Color.Transparent;
            this.ExpensesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExpensesButton.BorderRadius = 0;
            this.ExpensesButton.ButtonText = "Expenses";
            this.ExpensesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpensesButton.DisabledColor = System.Drawing.Color.Gray;
            this.ExpensesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExpensesButton.Iconimage = global::MonProfProj.Properties.Resources.expenses;
            this.ExpensesButton.Iconimage_right = null;
            this.ExpensesButton.Iconimage_right_Selected = null;
            this.ExpensesButton.Iconimage_Selected = null;
            this.ExpensesButton.IconMarginLeft = 0;
            this.ExpensesButton.IconMarginRight = 0;
            this.ExpensesButton.IconRightVisible = true;
            this.ExpensesButton.IconRightZoom = 0D;
            this.ExpensesButton.IconVisible = true;
            this.ExpensesButton.IconZoom = 90D;
            this.ExpensesButton.IsTab = false;
            this.ExpensesButton.Location = new System.Drawing.Point(2, 189);
            this.ExpensesButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.ExpensesButton.Name = "ExpensesButton";
            this.ExpensesButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ExpensesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ExpensesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.ExpensesButton.selected = false;
            this.ExpensesButton.Size = new System.Drawing.Size(208, 50);
            this.ExpensesButton.TabIndex = 3;
            this.ExpensesButton.Text = "Expenses";
            this.ExpensesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpensesButton.Textcolor = System.Drawing.Color.White;
            this.ExpensesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExpensesButton.Click += new System.EventHandler(this.ExpensesButton_Click);
            // 
            // IncomesButton
            // 
            this.IncomesButton.Activecolor = System.Drawing.Color.Transparent;
            this.IncomesButton.BackColor = System.Drawing.Color.Transparent;
            this.IncomesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncomesButton.BorderRadius = 0;
            this.IncomesButton.ButtonText = "Incomes";
            this.IncomesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomesButton.DisabledColor = System.Drawing.Color.Gray;
            this.IncomesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.IncomesButton.Iconimage = global::MonProfProj.Properties.Resources.income;
            this.IncomesButton.Iconimage_right = null;
            this.IncomesButton.Iconimage_right_Selected = null;
            this.IncomesButton.Iconimage_Selected = null;
            this.IncomesButton.IconMarginLeft = 0;
            this.IncomesButton.IconMarginRight = 0;
            this.IncomesButton.IconRightVisible = true;
            this.IncomesButton.IconRightZoom = 0D;
            this.IncomesButton.IconVisible = true;
            this.IncomesButton.IconZoom = 90D;
            this.IncomesButton.IsTab = false;
            this.IncomesButton.Location = new System.Drawing.Point(2, 128);
            this.IncomesButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.IncomesButton.Name = "IncomesButton";
            this.IncomesButton.Normalcolor = System.Drawing.Color.Transparent;
            this.IncomesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.IncomesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.IncomesButton.selected = false;
            this.IncomesButton.Size = new System.Drawing.Size(208, 50);
            this.IncomesButton.TabIndex = 2;
            this.IncomesButton.Text = "Incomes";
            this.IncomesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncomesButton.Textcolor = System.Drawing.Color.White;
            this.IncomesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IncomesButton.Click += new System.EventHandler(this.IncomesButton_Click);
            // 
            // VisitDateButton
            // 
            this.VisitDateButton.Activecolor = System.Drawing.Color.Transparent;
            this.VisitDateButton.BackColor = System.Drawing.Color.Transparent;
            this.VisitDateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisitDateButton.BorderRadius = 0;
            this.VisitDateButton.ButtonText = "Visit Date";
            this.VisitDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitDateButton.DisabledColor = System.Drawing.Color.Gray;
            this.VisitDateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.VisitDateButton.Iconimage = global::MonProfProj.Properties.Resources.visitDate;
            this.VisitDateButton.Iconimage_right = null;
            this.VisitDateButton.Iconimage_right_Selected = null;
            this.VisitDateButton.Iconimage_Selected = null;
            this.VisitDateButton.IconMarginLeft = 0;
            this.VisitDateButton.IconMarginRight = 0;
            this.VisitDateButton.IconRightVisible = true;
            this.VisitDateButton.IconRightZoom = 0D;
            this.VisitDateButton.IconVisible = true;
            this.VisitDateButton.IconZoom = 90D;
            this.VisitDateButton.IsTab = false;
            this.VisitDateButton.Location = new System.Drawing.Point(2, 67);
            this.VisitDateButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.VisitDateButton.Name = "VisitDateButton";
            this.VisitDateButton.Normalcolor = System.Drawing.Color.Transparent;
            this.VisitDateButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.VisitDateButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.VisitDateButton.selected = false;
            this.VisitDateButton.Size = new System.Drawing.Size(208, 50);
            this.VisitDateButton.TabIndex = 1;
            this.VisitDateButton.Text = "Visit Date";
            this.VisitDateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VisitDateButton.Textcolor = System.Drawing.Color.White;
            this.VisitDateButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VisitDateButton.Click += new System.EventHandler(this.VisitDateButton_Click);
            // 
            // MainButton
            // 
            this.MainButton.Activecolor = System.Drawing.Color.Transparent;
            this.MainButton.BackColor = System.Drawing.Color.Transparent;
            this.MainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainButton.BorderRadius = 0;
            this.MainButton.ButtonText = "Main Panel";
            this.MainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainButton.DisabledColor = System.Drawing.Color.Gray;
            this.MainButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MainButton.Iconimage = global::MonProfProj.Properties.Resources.dashboard___ACT;
            this.MainButton.Iconimage_right = null;
            this.MainButton.Iconimage_right_Selected = null;
            this.MainButton.Iconimage_Selected = null;
            this.MainButton.IconMarginLeft = 0;
            this.MainButton.IconMarginRight = 0;
            this.MainButton.IconRightVisible = true;
            this.MainButton.IconRightZoom = 0D;
            this.MainButton.IconVisible = true;
            this.MainButton.IconZoom = 90D;
            this.MainButton.IsTab = false;
            this.MainButton.Location = new System.Drawing.Point(2, 6);
            this.MainButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.MainButton.Name = "MainButton";
            this.MainButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MainButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.MainButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.MainButton.selected = false;
            this.MainButton.Size = new System.Drawing.Size(208, 50);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Main Panel";
            this.MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.Textcolor = System.Drawing.Color.White;
            this.MainButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Activecolor = System.Drawing.Color.Transparent;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutButton.BorderRadius = 0;
            this.LogoutButton.ButtonText = "Logout";
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogoutButton.Iconimage = global::MonProfProj.Properties.Resources.logout___ACT;
            this.LogoutButton.Iconimage_right = null;
            this.LogoutButton.Iconimage_right_Selected = null;
            this.LogoutButton.Iconimage_Selected = null;
            this.LogoutButton.IconMarginLeft = 0;
            this.LogoutButton.IconMarginRight = 0;
            this.LogoutButton.IconRightVisible = true;
            this.LogoutButton.IconRightZoom = 0D;
            this.LogoutButton.IconVisible = true;
            this.LogoutButton.IconZoom = 90D;
            this.LogoutButton.IsTab = false;
            this.LogoutButton.Location = new System.Drawing.Point(2, 555);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LogoutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.LogoutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(88)))), ((int)(((byte)(198)))));
            this.LogoutButton.selected = false;
            this.LogoutButton.Size = new System.Drawing.Size(208, 50);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Textcolor = System.Drawing.Color.White;
            this.LogoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            // 
            // pnTopBox
            // 
            this.pnTopBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.pnTopBox.Controls.Add(this.MinimizeButton);
            this.pnTopBox.Controls.Add(this.MaximizeButton);
            this.pnTopBox.Controls.Add(this.ExitButton);
            this.pnTopBox.Controls.Add(this.DashBoardButton);
            this.pnTopBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBox.Location = new System.Drawing.Point(0, 0);
            this.pnTopBox.Margin = new System.Windows.Forms.Padding(0);
            this.pnTopBox.Name = "pnTopBox";
            this.pnTopBox.Size = new System.Drawing.Size(1396, 30);
            this.pnTopBox.TabIndex = 0;
            this.pnTopBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnTopBox_MouseDoubleClick);
            this.pnTopBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopBox_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(1311, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Zoom = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeButton.Image = global::MonProfProj.Properties.Resources.maximizeNew;
            this.MaximizeButton.ImageActive = null;
            this.MaximizeButton.Location = new System.Drawing.Point(1341, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Zoom = 10;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.Image = global::MonProfProj.Properties.Resources.cross2;
            this.ExitButton.ImageActive = null;
            this.ExitButton.Location = new System.Drawing.Point(1371, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 30);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DashBoardButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashBoardButton.Image = global::MonProfProj.Properties.Resources.menuPoint;
            this.DashBoardButton.ImageActive = null;
            this.DashBoardButton.Location = new System.Drawing.Point(0, 0);
            this.DashBoardButton.Margin = new System.Windows.Forms.Padding(0);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Size = new System.Drawing.Size(67, 30);
            this.DashBoardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashBoardButton.TabIndex = 0;
            this.DashBoardButton.TabStop = false;
            this.DashBoardButton.Zoom = 10;
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // FormGeneral
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1396, 648);
            this.Controls.Add(this.pnBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnBackGround.ResumeLayout(false);
            this.pnSideBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnTopBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackGround;
        private System.Windows.Forms.Panel pnSideBox;
        private System.Windows.Forms.Panel pnTopBox;
        private System.Windows.Forms.Panel pnContainer;
        private Bunifu.Framework.UI.BunifuFlatButton MainButton;
        private Bunifu.Framework.UI.BunifuImageButton DashBoardButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton MastersButton;
        private Bunifu.Framework.UI.BunifuFlatButton ViewExpensesButton;
        private Bunifu.Framework.UI.BunifuFlatButton ViewIncomesButton;
        private Bunifu.Framework.UI.BunifuFlatButton ExpensesButton;
        private Bunifu.Framework.UI.BunifuFlatButton IncomesButton;
        private Bunifu.Framework.UI.BunifuFlatButton VisitDateButton;
        private Bunifu.Framework.UI.BunifuFlatButton LogoutButton;
        private Bunifu.Framework.UI.BunifuImageButton ExitButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeButton;
    }
}

