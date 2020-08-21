namespace Free2D
{
    partial class Form1
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatTabControl2 = new FlatUI.FlatTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.loadText = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.startText = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.drawText = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.updateText = new System.Windows.Forms.RichTextBox();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatButton5 = new FlatUI.FlatButton();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatButton4 = new FlatUI.FlatButton();
            this.roomID = new FlatUI.FlatNumeric();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.flatNumeric2 = new FlatUI.FlatNumeric();
            this.flatNumeric1 = new FlatUI.FlatNumeric();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.gameResolution = new FlatUI.FlatComboBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.gameName = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatMini1 = new FlatUI.FlatMini();
            this.formSkin1.SuspendLayout();
            this.flatTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatTabControl2);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(800, 450);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Free2D";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // flatTabControl2
            // 
            this.flatTabControl2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTabControl2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl2.Controls.Add(this.tabPage3);
            this.flatTabControl2.Controls.Add(this.tabPage4);
            this.flatTabControl2.Controls.Add(this.tabPage5);
            this.flatTabControl2.Controls.Add(this.tabPage6);
            this.flatTabControl2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl2.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl2.Location = new System.Drawing.Point(0, 57);
            this.flatTabControl2.Name = "flatTabControl2";
            this.flatTabControl2.SelectedIndex = 0;
            this.flatTabControl2.Size = new System.Drawing.Size(540, 393);
            this.flatTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.loadText);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(532, 345);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "LoadContent()";
            // 
            // loadText
            // 
            this.loadText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loadText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadText.Location = new System.Drawing.Point(3, 3);
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(526, 339);
            this.loadText.TabIndex = 0;
            this.loadText.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage4.Controls.Add(this.startText);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(532, 345);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Start()";
            // 
            // startText
            // 
            this.startText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.startText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startText.Location = new System.Drawing.Point(3, 3);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(526, 339);
            this.startText.TabIndex = 1;
            this.startText.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage5.Controls.Add(this.drawText);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(532, 345);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Draw()";
            // 
            // drawText
            // 
            this.drawText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.drawText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drawText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawText.Location = new System.Drawing.Point(3, 3);
            this.drawText.Name = "drawText";
            this.drawText.Size = new System.Drawing.Size(526, 339);
            this.drawText.TabIndex = 1;
            this.drawText.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage6.Controls.Add(this.updateText);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(532, 345);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Update()";
            // 
            // updateText
            // 
            this.updateText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.updateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateText.Location = new System.Drawing.Point(3, 3);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(526, 339);
            this.updateText.TabIndex = 1;
            this.updateText.Text = "";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(539, 0);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(261, 450);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.flatButton5);
            this.tabPage1.Controls.Add(this.flatComboBox1);
            this.tabPage1.Controls.Add(this.flatButton4);
            this.tabPage1.Controls.Add(this.roomID);
            this.tabPage1.Controls.Add(this.flatLabel6);
            this.tabPage1.Controls.Add(this.flatLabel5);
            this.tabPage1.Controls.Add(this.flatToggle1);
            this.tabPage1.Controls.Add(this.flatNumeric2);
            this.tabPage1.Controls.Add(this.flatNumeric1);
            this.tabPage1.Controls.Add(this.flatLabel4);
            this.tabPage1.Controls.Add(this.flatLabel3);
            this.tabPage1.Controls.Add(this.gameResolution);
            this.tabPage1.Controls.Add(this.flatLabel2);
            this.tabPage1.Controls.Add(this.gameName);
            this.tabPage1.Controls.Add(this.flatLabel1);
            this.tabPage1.Controls.Add(this.flatButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // flatButton5
            // 
            this.flatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton5.Location = new System.Drawing.Point(134, 252);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(116, 32);
            this.flatButton5.TabIndex = 16;
            this.flatButton5.Text = "Load Project";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // flatComboBox1
            // 
            this.flatComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox1.ForeColor = System.Drawing.Color.White;
            this.flatComboBox1.FormattingEnabled = true;
            this.flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox1.ItemHeight = 18;
            this.flatComboBox1.Location = new System.Drawing.Point(3, 223);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(247, 24);
            this.flatComboBox1.TabIndex = 15;
            // 
            // flatButton4
            // 
            this.flatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(2, 252);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(116, 32);
            this.flatButton4.TabIndex = 14;
            this.flatButton4.Text = "Save Project";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // roomID
            // 
            this.roomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.roomID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.roomID.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.roomID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomID.ForeColor = System.Drawing.Color.White;
            this.roomID.Location = new System.Drawing.Point(3, 150);
            this.roomID.Maximum = ((long)(30));
            this.roomID.Minimum = ((long)(0));
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(113, 30);
            this.roomID.TabIndex = 13;
            this.roomID.Text = "flatNumeric3";
            this.roomID.Value = ((long)(0));
            // 
            // flatLabel6
            // 
            this.flatLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(-1, 134);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(75, 13);
            this.flatLabel6.TabIndex = 12;
            this.flatLabel6.Text = "Start RoomID";
            // 
            // flatLabel5
            // 
            this.flatLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(1, 298);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(156, 17);
            this.flatLabel5.TabIndex = 11;
            this.flatLabel5.Text = "Run game after compiled";
            this.flatLabel5.Click += new System.EventHandler(this.flatLabel5_Click);
            // 
            // flatToggle1
            // 
            this.flatToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = true;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(169, 290);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style1;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 4;
            this.flatToggle1.Text = "gameRunToggle";
            // 
            // flatNumeric2
            // 
            this.flatNumeric2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatNumeric2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatNumeric2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatNumeric2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatNumeric2.ForeColor = System.Drawing.Color.White;
            this.flatNumeric2.Location = new System.Drawing.Point(137, 101);
            this.flatNumeric2.Maximum = ((long)(500));
            this.flatNumeric2.Minimum = ((long)(0));
            this.flatNumeric2.Name = "flatNumeric2";
            this.flatNumeric2.Size = new System.Drawing.Size(113, 30);
            this.flatNumeric2.TabIndex = 10;
            this.flatNumeric2.Text = "flatNumeric2";
            this.flatNumeric2.Value = ((long)(9));
            // 
            // flatNumeric1
            // 
            this.flatNumeric1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatNumeric1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatNumeric1.ForeColor = System.Drawing.Color.White;
            this.flatNumeric1.Location = new System.Drawing.Point(3, 101);
            this.flatNumeric1.Maximum = ((long)(30));
            this.flatNumeric1.Minimum = ((long)(0));
            this.flatNumeric1.Name = "flatNumeric1";
            this.flatNumeric1.Size = new System.Drawing.Size(113, 30);
            this.flatNumeric1.TabIndex = 9;
            this.flatNumeric1.Text = "flatNumeric1";
            this.flatNumeric1.Value = ((long)(4));
            // 
            // flatLabel4
            // 
            this.flatLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(134, 85);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(76, 13);
            this.flatLabel4.TabIndex = 8;
            this.flatLabel4.Text = "Gravity Force:";
            this.flatLabel4.Click += new System.EventHandler(this.flatLabel4_Click);
            // 
            // flatLabel3
            // 
            this.flatLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(0, 85);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(100, 13);
            this.flatLabel3.TabIndex = 7;
            this.flatLabel3.Text = "Simulation Speed:";
            this.flatLabel3.Click += new System.EventHandler(this.flatLabel3_Click);
            // 
            // gameResolution
            // 
            this.gameResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.gameResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameResolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameResolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gameResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameResolution.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gameResolution.ForeColor = System.Drawing.Color.White;
            this.gameResolution.FormattingEnabled = true;
            this.gameResolution.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.gameResolution.ItemHeight = 18;
            this.gameResolution.Items.AddRange(new object[] {
            "640×480",
            "800×600",
            "960×720",
            "1024×768",
            "1280×960",
            "1400×1050",
            "1440×1080",
            "1600×1200",
            "1920x1080"});
            this.gameResolution.Location = new System.Drawing.Point(3, 58);
            this.gameResolution.Name = "gameResolution";
            this.gameResolution.Size = new System.Drawing.Size(247, 24);
            this.gameResolution.TabIndex = 4;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(3, 45);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(113, 13);
            this.flatLabel2.TabIndex = 3;
            this.flatLabel2.Text = "Window Resolution:";
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameName.FocusOnHover = false;
            this.gameName.Location = new System.Drawing.Point(3, 16);
            this.gameName.MaxLength = 32767;
            this.gameName.Multiline = false;
            this.gameName.Name = "gameName";
            this.gameName.ReadOnly = false;
            this.gameName.Size = new System.Drawing.Size(247, 29);
            this.gameName.TabIndex = 2;
            this.gameName.Text = "Demo Game";
            this.gameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gameName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gameName.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(3, 3);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(116, 13);
            this.flatLabel1.TabIndex = 1;
            this.flatLabel1.Text = "Project / Game Name:";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(3, 329);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(247, 70);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Build & Run";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flatButton3);
            this.tabPage2.Controls.Add(this.flatButton2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(253, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(6, 44);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(241, 32);
            this.flatButton3.TabIndex = 1;
            this.flatButton3.Text = "Key Input Editor";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(6, 6);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(241, 32);
            this.flatButton2.TabIndex = 0;
            this.flatButton2.Text = "Global Var Editor";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(515, 0);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 2;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(515, 18);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 1;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(515, 30);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatMini1.Click += new System.EventHandler(this.flatMini1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatComboBox gameResolution;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox gameName;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatNumeric flatNumeric2;
        private FlatUI.FlatNumeric flatNumeric1;
        private FlatUI.FlatToggle flatToggle1;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatTabControl flatTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox loadText;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatNumeric roomID;
        private FlatUI.FlatLabel flatLabel6;
        private System.Windows.Forms.RichTextBox startText;
        private System.Windows.Forms.RichTextBox drawText;
        private System.Windows.Forms.RichTextBox updateText;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatButton flatButton5;
        private FlatUI.FlatComboBox flatComboBox1;
    }
}

