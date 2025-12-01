namespace Race
{
	partial class RaceGame
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            timerRoad = new System.Windows.Forms.Timer(components);
            panelGame = new Panel();
            labelScore = new Label();
            labelCoins = new Label();
            labelTopPanel = new Label();
            towardCar2 = new PictureBox();
            towardCar1 = new PictureBox();
            towardCar3 = new PictureBox();
            coin3 = new PictureBox();
            coin2 = new PictureBox();
            coin1 = new PictureBox();
            buttonPause = new Button();
            mainCar = new PictureBox();
            laneTwo5 = new Label();
            laneTwo4 = new Label();
            laneTwo3 = new Label();
            laneTwo2 = new Label();
            laneTwo1 = new Label();
            laneOne5 = new Label();
            laneOne4 = new Label();
            laneOne3 = new Label();
            laneOne2 = new Label();
            laneOne1 = new Label();
            middleLane = new Label();
            panelMenu = new Panel();
            buttonHelp = new Button();
            buttonMenuExit = new Button();
            buttonStart = new Button();
            labelGameTitle = new Label();
            carMenu1 = new PictureBox();
            carMenu3 = new PictureBox();
            carMenu2 = new PictureBox();
            menuTwoLane5 = new Label();
            menuTwoLane4 = new Label();
            menuTwoLane3 = new Label();
            menuTwoLane2 = new Label();
            menuTwoLane1 = new Label();
            menuOneLane5 = new Label();
            menuOneLane4 = new Label();
            menuOneLane3 = new Label();
            menuOneLane2 = new Label();
            menuOneLane1 = new Label();
            labelCenterDivider = new Label();
            panelPause = new Panel();
            buttonExit = new Button();
            buttonResume = new Button();
            pictureFlag = new PictureBox();
            labelPause = new Label();
            timerTowardCars = new System.Windows.Forms.Timer(components);
            timerMenu = new System.Windows.Forms.Timer(components);
            buttonResults = new Button();
            panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMenu3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMenu2).BeginInit();
            panelPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            SuspendLayout();
            // 
            // timerRoad
            // 
            timerRoad.Enabled = true;
            timerRoad.Interval = 1;
            timerRoad.Tick += TimerRoad_Tick;
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ControlDarkDark;
            panelGame.Controls.Add(labelScore);
            panelGame.Controls.Add(labelCoins);
            panelGame.Controls.Add(labelTopPanel);
            panelGame.Controls.Add(towardCar2);
            panelGame.Controls.Add(towardCar1);
            panelGame.Controls.Add(towardCar3);
            panelGame.Controls.Add(coin3);
            panelGame.Controls.Add(coin2);
            panelGame.Controls.Add(coin1);
            panelGame.Controls.Add(buttonPause);
            panelGame.Controls.Add(mainCar);
            panelGame.Controls.Add(laneTwo5);
            panelGame.Controls.Add(laneTwo4);
            panelGame.Controls.Add(laneTwo3);
            panelGame.Controls.Add(laneTwo2);
            panelGame.Controls.Add(laneTwo1);
            panelGame.Controls.Add(laneOne5);
            panelGame.Controls.Add(laneOne4);
            panelGame.Controls.Add(laneOne3);
            panelGame.Controls.Add(laneOne2);
            panelGame.Controls.Add(laneOne1);
            panelGame.Controls.Add(middleLane);
            panelGame.Location = new Point(0, 0);
            panelGame.Margin = new Padding(4, 5, 4, 5);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(512, 866);
            panelGame.TabIndex = 0;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Black;
            labelScore.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.ForeColor = SystemColors.ButtonHighlight;
            labelScore.Location = new Point(16, 14);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(136, 50);
            labelScore.TabIndex = 56;
            labelScore.Text = "Score:";
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.Black;
            labelCoins.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ButtonHighlight;
            labelCoins.Location = new Point(276, 14);
            labelCoins.Margin = new Padding(4, 0, 4, 0);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(135, 50);
            labelCoins.TabIndex = 57;
            labelCoins.Text = "Coins:";
            // 
            // labelTopPanel
            // 
            labelTopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelTopPanel.BackColor = SystemColors.ActiveCaptionText;
            labelTopPanel.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            labelTopPanel.ForeColor = SystemColors.ControlText;
            labelTopPanel.Location = new Point(-3, 0);
            labelTopPanel.Margin = new Padding(4, 0, 4, 0);
            labelTopPanel.Name = "labelTopPanel";
            labelTopPanel.Size = new Size(515, 91);
            labelTopPanel.TabIndex = 55;
            // 
            // towardCar2
            // 
            towardCar2.BackColor = Color.Transparent;
            towardCar2.Image = (Image)resources.GetObject("towardCar2.Image");
            towardCar2.Location = new Point(16, 35);
            towardCar2.Margin = new Padding(4, 5, 4, 5);
            towardCar2.Name = "towardCar2";
            towardCar2.Size = new Size(67, 169);
            towardCar2.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar2.TabIndex = 49;
            towardCar2.TabStop = false;
            // 
            // towardCar1
            // 
            towardCar1.BackColor = Color.Transparent;
            towardCar1.Image = (Image)resources.GetObject("towardCar1.Image");
            towardCar1.Location = new Point(172, 20);
            towardCar1.Margin = new Padding(4, 5, 4, 5);
            towardCar1.Name = "towardCar1";
            towardCar1.Size = new Size(67, 169);
            towardCar1.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar1.TabIndex = 48;
            towardCar1.TabStop = false;
            // 
            // towardCar3
            // 
            towardCar3.BackColor = Color.Transparent;
            towardCar3.Image = (Image)resources.GetObject("towardCar3.Image");
            towardCar3.Location = new Point(429, 55);
            towardCar3.Margin = new Padding(4, 5, 4, 5);
            towardCar3.Name = "towardCar3";
            towardCar3.Size = new Size(67, 169);
            towardCar3.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar3.TabIndex = 50;
            towardCar3.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = Color.Transparent;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(429, 343);
            coin3.Margin = new Padding(4, 5, 4, 5);
            coin3.Name = "coin3";
            coin3.Size = new Size(45, 49);
            coin3.SizeMode = PictureBoxSizeMode.Zoom;
            coin3.TabIndex = 54;
            coin3.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Transparent;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(295, 240);
            coin2.Margin = new Padding(4, 5, 4, 5);
            coin2.Name = "coin2";
            coin2.Size = new Size(45, 49);
            coin2.SizeMode = PictureBoxSizeMode.Zoom;
            coin2.TabIndex = 53;
            coin2.TabStop = false;
            // 
            // coin1
            // 
            coin1.BackColor = Color.Transparent;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(147, 388);
            coin1.Margin = new Padding(4, 5, 4, 5);
            coin1.Name = "coin1";
            coin1.Size = new Size(45, 49);
            coin1.SizeMode = PictureBoxSizeMode.Zoom;
            coin1.TabIndex = 52;
            coin1.TabStop = false;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPause.Location = new Point(0, 803);
            buttonPause.Margin = new Padding(4, 5, 4, 5);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(109, 58);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += ButtonPause_Click;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(295, 677);
            mainCar.Margin = new Padding(4, 5, 4, 5);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(67, 169);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 47;
            mainCar.TabStop = false;
            // 
            // laneTwo5
            // 
            laneTwo5.BackColor = Color.White;
            laneTwo5.ForeColor = SystemColors.Control;
            laneTwo5.Location = new Point(385, 812);
            laneTwo5.Margin = new Padding(4, 0, 4, 0);
            laneTwo5.Name = "laneTwo5";
            laneTwo5.Size = new Size(20, 138);
            laneTwo5.TabIndex = 43;
            laneTwo5.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo4
            // 
            laneTwo4.BackColor = Color.White;
            laneTwo4.ForeColor = SystemColors.Control;
            laneTwo4.Location = new Point(385, 596);
            laneTwo4.Margin = new Padding(4, 0, 4, 0);
            laneTwo4.Name = "laneTwo4";
            laneTwo4.Size = new Size(20, 138);
            laneTwo4.TabIndex = 42;
            laneTwo4.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo3
            // 
            laneTwo3.BackColor = Color.White;
            laneTwo3.ForeColor = SystemColors.Control;
            laneTwo3.Location = new Point(385, 382);
            laneTwo3.Margin = new Padding(4, 0, 4, 0);
            laneTwo3.Name = "laneTwo3";
            laneTwo3.Size = new Size(20, 138);
            laneTwo3.TabIndex = 41;
            laneTwo3.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo2
            // 
            laneTwo2.BackColor = Color.White;
            laneTwo2.ForeColor = SystemColors.Control;
            laneTwo2.Location = new Point(385, 166);
            laneTwo2.Margin = new Padding(4, 0, 4, 0);
            laneTwo2.Name = "laneTwo2";
            laneTwo2.Size = new Size(20, 138);
            laneTwo2.TabIndex = 40;
            laneTwo2.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo1
            // 
            laneTwo1.BackColor = Color.White;
            laneTwo1.ForeColor = SystemColors.Control;
            laneTwo1.Location = new Point(385, -49);
            laneTwo1.Margin = new Padding(4, 0, 4, 0);
            laneTwo1.Name = "laneTwo1";
            laneTwo1.Size = new Size(20, 138);
            laneTwo1.TabIndex = 39;
            laneTwo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne5
            // 
            laneOne5.BackColor = Color.White;
            laneOne5.ForeColor = SystemColors.Control;
            laneOne5.Location = new Point(119, 812);
            laneOne5.Margin = new Padding(4, 0, 4, 0);
            laneOne5.Name = "laneOne5";
            laneOne5.Size = new Size(20, 138);
            laneOne5.TabIndex = 38;
            laneOne5.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne4
            // 
            laneOne4.BackColor = Color.White;
            laneOne4.ForeColor = SystemColors.Control;
            laneOne4.Location = new Point(119, 597);
            laneOne4.Margin = new Padding(4, 0, 4, 0);
            laneOne4.Name = "laneOne4";
            laneOne4.Size = new Size(20, 138);
            laneOne4.TabIndex = 37;
            laneOne4.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne3
            // 
            laneOne3.BackColor = Color.White;
            laneOne3.ForeColor = SystemColors.Control;
            laneOne3.Location = new Point(119, 382);
            laneOne3.Margin = new Padding(4, 0, 4, 0);
            laneOne3.Name = "laneOne3";
            laneOne3.Size = new Size(20, 138);
            laneOne3.TabIndex = 36;
            laneOne3.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne2
            // 
            laneOne2.BackColor = Color.White;
            laneOne2.ForeColor = SystemColors.Control;
            laneOne2.Location = new Point(119, 166);
            laneOne2.Margin = new Padding(4, 0, 4, 0);
            laneOne2.Name = "laneOne2";
            laneOne2.Size = new Size(20, 138);
            laneOne2.TabIndex = 35;
            laneOne2.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne1
            // 
            laneOne1.BackColor = Color.White;
            laneOne1.ForeColor = SystemColors.Control;
            laneOne1.Location = new Point(119, -49);
            laneOne1.Margin = new Padding(4, 0, 4, 0);
            laneOne1.Name = "laneOne1";
            laneOne1.Size = new Size(20, 138);
            laneOne1.TabIndex = 34;
            laneOne1.TextAlign = ContentAlignment.TopCenter;
            // 
            // middleLane
            // 
            middleLane.BackColor = Color.White;
            middleLane.ForeColor = SystemColors.Control;
            middleLane.Location = new Point(245, -6);
            middleLane.Margin = new Padding(4, 0, 4, 0);
            middleLane.Name = "middleLane";
            middleLane.Size = new Size(23, 872);
            middleLane.TabIndex = 33;
            middleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(buttonResults);
            panelMenu.Controls.Add(buttonMenuExit);
            panelMenu.Controls.Add(buttonStart);
            panelMenu.Controls.Add(labelGameTitle);
            panelMenu.Controls.Add(carMenu1);
            panelMenu.Controls.Add(carMenu3);
            panelMenu.Controls.Add(carMenu2);
            panelMenu.Controls.Add(menuTwoLane5);
            panelMenu.Controls.Add(menuTwoLane4);
            panelMenu.Controls.Add(menuTwoLane3);
            panelMenu.Controls.Add(menuTwoLane2);
            panelMenu.Controls.Add(menuTwoLane1);
            panelMenu.Controls.Add(menuOneLane5);
            panelMenu.Controls.Add(menuOneLane4);
            panelMenu.Controls.Add(menuOneLane3);
            panelMenu.Controls.Add(menuOneLane2);
            panelMenu.Controls.Add(menuOneLane1);
            panelMenu.Controls.Add(labelCenterDivider);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 5, 4, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(515, 867);
            panelMenu.TabIndex = 57;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.Location = new Point(413, 812);
            buttonHelp.Margin = new Padding(4, 5, 4, 5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 49);
            buttonHelp.TabIndex = 82;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelp_Click;
            // 
            // buttonMenuExit
            // 
            buttonMenuExit.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuExit.Location = new Point(167, 506);
            buttonMenuExit.Margin = new Padding(4, 5, 4, 5);
            buttonMenuExit.Name = "buttonMenuExit";
            buttonMenuExit.Size = new Size(176, 72);
            buttonMenuExit.TabIndex = 67;
            buttonMenuExit.Text = "Exit";
            buttonMenuExit.UseVisualStyleBackColor = true;
            buttonMenuExit.Click += ButtonMenuExit_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(148, 405);
            buttonStart.Margin = new Padding(4, 5, 4, 5);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(213, 91);
            buttonStart.TabIndex = 65;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // labelGameTitle
            // 
            labelGameTitle.AutoSize = true;
            labelGameTitle.BackColor = Color.FromArgb(64, 64, 64);
            labelGameTitle.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelGameTitle.ForeColor = SystemColors.Control;
            labelGameTitle.Location = new Point(0, 0);
            labelGameTitle.Margin = new Padding(4, 0, 4, 0);
            labelGameTitle.Name = "labelGameTitle";
            labelGameTitle.Size = new Size(481, 223);
            labelGameTitle.TabIndex = 66;
            labelGameTitle.Text = "Race";
            // 
            // carMenu1
            // 
            carMenu1.BackColor = Color.Transparent;
            carMenu1.Image = (Image)resources.GetObject("carMenu1.Image");
            carMenu1.Location = new Point(16, 20);
            carMenu1.Margin = new Padding(4, 5, 4, 5);
            carMenu1.Name = "carMenu1";
            carMenu1.Size = new Size(67, 169);
            carMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu1.TabIndex = 80;
            carMenu1.TabStop = false;
            // 
            // carMenu3
            // 
            carMenu3.BackColor = Color.Transparent;
            carMenu3.Image = (Image)resources.GetObject("carMenu3.Image");
            carMenu3.Location = new Point(429, 40);
            carMenu3.Margin = new Padding(4, 5, 4, 5);
            carMenu3.Name = "carMenu3";
            carMenu3.Size = new Size(67, 169);
            carMenu3.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu3.TabIndex = 81;
            carMenu3.TabStop = false;
            // 
            // carMenu2
            // 
            carMenu2.BackColor = Color.Transparent;
            carMenu2.Image = (Image)resources.GetObject("carMenu2.Image");
            carMenu2.Location = new Point(172, 5);
            carMenu2.Margin = new Padding(4, 5, 4, 5);
            carMenu2.Name = "carMenu2";
            carMenu2.Size = new Size(67, 169);
            carMenu2.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu2.TabIndex = 79;
            carMenu2.TabStop = false;
            // 
            // menuTwoLane5
            // 
            menuTwoLane5.BackColor = Color.White;
            menuTwoLane5.ForeColor = SystemColors.Control;
            menuTwoLane5.Location = new Point(385, 797);
            menuTwoLane5.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane5.Name = "menuTwoLane5";
            menuTwoLane5.Size = new Size(20, 138);
            menuTwoLane5.TabIndex = 78;
            menuTwoLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane4
            // 
            menuTwoLane4.BackColor = Color.White;
            menuTwoLane4.ForeColor = SystemColors.Control;
            menuTwoLane4.Location = new Point(385, 582);
            menuTwoLane4.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane4.Name = "menuTwoLane4";
            menuTwoLane4.Size = new Size(20, 138);
            menuTwoLane4.TabIndex = 77;
            menuTwoLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane3
            // 
            menuTwoLane3.BackColor = Color.White;
            menuTwoLane3.ForeColor = SystemColors.Control;
            menuTwoLane3.Location = new Point(385, 366);
            menuTwoLane3.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane3.Name = "menuTwoLane3";
            menuTwoLane3.Size = new Size(20, 138);
            menuTwoLane3.TabIndex = 76;
            menuTwoLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane2
            // 
            menuTwoLane2.BackColor = Color.White;
            menuTwoLane2.ForeColor = SystemColors.Control;
            menuTwoLane2.Location = new Point(385, 151);
            menuTwoLane2.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane2.Name = "menuTwoLane2";
            menuTwoLane2.Size = new Size(20, 138);
            menuTwoLane2.TabIndex = 75;
            menuTwoLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane1
            // 
            menuTwoLane1.BackColor = Color.White;
            menuTwoLane1.ForeColor = SystemColors.Control;
            menuTwoLane1.Location = new Point(385, -65);
            menuTwoLane1.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane1.Name = "menuTwoLane1";
            menuTwoLane1.Size = new Size(20, 138);
            menuTwoLane1.TabIndex = 74;
            menuTwoLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane5
            // 
            menuOneLane5.BackColor = Color.White;
            menuOneLane5.ForeColor = SystemColors.Control;
            menuOneLane5.Location = new Point(119, 797);
            menuOneLane5.Margin = new Padding(4, 0, 4, 0);
            menuOneLane5.Name = "menuOneLane5";
            menuOneLane5.Size = new Size(20, 138);
            menuOneLane5.TabIndex = 73;
            menuOneLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane4
            // 
            menuOneLane4.BackColor = Color.White;
            menuOneLane4.ForeColor = SystemColors.Control;
            menuOneLane4.Location = new Point(119, 582);
            menuOneLane4.Margin = new Padding(4, 0, 4, 0);
            menuOneLane4.Name = "menuOneLane4";
            menuOneLane4.Size = new Size(20, 138);
            menuOneLane4.TabIndex = 72;
            menuOneLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane3
            // 
            menuOneLane3.BackColor = Color.White;
            menuOneLane3.ForeColor = SystemColors.Control;
            menuOneLane3.Location = new Point(119, 366);
            menuOneLane3.Margin = new Padding(4, 0, 4, 0);
            menuOneLane3.Name = "menuOneLane3";
            menuOneLane3.Size = new Size(20, 138);
            menuOneLane3.TabIndex = 71;
            menuOneLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane2
            // 
            menuOneLane2.BackColor = Color.White;
            menuOneLane2.ForeColor = SystemColors.Control;
            menuOneLane2.Location = new Point(119, 151);
            menuOneLane2.Margin = new Padding(4, 0, 4, 0);
            menuOneLane2.Name = "menuOneLane2";
            menuOneLane2.Size = new Size(20, 138);
            menuOneLane2.TabIndex = 70;
            menuOneLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane1
            // 
            menuOneLane1.BackColor = Color.White;
            menuOneLane1.ForeColor = SystemColors.Control;
            menuOneLane1.Location = new Point(119, -65);
            menuOneLane1.Margin = new Padding(4, 0, 4, 0);
            menuOneLane1.Name = "menuOneLane1";
            menuOneLane1.Size = new Size(20, 138);
            menuOneLane1.TabIndex = 69;
            menuOneLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCenterDivider
            // 
            labelCenterDivider.BackColor = Color.White;
            labelCenterDivider.ForeColor = SystemColors.Control;
            labelCenterDivider.Location = new Point(245, -6);
            labelCenterDivider.Margin = new Padding(4, 0, 4, 0);
            labelCenterDivider.Name = "labelCenterDivider";
            labelCenterDivider.Size = new Size(23, 872);
            labelCenterDivider.TabIndex = 68;
            labelCenterDivider.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPause
            // 
            panelPause.BackColor = SystemColors.ControlDarkDark;
            panelPause.Controls.Add(buttonExit);
            panelPause.Controls.Add(buttonResume);
            panelPause.Controls.Add(pictureFlag);
            panelPause.Controls.Add(labelPause);
            panelPause.Location = new Point(0, 0);
            panelPause.Margin = new Padding(4, 5, 4, 5);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(515, 872);
            panelPause.TabIndex = 57;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(159, 740);
            buttonExit.Margin = new Padding(4, 5, 4, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(203, 62);
            buttonExit.TabIndex = 53;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // buttonResume
            // 
            buttonResume.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResume.Location = new Point(159, 625);
            buttonResume.Margin = new Padding(4, 5, 4, 5);
            buttonResume.Name = "buttonResume";
            buttonResume.Size = new Size(203, 89);
            buttonResume.TabIndex = 52;
            buttonResume.Text = "Resume";
            buttonResume.UseVisualStyleBackColor = true;
            buttonResume.Click += ButtonResume_Click;
            // 
            // pictureFlag
            // 
            pictureFlag.BackColor = SystemColors.ControlDarkDark;
            pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
            pictureFlag.Location = new Point(-3, 166);
            pictureFlag.Margin = new Padding(4, 5, 4, 5);
            pictureFlag.Name = "pictureFlag";
            pictureFlag.Size = new Size(515, 485);
            pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFlag.TabIndex = 55;
            pictureFlag.TabStop = false;
            // 
            // labelPause
            // 
            labelPause.AutoSize = true;
            labelPause.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
            labelPause.Location = new Point(0, 0);
            labelPause.Margin = new Padding(4, 0, 4, 0);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(528, 199);
            labelPause.TabIndex = 54;
            labelPause.Text = "Pause";
            // 
            // timerTowardCars
            // 
            timerTowardCars.Enabled = true;
            timerTowardCars.Interval = 1;
            timerTowardCars.Tick += TimerTowardCars_Tick;
            // 
            // timerMenu
            // 
            timerMenu.Enabled = true;
            timerMenu.Interval = 1;
            timerMenu.Tick += TimerMenu_Tick;
            // 
            // buttonResults
            // 
            buttonResults.Location = new Point(0, 830);
            buttonResults.Name = "buttonResults";
            buttonResults.Size = new Size(94, 29);
            buttonResults.TabIndex = 58;
            buttonResults.Text = "Результаты";
            buttonResults.UseVisualStyleBackColor = true;
            buttonResults.Click += ButtonResults_Click;
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(512, 865);
            Controls.Add(panelGame);
            Controls.Add(panelMenu);
            Controls.Add(panelPause);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RaceGame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race";
            Load += RaceGame_Load;
            KeyDown += RaceGame_KeyDown;
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMenu3).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMenu2).EndInit();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerRoad;
		private System.Windows.Forms.Panel panelGame;
		private System.Windows.Forms.Label laneTwo5;
		private System.Windows.Forms.Label laneTwo4;
		private System.Windows.Forms.Label laneTwo3;
		private System.Windows.Forms.Label laneTwo2;
		private System.Windows.Forms.Label laneTwo1;
		private System.Windows.Forms.Label laneOne5;
		private System.Windows.Forms.Label laneOne4;
		private System.Windows.Forms.Label laneOne3;
		private System.Windows.Forms.Label laneOne2;
		private System.Windows.Forms.Label laneOne1;
		private System.Windows.Forms.Label middleLane;
		private System.Windows.Forms.PictureBox towardCar2;
		private System.Windows.Forms.PictureBox towardCar3;
		private System.Windows.Forms.PictureBox towardCar1;
		private System.Windows.Forms.PictureBox mainCar;
		private System.Windows.Forms.Timer timerTowardCars;
		private System.Windows.Forms.Timer timerMenu;
		private System.Windows.Forms.Label labelPause;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonResume;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.PictureBox coin1;
		private System.Windows.Forms.PictureBox coin3;
		private System.Windows.Forms.PictureBox coin2;
		private System.Windows.Forms.Panel panelPause;
		private System.Windows.Forms.PictureBox pictureFlag;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Label labelTopPanel;
		private Panel panelMenu;
		private Button buttonHelp;
		private Button buttonMenuExit;
		private Button buttonStart;
		private Label labelGameTitle;
		private PictureBox carMenu1;
		private PictureBox carMenu3;
		private PictureBox carMenu2;
		private Label menuTwoLane5;
		private Label menuTwoLane4;
		private Label menuTwoLane3;
		private Label menuTwoLane2;
		private Label menuTwoLane1;
		private Label menuOneLane5;
		private Label menuOneLane4;
		private Label menuOneLane3;
		private Label menuOneLane2;
		private Label menuOneLane1;
		private Label labelCenterDivider;
        private Button buttonResults;
    }
}