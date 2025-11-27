namespace Race
{
    public partial class RaceGame : Form
    {
        public RaceGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        
        private const int minCoinsForContinue = 15;
        private const int continueCost = 15;
        private const int initialCarSpeed = 2;
        private const int maxCarSpeed = 21;
        
        private const int carMoveStep = 9;
        private const int leftBoundary = 0;
        private const int gameAreaWidth = 500;
        private const int scoreDivisor = 10;

        private readonly List<Label>[] laneGroups = new List<Label>[4];
        private readonly List<PictureBox> coins = new List<PictureBox>();
        private readonly List<PictureBox> towardCars = new List<PictureBox>();
        private readonly List<PictureBox> menuCars = new List<PictureBox>();

        private Random random = new Random();
        private int score = 0;
        private int coinCount = 0;
        private int carSpeed = initialCarSpeed;

        private void InitializeGame()
        {
            InitializeLanes();
            InitializeCoins();
            InitializeCars();
            SetupTimers(false);
            ShowPanel(panelMenu);
        }

        private void InitializeLanes()
        {
            
            laneGroups[0] = new List<Label> { LaneOne1, LaneOne2, LaneOne3, LaneOne4, LaneOne5 };
            laneGroups[1] = new List<Label> { LaneTwo1, LaneTwo2, LaneTwo3, LaneTwo4, LaneTwo5 };
            laneGroups[2] = new List<Label> { MenuOneLane1, MenuOneLane2, MenuOneLane3, MenuOneLane4, MenuOneLane5 };
            laneGroups[3] = new List<Label> { MenuTwoLane1, MenuTwoLane2, MenuTwoLane3, MenuTwoLane4, MenuTwoLane5 };
        }

        private void InitializeCoins()
        {
            coins.Clear();

            coins.AddRange(new[] { coin1, coin2, coin3 });
        }

        private void InitializeCars()
        {
            towardCars.Clear();
            menuCars.Clear();

            towardCars.AddRange(new[] { towardCar1, towardCar2, towardCar3 });
            menuCars.AddRange(new[] { carMenu1, carMenu2, carMenu3 });
        }

        private void SetupTimers(bool enabled)
        {
            timerRoad.Enabled = enabled;
            timerTowardCars.Enabled = enabled;
        }

        private void ShowPanel(Panel panelToShow)
        {
            panelMenu.Hide();
            panelGame.Hide();
            panelPause.Hide();
            panelToShow.Show();
        }

        
        private void TimerRoad_Tick(object sender, EventArgs e)
        {
            UpdateScore();
            MoveLanes(laneGroups[0], laneGroups[1]);
            MoveCoins();
            CollectCoins();
        }

        private void UpdateScore()
        {
            labelScore.Text = $"Score: {score / 10}";
            if (carSpeed != 0) score++;
        }

        private void MoveLanes(List<Label> lanesOne, List<Label> lanesTwo)
        {
            MoveLaneGroup(lanesOne);
            MoveLaneGroup(lanesTwo);
        }

        private void MoveLaneGroup(List<Label> lanes)
        {
            foreach (var lane in lanes)
            {
                lane.Top += carSpeed;
                if (lane.Top >= Height)
                {
                    lane.Top = -lane.Height;
                }
            }
        }

        private void MoveCoins()
        {
            foreach (var coin in coins)
            {
                coin.Top += carSpeed;
                if (coin.Top > Height)
                {
                    ResetCoinPosition(coin);
                }
            }
        }

        private void ResetCoinPosition(PictureBox coin)
        {
            coin.Top = -coin.Height;
            coin.Left = random.Next(0, Width - coin.Width);
        }

        private void CollectCoins()
        {
            for (var i = 0; i < coins.Count; i++)
            {
                if (mainCar.Bounds.IntersectsWith(coins[i].Bounds))
                {
                    coinCount++;
                    labelCoins.Text = $"Coins: {coinCount}";
                    ResetCoinPosition(coins[i]);
                }
            }
        }
                

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveCarRight();
                    break;
                case Keys.Left:
                    MoveCarLeft();
                    break;
                case Keys.Up:
                    IncreaseSpeed();
                    break;
                case Keys.Down:
                    DecreaseSpeed();
                    break;
                case Keys.Escape:
                    PauseGame();
                    break;
            }
        }

        private void MoveCarRight()
        {
            if (carSpeed != 0 && mainCar.Right < gameAreaWidth)
                mainCar.Left += carMoveStep;
        }

        private void MoveCarLeft()
        {
            if (carSpeed != 0 && mainCar.Left > leftBoundary)
                mainCar.Left -= carMoveStep;
        }

        private void IncreaseSpeed()
        {
            if (carSpeed < maxCarSpeed)
                carSpeed++;
        }

        private void DecreaseSpeed()
        {
            if (carSpeed > 0)
                carSpeed--;
        }

        private void PauseGame()
        {
            SetupTimers(false);
            ShowPanel(panelPause);
        }

        
        private void TimerTowardCars_Tick(object sender, EventArgs e)
        {
            MoveTowardCars();
            CheckCollisions();
        }

        private void MoveTowardCars()
        {
            var speeds = new[] { carSpeed + 4, carSpeed + 2, carSpeed + 3 };

            for (var i = 0; i < towardCars.Count; i++)
            {
                MoveCar(towardCars[i], speeds[i]);
            }
        }

        private void MoveCar(PictureBox car, int speed)
        {
            if (car == null) return;

            car.Top += speed;
            if (car.Top > Height)
            {
                ResetCarPosition(car);
            }
        }
               

        private void ResetCarPosition(PictureBox car)
        {
            if (car == null) return;

            car.Top = -car.Height;
            car.Left = random.Next(0, Width - car.Width);
        }

        private void CheckCollisions()
        {
            foreach (var car in towardCars)
            {
                if (mainCar.Bounds.IntersectsWith(car.Bounds))
                {
                    GameOver();
                    return;
                }
            }
        }


        private void GameOver()
        {
            SetupTimers(false);

            if (coinCount < minCoinsForContinue)
            {
                ShowGameOverMessage();
            }
            else
            {
                OfferContinueOption();
            }
        }

        private void ShowGameOverMessage()
        {
            MessageBox.Show("Game Over!", "Приехали!");
            ShowPanel(panelPause);
            ShowPanel(panelMenu);
        }

        private void OfferContinueOption()
        {
            var result = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                ContinueGame();
            else
                ShowPanel(panelPause);
        }

        private void ContinueGame()
        {
            coinCount -= continueCost;
            labelCoins.Text = $"Coins: {coinCount}";
            ResetGameState();
        }

        private void StartGame()
        {
            score = 0;
            coinCount = 0;
            carSpeed = initialCarSpeed;
            ResetGameState();
            ShowPanel(panelGame);
        }

        private void ResetGameState()
        {
            carSpeed = initialCarSpeed;
            SetupTimers(true);

            foreach (var car in towardCars)
            {
                ResetCarPosition(car);
            }
        }

       
        private void TimerMenu_Tick(object sender, EventArgs e)
        {
            AnimateMenuLanes();
            AnimateMenuCars();
        }

        private void AnimateMenuLanes()
        {
            MoveLanes(laneGroups[2], laneGroups[3]);
        }

        private void AnimateMenuCars()
        {
            var menuSpeeds = new[] { 5, 3, 4 };

            for (int i = 0; i < menuCars.Count; i++)
            {
                MoveCar(menuCars[i], menuSpeeds[i]);
            }
        }

                
        private void ButtonPause_Click(object sender, EventArgs e) => PauseGame();

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            SetupTimers(true);
            ShowPanel(panelGame);
        }

        private void ButtonExit_Click(object sender, EventArgs e) => ShowPanel(panelMenu);

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\khha4\Race\help.chm", HelpNavigator.TableOfContents);
        }

        private void ButtonStart_Click(object sender, EventArgs e) => StartGame();

        private void ButtonMenuExit_Click(object sender, EventArgs e) => Close();

        private void RaceGame_Load(object sender, EventArgs e) => InitializeGame();

        
    }
}