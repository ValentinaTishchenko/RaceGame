using Timer = System.Windows.Forms.Timer;

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
            timerRoad = new Timer(components);
            panelGame = new Panel();
            panelPause = new Panel();
            buttonToMenu = new Button();
            buttonContinue = new Button();
            pictureFlag = new PictureBox();
            labelScore = new Label();
            labelCoins = new Label();
            labelBlackBar = new Label();
            towardCar2 = new PictureBox();
            towardCar1 = new PictureBox();
            towardCar3 = new PictureBox();           
            coinTemplate = new PictureBox();
            buttonPause = new Button();
            mainCar = new PictureBox();
            LaneTwo5 = new Label();
            LaneTwo4 = new Label();
            LaneTwo3 = new Label();
            LaneTwo2 = new Label();
            LaneTwo1 = new Label();
            LaneOne5 = new Label();
            LaneOne4 = new Label();
            LaneOne3 = new Label();
            LaneOne2 = new Label();
            LaneOne1 = new Label();
            MiddleLane = new Label();
            timerTowardCars = new Timer(components);
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)coinTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            SuspendLayout();
            // 
            // timerRoad
            // 
            timerRoad.Enabled = true;
            timerRoad.Interval = 20;
            timerRoad.Tick += TimerRoad_Tick;
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ControlDarkDark;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(labelScore);
            panelGame.Controls.Add(labelCoins);
            panelGame.Controls.Add(labelBlackBar);
            panelGame.Controls.Add(towardCar2);
            panelGame.Controls.Add(towardCar1);
            panelGame.Controls.Add(towardCar3);           
            panelGame.Controls.Add(coinTemplate);
            panelGame.Controls.Add(buttonPause);
            panelGame.Controls.Add(mainCar);
            panelGame.Controls.Add(LaneTwo5);
            panelGame.Controls.Add(LaneTwo4);
            panelGame.Controls.Add(LaneTwo3);
            panelGame.Controls.Add(LaneTwo2);
            panelGame.Controls.Add(LaneTwo1);
            panelGame.Controls.Add(LaneOne5);
            panelGame.Controls.Add(LaneOne4);
            panelGame.Controls.Add(LaneOne3);
            panelGame.Controls.Add(LaneOne2);
            panelGame.Controls.Add(LaneOne1);
            panelGame.Controls.Add(MiddleLane);
            panelGame.Location = new Point(0, 0);
            panelGame.Margin = new Padding(4, 5, 4, 5);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(512, 866);
            panelGame.TabIndex = 0;
            // 
            // panelPause
            // 
            panelPause.BackColor = SystemColors.ControlDarkDark;
            panelPause.Controls.Add(buttonToMenu);
            panelPause.Controls.Add(buttonContinue);
            panelPause.Controls.Add(pictureFlag);
            panelPause.Location = new Point(0, 0);
            panelPause.Margin = new Padding(4, 5, 4, 5);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(515, 872);
            panelPause.TabIndex = 57;
            panelPause.Visible = false;
            // 
            // buttonToMenu
            // 
            buttonToMenu.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonToMenu.Location = new Point(159, 740);
            buttonToMenu.Margin = new Padding(4, 5, 4, 5);
            buttonToMenu.Name = "buttonToMenu";
            buttonToMenu.Size = new Size(203, 62);
            buttonToMenu.TabIndex = 53;
            buttonToMenu.Text = "В меню";
            buttonToMenu.UseVisualStyleBackColor = true;
            buttonToMenu.Click += ButtonToMenu_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContinue.Location = new Point(159, 625);
            buttonContinue.Margin = new Padding(4, 5, 4, 5);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(203, 89);
            buttonContinue.TabIndex = 52;
            buttonContinue.Text = "Рестарт";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += ButtonContinue_Click;
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
            // labelBlackBar
            // 
            labelBlackBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelBlackBar.BackColor = SystemColors.ActiveCaptionText;
            labelBlackBar.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            labelBlackBar.ForeColor = SystemColors.ControlText;
            labelBlackBar.Location = new Point(-3, 0);
            labelBlackBar.Margin = new Padding(4, 0, 4, 0);
            labelBlackBar.Name = "labelBlackBar";
            labelBlackBar.Size = new Size(515, 91);
            labelBlackBar.TabIndex = 55;
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
            // coinTemplate
            // 
            coinTemplate.BackColor = Color.Transparent;
            coinTemplate.Image = (Image)resources.GetObject("Coin1.Image");
            coinTemplate.Location = new Point(147, 388);
            coinTemplate.Margin = new Padding(4, 5, 4, 5);
            coinTemplate.Name = "Coin1";
            coinTemplate.Size = new Size(45, 49);
            coinTemplate.SizeMode = PictureBoxSizeMode.Zoom;
            coinTemplate.TabIndex = 52;
            coinTemplate.TabStop = false;
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
            // LaneTwo5
            // 
            LaneTwo5.BackColor = Color.White;
            LaneTwo5.ForeColor = SystemColors.Control;
            LaneTwo5.Location = new Point(385, 812);
            LaneTwo5.Margin = new Padding(4, 0, 4, 0);
            LaneTwo5.Name = "LaneTwo5";
            LaneTwo5.Size = new Size(20, 138);
            LaneTwo5.TabIndex = 43;
            LaneTwo5.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo4
            // 
            LaneTwo4.BackColor = Color.White;
            LaneTwo4.ForeColor = SystemColors.Control;
            LaneTwo4.Location = new Point(385, 596);
            LaneTwo4.Margin = new Padding(4, 0, 4, 0);
            LaneTwo4.Name = "LaneTwo4";
            LaneTwo4.Size = new Size(20, 138);
            LaneTwo4.TabIndex = 42;
            LaneTwo4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo3
            // 
            LaneTwo3.BackColor = Color.White;
            LaneTwo3.ForeColor = SystemColors.Control;
            LaneTwo3.Location = new Point(385, 382);
            LaneTwo3.Margin = new Padding(4, 0, 4, 0);
            LaneTwo3.Name = "LaneTwo3";
            LaneTwo3.Size = new Size(20, 138);
            LaneTwo3.TabIndex = 41;
            LaneTwo3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo2
            // 
            LaneTwo2.BackColor = Color.White;
            LaneTwo2.ForeColor = SystemColors.Control;
            LaneTwo2.Location = new Point(385, 166);
            LaneTwo2.Margin = new Padding(4, 0, 4, 0);
            LaneTwo2.Name = "LaneTwo2";
            LaneTwo2.Size = new Size(20, 138);
            LaneTwo2.TabIndex = 40;
            LaneTwo2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo1
            // 
            LaneTwo1.BackColor = Color.White;
            LaneTwo1.ForeColor = SystemColors.Control;
            LaneTwo1.Location = new Point(385, -49);
            LaneTwo1.Margin = new Padding(4, 0, 4, 0);
            LaneTwo1.Name = "LaneTwo1";
            LaneTwo1.Size = new Size(20, 138);
            LaneTwo1.TabIndex = 39;
            LaneTwo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne5
            // 
            LaneOne5.BackColor = Color.White;
            LaneOne5.ForeColor = SystemColors.Control;
            LaneOne5.Location = new Point(119, 812);
            LaneOne5.Margin = new Padding(4, 0, 4, 0);
            LaneOne5.Name = "LaneOne5";
            LaneOne5.Size = new Size(20, 138);
            LaneOne5.TabIndex = 38;
            LaneOne5.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne4
            // 
            LaneOne4.BackColor = Color.White;
            LaneOne4.ForeColor = SystemColors.Control;
            LaneOne4.Location = new Point(119, 597);
            LaneOne4.Margin = new Padding(4, 0, 4, 0);
            LaneOne4.Name = "LaneOne4";
            LaneOne4.Size = new Size(20, 138);
            LaneOne4.TabIndex = 37;
            LaneOne4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne3
            // 
            LaneOne3.BackColor = Color.White;
            LaneOne3.ForeColor = SystemColors.Control;
            LaneOne3.Location = new Point(119, 382);
            LaneOne3.Margin = new Padding(4, 0, 4, 0);
            LaneOne3.Name = "LaneOne3";
            LaneOne3.Size = new Size(20, 138);
            LaneOne3.TabIndex = 36;
            LaneOne3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne2
            // 
            LaneOne2.BackColor = Color.White;
            LaneOne2.ForeColor = SystemColors.Control;
            LaneOne2.Location = new Point(119, 166);
            LaneOne2.Margin = new Padding(4, 0, 4, 0);
            LaneOne2.Name = "LaneOne2";
            LaneOne2.Size = new Size(20, 138);
            LaneOne2.TabIndex = 35;
            LaneOne2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne1
            // 
            LaneOne1.BackColor = Color.White;
            LaneOne1.ForeColor = SystemColors.Control;
            LaneOne1.Location = new Point(119, -49);
            LaneOne1.Margin = new Padding(4, 0, 4, 0);
            LaneOne1.Name = "LaneOne1";
            LaneOne1.Size = new Size(20, 138);
            LaneOne1.TabIndex = 34;
            LaneOne1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MiddleLane
            // 
            MiddleLane.BackColor = Color.White;
            MiddleLane.ForeColor = SystemColors.Control;
            MiddleLane.Location = new Point(245, -6);
            MiddleLane.Margin = new Padding(4, 0, 4, 0);
            MiddleLane.Name = "MiddleLane";
            MiddleLane.Size = new Size(23, 872);
            MiddleLane.TabIndex = 33;
            MiddleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerTowardCars
            // 
            timerTowardCars.Enabled = true;
            timerTowardCars.Interval = 20;
            timerTowardCars.Tick += TimerTowardCars_Tick;
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(512, 865);
            Controls.Add(panelGame);
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
            panelPause.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();           
            ((System.ComponentModel.ISupportInitialize)coinTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Timer timerRoad;
        private Panel panelGame;
        private Label LaneTwo5;
        private Label LaneTwo4;
        private Label LaneTwo3;
        private Label LaneTwo2;
        private Label LaneTwo1;
        private Label LaneOne5;
        private Label LaneOne4;
        private Label LaneOne3;
        private Label LaneOne2;
        private Label LaneOne1;
        private Label MiddleLane;
        private PictureBox towardCar2;
        private PictureBox towardCar3;
        private PictureBox towardCar1;
        private PictureBox mainCar;
        private Timer timerTowardCars;
        private Button buttonToMenu;
        private Button buttonContinue;
        private Button buttonPause;
        private PictureBox coinTemplate;       
        private Panel panelPause;
        private PictureBox pictureFlag;
        private Label labelCoins;
        private Label labelScore;
        private Label labelBlackBar;
    }
}