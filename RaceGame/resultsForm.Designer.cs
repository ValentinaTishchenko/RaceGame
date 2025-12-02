namespace Race
{
    partial class resultsForm
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
            dataGridView1 = new DataGridView();
            сolumnData = new DataGridViewTextBoxColumn();
            ColumnPlayer = new DataGridViewTextBoxColumn();
            ColumnScore = new DataGridViewTextBoxColumn();
            ColumnCoins = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { сolumnData, ColumnPlayer, ColumnScore, ColumnCoins });
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(661, 374);
            dataGridView1.TabIndex = 0;
            // 
            // сolumnData
            // 
            сolumnData.HeaderText = "Дата";
            сolumnData.MinimumWidth = 6;
            сolumnData.Name = "сolumnData";
            сolumnData.Width = 150;
            // 
            // ColumnPlayer
            // 
            ColumnPlayer.HeaderText = "Игрок";
            ColumnPlayer.MinimumWidth = 6;
            ColumnPlayer.Name = "ColumnPlayer";
            ColumnPlayer.Width = 150;
            // 
            // ColumnScore
            // 
            ColumnScore.HeaderText = "Очки";
            ColumnScore.MinimumWidth = 6;
            ColumnScore.Name = "ColumnScore";
            ColumnScore.Width = 150;
            // 
            // ColumnCoins
            // 
            ColumnCoins.HeaderText = "Монеты";
            ColumnCoins.MinimumWidth = 6;
            ColumnCoins.Name = "ColumnCoins";
            ColumnCoins.Width = 150;
            // 
            // resultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 392);
            Controls.Add(dataGridView1);
            Name = "resultsForm";
            Text = "Таблица результатов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn сolumnData;
        private DataGridViewTextBoxColumn ColumnPlayer;
        private DataGridViewTextBoxColumn ColumnScore;
        private DataGridViewTextBoxColumn ColumnCoins;
    }
}