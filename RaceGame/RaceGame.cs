namespace Race
{
    public partial class RaceGame : Form
    {
        private readonly Label[] LanesOne = new Label[GameConstants.RoadMarkingsCount];
        private readonly Label[] LanesTwo = new Label[GameConstants.RoadMarkingsCount];
       
        private readonly Random random = new Random();
        private readonly RacePlayer player;

        private CoinManager coinManager;
        private EnemyCarManager enemyCarManager;
        private RoadMarkingsManager gameRoadManager;
       

        public RaceGame(string playerName)
        {
            InitializeComponent();
            player = new RacePlayer(playerName);
        }
                 

        private void TimerRoad_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + player.Score / GameConstants.ScoreDivider;

            gameRoadManager.MoveAllMarkings(player.CarSpeed, Height);

            coinManager.MoveCoins(player.CarSpeed, Width, Height);
            coinManager.CheckCoinCollection(mainCar);

            if (player.CarSpeed != 0)
                player.Score++;
        }

        private List<PictureBox> CreateCoinsFromTemplate(int count)
        {
            List<PictureBox> coins = new List<PictureBox>();

            for (int i = 0; i < count; i++)
            {
                PictureBox newCoin = new PictureBox();
                newCoin.Image = coinTemplate.Image;
                newCoin.Size = coinTemplate.Size;
                newCoin.SizeMode = coinTemplate.SizeMode;
                newCoin.BackColor = coinTemplate.BackColor;
                newCoin.Visible = false;
                newCoin.Name = $"Coin_{i}";

                coins.Add(newCoin);
                panelGame.Controls.Add(newCoin);
            }

            coinTemplate.Visible = false; 
            return coins;
        }



        private void InitializeLanesArrays()
        {
            LanesOne[0] = LaneOne1;
            LanesOne[1] = LaneOne2;
            LanesOne[2] = LaneOne3;
            LanesOne[3] = LaneOne4;
            LanesOne[4] = LaneOne5;

            LanesTwo[0] = LaneTwo1;
            LanesTwo[1] = LaneTwo2;
            LanesTwo[2] = LaneTwo3;
            LanesTwo[3] = LaneTwo4;
            LanesTwo[4] = LaneTwo5;           
        }

        private void RaceGame_Load(object sender, EventArgs e)
        {
            InitializeLanesArrays();

            gameRoadManager = new RoadMarkingsManager(LanesOne, LanesTwo);

            int[] lanePositions = gameRoadManager.GetLanePositions(Width);

            List<PictureBox> coins = CreateCoinsFromTemplate(GameConstants.CoinsCount);
            coinManager = new CoinManager(random, coins, player, labelCoins, lanePositions);

            PictureBox[] enemyCars = { towardCar1, towardCar2, towardCar3 };
            int[] speedBonuses = {
            GameConstants.EnemyCar1SpeedBonus,
            GameConstants.EnemyCar2SpeedBonus,
            GameConstants.EnemyCar3SpeedBonus
        };
            enemyCarManager = new EnemyCarManager(random, enemyCars, speedBonuses);
            gameRoadManager = new RoadMarkingsManager(LanesOne, LanesTwo);

            StartGame();

        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (player.CarSpeed != 0)
            {
                if (e.KeyCode == Keys.Right)
                {

                    if (mainCar.Right < GameConstants.RightBoundary)
                        mainCar.Left += GameConstants.CarMoveStep;
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (mainCar.Left > 0)
                        mainCar.Left -= GameConstants.CarMoveStep;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                player.IncreaseSpeed();
            }
            if (e.KeyCode == Keys.Down)
            {
                player.DecreaseSpeed();
            }
            if (e.KeyCode == Keys.Escape)
            {
                timerRoad.Enabled = false;
                timerTowardCars.Enabled = false;
                panelPause.Show();
            }
        }

        private void TimerTowardCars_Tick(object sender, EventArgs e)
        {
            enemyCarManager.MoveEnemyCars(player.CarSpeed, Width, Height);

            if (enemyCarManager.CheckCollisions(mainCar))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            timerRoad.Stop();
            timerTowardCars.Stop();

            SaveGameResult();

            if (player.Coins < GameConstants.CoinsForContinue)
            {
                MessageBox.Show("Game Over!", "Приехали!");
                ShowGamePanels();
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                    Restart();
                else
                    ShowGamePanels();
            }
        }

        private void SaveGameResult()
        {
            var gameResult = new GameResult(player.Name, player.Score, player.Coins);
            var resultsManager = new ResultsManager();
            resultsManager.SaveResult(gameResult);
        }

        private void ShowGamePanels()
        {
            panelPause.Show();
           
        }

        private void Restart()
        {
            player.SpendCoins(GameConstants.CoinsForContinue);
            labelCoins.Text = "Coins: " + player.Coins;
            player.CarSpeed = GameConstants.InitialCarSpeed;

            ResetGameElements();

            timerRoad.Start();
            timerTowardCars.Start();
            panelPause.Hide();
        }

        private void ResetGameElements()
        {            
            enemyCarManager.ResetEnemyCars(Width, Height);
        }

        private void StartGame()
        {
            player.Reset();

            labelCoins.Text = "Coins: " + player.Coins;

            ResetGameElements();

            timerRoad.Start();
            timerTowardCars.Start();

            this.Focus();

        }
        

        private void ButtonPause_Click(object sender, EventArgs e)
        {

            timerRoad.Enabled = false;
            timerTowardCars.Enabled = false;
            panelPause.Show();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void ButtonToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
       
    }
}


