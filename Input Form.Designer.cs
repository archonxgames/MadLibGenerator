namespace MadLib_Game_Gen
{
	partial class inputForm
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
			this.titleBar = new System.Windows.Forms.Panel();
			this.titleBar_Logo = new System.Windows.Forms.PictureBox();
			this.cardOptions_tabControl = new System.Windows.Forms.TabControl();
			this.excusedCard = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.excused_signed_textBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.excused_noun_textBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.excused_adjective_textBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.excused_name_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.excusedCard_A_label = new System.Windows.Forms.Label();
			this.excused_date_textBox = new System.Windows.Forms.TextBox();
			this.date_label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.hallPass_Card = new System.Windows.Forms.TabPage();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.hallPass_substance_textBox = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.hallPass_fluid_textBox = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.hallPass_body_textBox = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.hallPass_name_textBox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.hallPass_date_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cardChooser_label = new System.Windows.Forms.Label();
			this.cardChooser_comboBox = new System.Windows.Forms.ComboBox();
			this.generate_button = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.titleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.titleBar_Logo)).BeginInit();
			this.cardOptions_tabControl.SuspendLayout();
			this.excusedCard.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.hallPass_Card.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.Black;
			this.titleBar.Controls.Add(this.titleBar_Logo);
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.Size = new System.Drawing.Size(382, 85);
			this.titleBar.TabIndex = 1;
			this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
			this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
			this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
			// 
			// titleBar_Logo
			// 
			this.titleBar_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleBar_Logo.BackColor = System.Drawing.Color.Black;
			this.titleBar_Logo.BackgroundImage = global::MadLib_Game_Gen.Properties.Resources.madlibs_logo;
			this.titleBar_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.titleBar_Logo.Location = new System.Drawing.Point(35, 12);
			this.titleBar_Logo.Name = "titleBar_Logo";
			this.titleBar_Logo.Size = new System.Drawing.Size(318, 64);
			this.titleBar_Logo.TabIndex = 0;
			this.titleBar_Logo.TabStop = false;
			// 
			// cardOptions_tabControl
			// 
			this.cardOptions_tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.cardOptions_tabControl.Controls.Add(this.excusedCard);
			this.cardOptions_tabControl.Controls.Add(this.hallPass_Card);
			this.cardOptions_tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.cardOptions_tabControl.Location = new System.Drawing.Point(0, 135);
			this.cardOptions_tabControl.Name = "cardOptions_tabControl";
			this.cardOptions_tabControl.SelectedIndex = 0;
			this.cardOptions_tabControl.Size = new System.Drawing.Size(382, 378);
			this.cardOptions_tabControl.TabIndex = 2;
			// 
			// excusedCard
			// 
			this.excusedCard.BackColor = System.Drawing.Color.White;
			this.excusedCard.Controls.Add(this.panel1);
			this.excusedCard.Controls.Add(this.pictureBox1);
			this.excusedCard.Controls.Add(this.label12);
			this.excusedCard.Controls.Add(this.label7);
			this.excusedCard.Controls.Add(this.excused_noun_textBox);
			this.excusedCard.Controls.Add(this.label11);
			this.excusedCard.Controls.Add(this.label10);
			this.excusedCard.Controls.Add(this.label8);
			this.excusedCard.Controls.Add(this.excused_adjective_textBox);
			this.excusedCard.Controls.Add(this.label9);
			this.excusedCard.Controls.Add(this.label6);
			this.excusedCard.Controls.Add(this.label5);
			this.excusedCard.Controls.Add(this.label4);
			this.excusedCard.Controls.Add(this.excused_name_textBox);
			this.excusedCard.Controls.Add(this.label3);
			this.excusedCard.Controls.Add(this.excusedCard_A_label);
			this.excusedCard.Controls.Add(this.excused_date_textBox);
			this.excusedCard.Controls.Add(this.date_label);
			this.excusedCard.Controls.Add(this.label2);
			this.excusedCard.Location = new System.Drawing.Point(4, 25);
			this.excusedCard.Name = "excusedCard";
			this.excusedCard.Padding = new System.Windows.Forms.Padding(3);
			this.excusedCard.Size = new System.Drawing.Size(374, 349);
			this.excusedCard.TabIndex = 0;
			this.excusedCard.Text = "Excused";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.excused_signed_textBox);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Location = new System.Drawing.Point(96, 260);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(257, 81);
			this.panel1.TabIndex = 19;
			// 
			// excused_signed_textBox
			// 
			this.excused_signed_textBox.BackColor = System.Drawing.Color.White;
			this.excused_signed_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.excused_signed_textBox.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.excused_signed_textBox.Location = new System.Drawing.Point(20, 30);
			this.excused_signed_textBox.Name = "excused_signed_textBox";
			this.excused_signed_textBox.Size = new System.Drawing.Size(221, 39);
			this.excused_signed_textBox.TabIndex = 10;
			this.excused_signed_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(0, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 27);
			this.label13.TabIndex = 1;
			this.label13.Text = "Signed:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::MadLib_Game_Gen.Properties.Resources.Capture;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(77, 335);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(307, 212);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 23);
			this.label12.TabIndex = 17;
			this.label12.Text = "class.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(207, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 19);
			this.label7.TabIndex = 16;
			this.label7.Text = "NOUN";
			// 
			// excused_noun_textBox
			// 
			this.excused_noun_textBox.BackColor = System.Drawing.Color.White;
			this.excused_noun_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.excused_noun_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.excused_noun_textBox.Location = new System.Drawing.Point(195, 210);
			this.excused_noun_textBox.Name = "excused_noun_textBox";
			this.excused_noun_textBox.Size = new System.Drawing.Size(95, 23);
			this.excused_noun_textBox.TabIndex = 14;
			this.excused_noun_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(186, 225);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(115, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = "__________________";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(98, 212);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "to attend";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(233, 188);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 19);
			this.label8.TabIndex = 11;
			this.label8.Text = "ADJECTIVE";
			// 
			// excused_adjective_textBox
			// 
			this.excused_adjective_textBox.BackColor = System.Drawing.Color.White;
			this.excused_adjective_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.excused_adjective_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.excused_adjective_textBox.Location = new System.Drawing.Point(213, 162);
			this.excused_adjective_textBox.Name = "excused_adjective_textBox";
			this.excused_adjective_textBox.Size = new System.Drawing.Size(134, 23);
			this.excused_adjective_textBox.TabIndex = 9;
			this.excused_adjective_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(208, 175);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "_______________________";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(83, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "who is far too";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(298, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = ",";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(216, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "NAME";
			// 
			// excused_name_textBox
			// 
			this.excused_name_textBox.BackColor = System.Drawing.Color.White;
			this.excused_name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.excused_name_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.excused_name_textBox.Location = new System.Drawing.Point(177, 108);
			this.excused_name_textBox.Name = "excused_name_textBox";
			this.excused_name_textBox.Size = new System.Drawing.Size(124, 23);
			this.excused_name_textBox.TabIndex = 4;
			this.excused_name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(175, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "____________________";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// excusedCard_A_label
			// 
			this.excusedCard_A_label.AutoSize = true;
			this.excusedCard_A_label.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.excusedCard_A_label.Location = new System.Drawing.Point(174, 82);
			this.excusedCard_A_label.Name = "excusedCard_A_label";
			this.excusedCard_A_label.Size = new System.Drawing.Size(128, 23);
			this.excusedCard_A_label.TabIndex = 3;
			this.excusedCard_A_label.Text = "Please excuse";
			// 
			// excused_date_textBox
			// 
			this.excused_date_textBox.BackColor = System.Drawing.Color.White;
			this.excused_date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.excused_date_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.excused_date_textBox.Location = new System.Drawing.Point(206, 26);
			this.excused_date_textBox.Name = "excused_date_textBox";
			this.excused_date_textBox.Size = new System.Drawing.Size(113, 23);
			this.excused_date_textBox.TabIndex = 1;
			this.excused_date_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// date_label
			// 
			this.date_label.AutoSize = true;
			this.date_label.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_label.Location = new System.Drawing.Point(144, 26);
			this.date_label.Name = "date_label";
			this.date_label.Size = new System.Drawing.Size(58, 27);
			this.date_label.TabIndex = 0;
			this.date_label.Text = "Date:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(194, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "_____________________";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hallPass_Card
			// 
			this.hallPass_Card.BackColor = System.Drawing.Color.White;
			this.hallPass_Card.Controls.Add(this.panel2);
			this.hallPass_Card.Controls.Add(this.label26);
			this.hallPass_Card.Controls.Add(this.label27);
			this.hallPass_Card.Controls.Add(this.hallPass_substance_textBox);
			this.hallPass_Card.Controls.Add(this.label28);
			this.hallPass_Card.Controls.Add(this.label29);
			this.hallPass_Card.Controls.Add(this.label22);
			this.hallPass_Card.Controls.Add(this.label23);
			this.hallPass_Card.Controls.Add(this.hallPass_fluid_textBox);
			this.hallPass_Card.Controls.Add(this.label24);
			this.hallPass_Card.Controls.Add(this.label25);
			this.hallPass_Card.Controls.Add(this.label21);
			this.hallPass_Card.Controls.Add(this.label19);
			this.hallPass_Card.Controls.Add(this.hallPass_body_textBox);
			this.hallPass_Card.Controls.Add(this.label20);
			this.hallPass_Card.Controls.Add(this.label18);
			this.hallPass_Card.Controls.Add(this.label17);
			this.hallPass_Card.Controls.Add(this.label15);
			this.hallPass_Card.Controls.Add(this.hallPass_name_textBox);
			this.hallPass_Card.Controls.Add(this.label16);
			this.hallPass_Card.Controls.Add(this.hallPass_date_textBox);
			this.hallPass_Card.Controls.Add(this.label1);
			this.hallPass_Card.Controls.Add(this.label14);
			this.hallPass_Card.Controls.Add(this.pictureBox2);
			this.hallPass_Card.Location = new System.Drawing.Point(4, 25);
			this.hallPass_Card.Name = "hallPass_Card";
			this.hallPass_Card.Padding = new System.Windows.Forms.Padding(3);
			this.hallPass_Card.Size = new System.Drawing.Size(374, 349);
			this.hallPass_Card.TabIndex = 1;
			this.hallPass_Card.Text = "Hall Pass";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(266, 213);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(97, 23);
			this.label26.TabIndex = 41;
			this.label26.Text = "as needed.";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(148, 239);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(90, 19);
			this.label27.TabIndex = 40;
			this.label27.Text = "SUBSTANCE";
			// 
			// hallPass_substance_textBox
			// 
			this.hallPass_substance_textBox.BackColor = System.Drawing.Color.White;
			this.hallPass_substance_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hallPass_substance_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.hallPass_substance_textBox.Location = new System.Drawing.Point(146, 211);
			this.hallPass_substance_textBox.Name = "hallPass_substance_textBox";
			this.hallPass_substance_textBox.Size = new System.Drawing.Size(111, 23);
			this.hallPass_substance_textBox.TabIndex = 38;
			this.hallPass_substance_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(139, 226);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(127, 13);
			this.label28.TabIndex = 39;
			this.label28.Text = "____________________";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(98, 213);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(46, 23);
			this.label29.TabIndex = 37;
			this.label29.Text = "take";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(321, 163);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(41, 23);
			this.label22.TabIndex = 36;
			this.label22.Text = "and";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(204, 184);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(108, 19);
			this.label23.TabIndex = 35;
			this.label23.Text = "TYPE OF FLUID";
			// 
			// hallPass_fluid_textBox
			// 
			this.hallPass_fluid_textBox.BackColor = System.Drawing.Color.White;
			this.hallPass_fluid_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hallPass_fluid_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.hallPass_fluid_textBox.Location = new System.Drawing.Point(197, 156);
			this.hallPass_fluid_textBox.Name = "hallPass_fluid_textBox";
			this.hallPass_fluid_textBox.Size = new System.Drawing.Size(124, 23);
			this.hallPass_fluid_textBox.TabIndex = 33;
			this.hallPass_fluid_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(195, 171);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(127, 13);
			this.label24.TabIndex = 34;
			this.label24.Text = "____________________";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(92, 163);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(103, 23);
			this.label25.TabIndex = 32;
			this.label25.Text = "Drink more";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(320, 113);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(37, 23);
			this.label21.TabIndex = 31;
			this.label21.Text = "flu.";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(203, 134);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(104, 19);
			this.label19.TabIndex = 30;
			this.label19.Text = "PART OF BODY";
			// 
			// hallPass_body_textBox
			// 
			this.hallPass_body_textBox.BackColor = System.Drawing.Color.White;
			this.hallPass_body_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hallPass_body_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.hallPass_body_textBox.Location = new System.Drawing.Point(196, 106);
			this.hallPass_body_textBox.Name = "hallPass_body_textBox";
			this.hallPass_body_textBox.Size = new System.Drawing.Size(124, 23);
			this.hallPass_body_textBox.TabIndex = 28;
			this.hallPass_body_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(194, 121);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(127, 13);
			this.label20.TabIndex = 29;
			this.label20.Text = "____________________";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(118, 113);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(77, 23);
			this.label18.TabIndex = 27;
			this.label18.Text = "with the";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(280, 54);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 23);
			this.label17.TabIndex = 26;
			this.label17.Text = "is sick";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(189, 75);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 19);
			this.label15.TabIndex = 25;
			this.label15.Text = "NAME";
			// 
			// hallPass_name_textBox
			// 
			this.hallPass_name_textBox.BackColor = System.Drawing.Color.White;
			this.hallPass_name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hallPass_name_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.hallPass_name_textBox.Location = new System.Drawing.Point(150, 47);
			this.hallPass_name_textBox.Name = "hallPass_name_textBox";
			this.hallPass_name_textBox.Size = new System.Drawing.Size(124, 23);
			this.hallPass_name_textBox.TabIndex = 23;
			this.hallPass_name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(148, 62);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(127, 13);
			this.label16.TabIndex = 24;
			this.label16.Text = "____________________";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hallPass_date_textBox
			// 
			this.hallPass_date_textBox.BackColor = System.Drawing.Color.White;
			this.hallPass_date_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hallPass_date_textBox.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.hallPass_date_textBox.Location = new System.Drawing.Point(207, 14);
			this.hallPass_date_textBox.Name = "hallPass_date_textBox";
			this.hallPass_date_textBox.Size = new System.Drawing.Size(113, 23);
			this.hallPass_date_textBox.TabIndex = 21;
			this.hallPass_date_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(145, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 27);
			this.label1.TabIndex = 20;
			this.label1.Text = "Date:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(195, 28);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(133, 13);
			this.label14.TabIndex = 22;
			this.label14.Text = "_____________________";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::MadLib_Game_Gen.Properties.Resources.Capture_2;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(8, 8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(77, 335);
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			// 
			// cardChooser_label
			// 
			this.cardChooser_label.AutoSize = true;
			this.cardChooser_label.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cardChooser_label.Location = new System.Drawing.Point(4, 92);
			this.cardChooser_label.Name = "cardChooser_label";
			this.cardChooser_label.Size = new System.Drawing.Size(98, 18);
			this.cardChooser_label.TabIndex = 4;
			this.cardChooser_label.Text = "Choose a Card:";
			// 
			// cardChooser_comboBox
			// 
			this.cardChooser_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Excused Card",
            "Hall Pass Card"});
			this.cardChooser_comboBox.FormattingEnabled = true;
			this.cardChooser_comboBox.Items.AddRange(new object[] {
            "Excused Card",
            "Hall Pass Card"});
			this.cardChooser_comboBox.Location = new System.Drawing.Point(4, 108);
			this.cardChooser_comboBox.Name = "cardChooser_comboBox";
			this.cardChooser_comboBox.Size = new System.Drawing.Size(138, 21);
			this.cardChooser_comboBox.TabIndex = 5;
			this.cardChooser_comboBox.SelectedIndexChanged += new System.EventHandler(this.cardChooser_comboBox_SelectedIndexChanged);
			// 
			// generate_button
			// 
			this.generate_button.BackColor = System.Drawing.Color.Black;
			this.generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.generate_button.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generate_button.ForeColor = System.Drawing.Color.White;
			this.generate_button.Location = new System.Drawing.Point(226, 91);
			this.generate_button.Name = "generate_button";
			this.generate_button.Size = new System.Drawing.Size(152, 38);
			this.generate_button.TabIndex = 6;
			this.generate_button.Text = "Generate!";
			this.generate_button.UseVisualStyleBackColor = false;
			this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.label30);
			this.panel2.Location = new System.Drawing.Point(102, 262);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(257, 81);
			this.panel2.TabIndex = 42;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(20, 30);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(221, 39);
			this.textBox3.TabIndex = 10;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(0, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(80, 27);
			this.label30.TabIndex = 1;
			this.label30.Text = "Signed:";
			// 
			// inputForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(382, 513);
			this.Controls.Add(this.generate_button);
			this.Controls.Add(this.cardChooser_comboBox);
			this.Controls.Add(this.cardChooser_label);
			this.Controls.Add(this.cardOptions_tabControl);
			this.Controls.Add(this.titleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "inputForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Mad Libs Hall Pass";
			this.titleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.titleBar_Logo)).EndInit();
			this.cardOptions_tabControl.ResumeLayout(false);
			this.excusedCard.ResumeLayout(false);
			this.excusedCard.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.hallPass_Card.ResumeLayout(false);
			this.hallPass_Card.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox titleBar_Logo;
		private System.Windows.Forms.Panel titleBar;
		private System.Windows.Forms.TabControl cardOptions_tabControl;
		private System.Windows.Forms.TabPage excusedCard;
		private System.Windows.Forms.TabPage hallPass_Card;
		private System.Windows.Forms.TextBox excused_date_textBox;
		private System.Windows.Forms.Label date_label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label cardChooser_label;
		private System.Windows.Forms.ComboBox cardChooser_comboBox;
		private System.Windows.Forms.Button generate_button;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox excused_adjective_textBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox excused_name_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label excusedCard_A_label;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox excused_noun_textBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox excused_signed_textBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox hallPass_date_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox hallPass_name_textBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox hallPass_body_textBox;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox hallPass_substance_textBox;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox hallPass_fluid_textBox;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label30;
	}
}

