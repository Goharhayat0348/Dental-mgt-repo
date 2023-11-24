namespace Dental_Managment.Forms
{
    partial class FrmUserLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblMaximized = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblMinimize = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblExit = new Bunifu.UI.WinForms.BunifuLabel();
            this.progresbarLoadLog = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.mtbtn_LogIn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_Branch = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_UserName = new System.Windows.Forms.Panel();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.picbox_UserAccount = new System.Windows.Forms.PictureBox();
            this.lbl_jewellryManagement = new System.Windows.Forms.Label();
            this.pnl_Password = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.picbox_Lock = new System.Windows.Forms.PictureBox();
            this.lbl_WelcomeToSwarnapp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_UserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_UserAccount)).BeginInit();
            this.pnl_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.progresbarLoadLog);
            this.panel1.Controls.Add(this.picLoader);
            this.panel1.Controls.Add(this.pnl_login);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 551);
            this.panel1.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblMaximized);
            this.bunifuPanel1.Controls.Add(this.lblMinimize);
            this.bunifuPanel1.Controls.Add(this.lblExit);
            this.bunifuPanel1.Location = new System.Drawing.Point(853, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(135, 35);
            this.bunifuPanel1.TabIndex = 400;
            // 
            // lblMaximized
            // 
            this.lblMaximized.AllowParentOverrides = false;
            this.lblMaximized.AutoEllipsis = false;
            this.lblMaximized.AutoSize = false;
            this.lblMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaximized.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblMaximized.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximized.ForeColor = System.Drawing.Color.Red;
            this.lblMaximized.Location = new System.Drawing.Point(65, 3);
            this.lblMaximized.Name = "lblMaximized";
            this.lblMaximized.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaximized.Size = new System.Drawing.Size(30, 27);
            this.lblMaximized.TabIndex = 7;
            this.lblMaximized.Text = "#";
            this.lblMaximized.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaximized.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblMaximized.Click += new System.EventHandler(this.lblMaximized_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AllowParentOverrides = false;
            this.lblMinimize.AutoEllipsis = false;
            this.lblMinimize.AutoSize = false;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Red;
            this.lblMinimize.Location = new System.Drawing.Point(21, 4);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinimize.Size = new System.Drawing.Size(30, 27);
            this.lblMinimize.TabIndex = 6;
            this.lblMinimize.Text = "--";
            this.lblMinimize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimize.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblExit
            // 
            this.lblExit.AllowParentOverrides = false;
            this.lblExit.AutoEllipsis = false;
            this.lblExit.AutoSize = false;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(101, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExit.Size = new System.Drawing.Size(30, 27);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // progresbarLoadLog
            // 
            this.progresbarLoadLog.AllowAnimations = false;
            this.progresbarLoadLog.Animation = 0;
            this.progresbarLoadLog.AnimationSpeed = 220;
            this.progresbarLoadLog.AnimationStep = 10;
            this.progresbarLoadLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progresbarLoadLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progresbarLoadLog.BackgroundImage")));
            this.progresbarLoadLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progresbarLoadLog.BorderRadius = 40;
            this.progresbarLoadLog.BorderThickness = 1;
            this.progresbarLoadLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progresbarLoadLog.Location = new System.Drawing.Point(0, 511);
            this.progresbarLoadLog.Maximum = 100;
            this.progresbarLoadLog.MaximumValue = 100;
            this.progresbarLoadLog.Minimum = 0;
            this.progresbarLoadLog.MinimumValue = 0;
            this.progresbarLoadLog.Name = "progresbarLoadLog";
            this.progresbarLoadLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progresbarLoadLog.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progresbarLoadLog.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progresbarLoadLog.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.progresbarLoadLog.Size = new System.Drawing.Size(988, 40);
            this.progresbarLoadLog.TabIndex = 399;
            this.progresbarLoadLog.Value = 0;
            this.progresbarLoadLog.ValueByTransition = 0;
            // 
            // picLoader
            // 
            this.picLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.Location = new System.Drawing.Point(0, 0);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(988, 551);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoader.TabIndex = 398;
            this.picLoader.TabStop = false;
            // 
            // pnl_login
            // 
            this.pnl_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.pnl_login.Controls.Add(this.mtbtn_LogIn);
            this.pnl_login.Controls.Add(this.pictureBox3);
            this.pnl_login.Controls.Add(this.panel2);
            this.pnl_login.Controls.Add(this.pnl_UserName);
            this.pnl_login.Controls.Add(this.lbl_jewellryManagement);
            this.pnl_login.Controls.Add(this.pnl_Password);
            this.pnl_login.Controls.Add(this.lbl_WelcomeToSwarnapp);
            this.pnl_login.Controls.Add(this.pictureBox1);
            this.pnl_login.Location = new System.Drawing.Point(214, 145);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(485, 260);
            this.pnl_login.TabIndex = 397;
            // 
            // mtbtn_LogIn
            // 
            this.mtbtn_LogIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mtbtn_LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtbtn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mtbtn_LogIn.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbtn_LogIn.ForeColor = System.Drawing.Color.White;
            this.mtbtn_LogIn.Location = new System.Drawing.Point(257, 180);
            this.mtbtn_LogIn.Name = "mtbtn_LogIn";
            this.mtbtn_LogIn.Size = new System.Drawing.Size(154, 32);
            this.mtbtn_LogIn.TabIndex = 374;
            this.mtbtn_LogIn.Text = "Log In";
            this.mtbtn_LogIn.UseVisualStyleBackColor = false;
            this.mtbtn_LogIn.Click += new System.EventHandler(this.mtbtn_LogIn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(57, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.TabIndex = 373;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmb_Branch);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(184, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 41);
            this.panel2.TabIndex = 371;
            // 
            // cmb_Branch
            // 
            this.cmb_Branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Branch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Branch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_Branch.FormattingEnabled = true;
            this.cmb_Branch.Location = new System.Drawing.Point(34, 9);
            this.cmb_Branch.Name = "cmb_Branch";
            this.cmb_Branch.Size = new System.Drawing.Size(256, 23);
            this.cmb_Branch.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(7, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 24);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_UserName
            // 
            this.pnl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.pnl_UserName.Controls.Add(this.txt_UserName);
            this.pnl_UserName.Controls.Add(this.picbox_UserAccount);
            this.pnl_UserName.Location = new System.Drawing.Point(184, 85);
            this.pnl_UserName.Name = "pnl_UserName";
            this.pnl_UserName.Size = new System.Drawing.Size(295, 41);
            this.pnl_UserName.TabIndex = 366;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_UserName.Location = new System.Drawing.Point(31, 7);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(260, 27);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.Text = "UserName";
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            // 
            // picbox_UserAccount
            // 
            this.picbox_UserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.picbox_UserAccount.Image = ((System.Drawing.Image)(resources.GetObject("picbox_UserAccount.Image")));
            this.picbox_UserAccount.Location = new System.Drawing.Point(7, 9);
            this.picbox_UserAccount.Name = "picbox_UserAccount";
            this.picbox_UserAccount.Size = new System.Drawing.Size(21, 24);
            this.picbox_UserAccount.TabIndex = 0;
            this.picbox_UserAccount.TabStop = false;
            // 
            // lbl_jewellryManagement
            // 
            this.lbl_jewellryManagement.AutoSize = true;
            this.lbl_jewellryManagement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jewellryManagement.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jewellryManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_jewellryManagement.Location = new System.Drawing.Point(91, 220);
            this.lbl_jewellryManagement.Name = "lbl_jewellryManagement";
            this.lbl_jewellryManagement.Size = new System.Drawing.Size(310, 29);
            this.lbl_jewellryManagement.TabIndex = 370;
            this.lbl_jewellryManagement.Text = "Dental Management Software";
            // 
            // pnl_Password
            // 
            this.pnl_Password.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Password.Controls.Add(this.txt_Password);
            this.pnl_Password.Controls.Add(this.picbox_Lock);
            this.pnl_Password.Location = new System.Drawing.Point(184, 131);
            this.pnl_Password.Name = "pnl_Password";
            this.pnl_Password.Size = new System.Drawing.Size(294, 38);
            this.pnl_Password.TabIndex = 367;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Password.Location = new System.Drawing.Point(32, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(259, 27);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // picbox_Lock
            // 
            this.picbox_Lock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.picbox_Lock.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Lock.Image")));
            this.picbox_Lock.Location = new System.Drawing.Point(8, 9);
            this.picbox_Lock.Name = "picbox_Lock";
            this.picbox_Lock.Size = new System.Drawing.Size(20, 22);
            this.picbox_Lock.TabIndex = 1;
            this.picbox_Lock.TabStop = false;
            // 
            // lbl_WelcomeToSwarnapp
            // 
            this.lbl_WelcomeToSwarnapp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WelcomeToSwarnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeToSwarnapp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(191)))), ((int)(((byte)(88)))));
            this.lbl_WelcomeToSwarnapp.Location = new System.Drawing.Point(3, 2);
            this.lbl_WelcomeToSwarnapp.Name = "lbl_WelcomeToSwarnapp";
            this.lbl_WelcomeToSwarnapp.Size = new System.Drawing.Size(479, 42);
            this.lbl_WelcomeToSwarnapp.TabIndex = 369;
            this.lbl_WelcomeToSwarnapp.Text = "WELCOME TO DENTAL CLINIC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // FrmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 551);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserLogin";
            this.Text = "FrmUserLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_UserName.ResumeLayout(false);
            this.pnl_UserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_UserAccount)).EndInit();
            this.pnl_Password.ResumeLayout(false);
            this.pnl_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuProgressBar progresbarLoadLog;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button mtbtn_LogIn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_Branch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.PictureBox picbox_UserAccount;
        private System.Windows.Forms.Label lbl_jewellryManagement;
        private System.Windows.Forms.Panel pnl_Password;
        public System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox picbox_Lock;
        private System.Windows.Forms.Label lbl_WelcomeToSwarnapp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblMaximized;
        private Bunifu.UI.WinForms.BunifuLabel lblMinimize;
        private Bunifu.UI.WinForms.BunifuLabel lblExit;
    }
}