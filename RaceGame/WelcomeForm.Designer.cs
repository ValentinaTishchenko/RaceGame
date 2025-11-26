namespace Race
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelPlayerName = new Label();
            textBoxPlayerName = new TextBox();
            buttonStart = new Button();
            buttonResults = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Tai Le", 72F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(120, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(387, 152);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "RACE";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerName.ForeColor = Color.White;
            labelPlayerName.Location = new Point(150, 200);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(230, 31);
            labelPlayerName.TabIndex = 1;
            labelPlayerName.Text = "Введите ваше имя:";
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlayerName.Location = new Point(150, 240);
            textBoxPlayerName.MaxLength = GameConstants.MaxPlayerNameLength;
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(200, 34);
            textBoxPlayerName.TabIndex = 2;
            textBoxPlayerName.Text = "Анонимный гонщик";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.LimeGreen;
            buttonStart.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(150, 300);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(200, 60);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "СТАРТ";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += ButtonStart_Click;
            // 
            // buttonResults
            // 
            buttonResults.BackColor = Color.DodgerBlue;
            buttonResults.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResults.ForeColor = Color.White;
            buttonResults.Location = new Point(150, 380);
            buttonResults.Name = "buttonResults";
            buttonResults.Size = new Size(200, 50);
            buttonResults.TabIndex = 4;
            buttonResults.Text = "РЕЗУЛЬТАТЫ";
            buttonResults.UseVisualStyleBackColor = false;
            buttonResults.Click += ButtonResults_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(150, 450);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(200, 50);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "ВЫХОД";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(500, 600);
            Controls.Add(buttonExit);
            Controls.Add(buttonResults);
            Controls.Add(buttonStart);
            Controls.Add(textBoxPlayerName);
            Controls.Add(labelPlayerName);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race Game - Главное меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelPlayerName;
        private TextBox textBoxPlayerName;
        private Button buttonStart;
        private Button buttonResults;
        private Button buttonExit;
    }
}