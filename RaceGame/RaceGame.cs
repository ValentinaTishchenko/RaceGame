namespace Race
{
    public partial class RaceGame : Form
    {
        public RaceGame()
        {
            InitializeComponent();
        }

        Label[] LanesOne = new Label[5];
        Label[] LanesTwo = new Label[5];
        Label[] LanesMenuOne = new Label[5];
        Label[] LanesMenuTwo = new Label[5];
        Random random = new Random();
        int score = 0;
        int coins = 0;
        int carSpeed = 2;

        private void MoveRoadMarkings(Label[] lanes)
        {
            for (int i = 0; i < lanes.Length; i++)
            {
                lanes[i].Top += carSpeed;
                if (lanes[i].Top >= Height)
                {
                    lanes[i].Top = -lanes[i].Height;
                }
            }
        }

        private void MoveCoin(PictureBox coin)
        {
            coin.Top += carSpeed;
            if (coin.Top > Height)
            {
                coin.Top = -coin.Height;
                coin.Left = random.Next(0, Width - coin.Width);
            }
        }

        private void MoveEnemyCar(PictureBox car, int speedBonus)
        {
            car.Top += carSpeed + speedBonus;
            if (car.Top > Height)
            {
                car.Top = -car.Height;
                car.Left = random.Next(0, Width - car.Width);
            }
        }

        private void TimerRoad_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score / GameConstants.ScoreDivider; 

            MoveRoadMarkings(LanesOne);
            MoveRoadMarkings(LanesTwo);

            MoveCoin(Coin1);
            MoveCoin(Coin2);
            MoveCoin(Coin3);

            CoinsCollect();

            if (carSpeed != 0)
                score++;
        }
        private void CoinsCollect()
        {
            CollectSingleCoin(Coin1, 0, GameConstants.CoinZone1Max);
            CollectSingleCoin(Coin2, GameConstants.CoinZone1Max, GameConstants.CoinZone2Max);
            CollectSingleCoin(Coin3, GameConstants.CoinZone2Max, GameConstants.CoinZone3Max);
        }

        private void CollectSingleCoin(PictureBox coin, int minLeft, int maxLeft)
        {
            if (mainCar.Bounds.IntersectsWith(coin.Bounds))
            {
                coins++;
                labelCoins.Text = "Coins: " + coins;
                coin.Top = -coin.Height;
                coin.Left = random.Next(minLeft, maxLeft);
            }
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


            LanesMenuOne[0] = MenuOneLane1;
            LanesMenuOne[1] = MenuOneLane2;
            LanesMenuOne[2] = MenuOneLane3;
            LanesMenuOne[3] = MenuOneLane4;
            LanesMenuOne[4] = MenuOneLane5;

            LanesMenuTwo[0] = MenuTwoLane1;
            LanesMenuTwo[1] = MenuTwoLane2;
            LanesMenuTwo[2] = MenuTwoLane3;
            LanesMenuTwo[3] = MenuTwoLane4;
            LanesMenuTwo[4] = MenuTwoLane5;
        }

        private void RaceGame_Load(object sender, EventArgs e)
        {
            InitializeLanesArrays();

            timerRoad.Stop();
            timerTowardCars.Stop();
            panelMenu.Show();
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (carSpeed != 0)
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
                if (carSpeed < GameConstants.MaxCarSpeed)
                    carSpeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                    carSpeed--;
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
            MoveEnemyCar(towardCar1, GameConstants.EnemyCar1SpeedBonus);
            MoveEnemyCar(towardCar2, GameConstants.EnemyCar2SpeedBonus);
            MoveEnemyCar(towardCar3, GameConstants.EnemyCar3SpeedBonus);

            if (mainCar.Bounds.IntersectsWith(towardCar1.Bounds) ||
                mainCar.Bounds.IntersectsWith(towardCar2.Bounds) ||
                mainCar.Bounds.IntersectsWith(towardCar3.Bounds))
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            timerRoad.Stop();
            timerTowardCars.Stop();

            if (coins < GameConstants.CoinsForContinue)
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

        private void ShowGamePanels()
        {
            panelPause.Show();
            panelMenu.Show();
        }

        private void Restart()
        {
            coins -= GameConstants.CoinsForContinue;
            labelCoins.Text = "Coins: " + coins;
            carSpeed = GameConstants.InitialCarSpeed;

            ResetGameElements();

            timerRoad.Start();
            timerTowardCars.Start();
        }

        private void ResetGameElements()
        {
            ResetEnemyCar(towardCar1);
            ResetEnemyCar(towardCar2);
            ResetEnemyCar(towardCar3);
        }

        private void ResetEnemyCar(PictureBox car)
        {
            car.Top = -car.Height;
            car.Left = random.Next(0, Width - car.Width);
        }

        private void StartGame()
        {
            score = 0;
            coins = 0;
            carSpeed = GameConstants.InitialCarSpeed;

            ResetGameElements();

            timerRoad.Start();
            timerTowardCars.Start();

            ShowGamePanel();
        }

        private void ShowGamePanel()
        {
            panelPause.Hide();
            panelGame.Show();
            panelMenu.Hide();
        }

        private void TimerMenu_Tick(object sender, EventArgs e)
        {
            MoveRoadMarkings(LanesMenuOne);
            MoveRoadMarkings(LanesMenuTwo);

            MoveMenuCar(CarMenu1, GameConstants.MenuCar1Speed);
            MoveMenuCar(CarMenu2, GameConstants.MenuCar2Speed);
            MoveMenuCar(CarMenu3, GameConstants.MenuCar3Speed);
        }

        private void MoveMenuCar(PictureBox car, int speed)
        {
            car.Top += speed;
            if (car.Top > Height)
            {
                car.Top = -car.Height;
                car.Left = random.Next(0, Width - car.Width);
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {

            timerRoad.Enabled = false;
            timerTowardCars.Enabled = false;
            panelPause.Show();
        }

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            timerRoad.Enabled = true;
            timerTowardCars.Enabled = true;
            panelPause.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\khha4\Race\help.chm", HelpNavigator.TableOfContents);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StartGame();
            panelGame.Show();
            panelMenu.Hide();
        }

        private void ButtonMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

