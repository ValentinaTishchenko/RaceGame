namespace Race
{
    public partial class RaceGame : Form
    {
        private readonly ResultsManager resultsManager;
        private RacePlayer currentPlayer;

        private readonly List<Label>[] laneGroups = new List<Label>[4];
        private readonly List<PictureBox> coins = new List<PictureBox>();
        private readonly List<PictureBox> towardCars = new List<PictureBox>();
        private readonly List<PictureBox> menuCars = new List<PictureBox>();

        private Random random = new Random();
        private bool playerNameRequested = false;
        private bool isGameOver = false;

        public RaceGame()
        {
            InitializeComponent();
            resultsManager = new ResultsManager();
            currentPlayer = new RacePlayer();

            this.Shown += (s, e) => RequestPlayerNameOnce();

            InitializeGame();
        }

        private void RequestPlayerNameOnce()
        {
            if (playerNameRequested) return;
            playerNameRequested = true;

            if (currentPlayer.Name != "Анонимный гонщик")
                return;

            var name = ShowNameInputDialog();
            if (!string.IsNullOrEmpty(name))
            {
                string validatedName = ValidatePlayerName(name);
                currentPlayer.Name = validatedName;
            }
        }

        private string ValidatePlayerName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Анонимный гонщик";
            }
            
            string trimmedName = name.Trim();
                        
            if (trimmedName.Length > GameConstants.MaxPlayerNameLength)
            {
                return trimmedName.Substring(0, GameConstants.MaxPlayerNameLength);
            }

            return trimmedName;
        }

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

            laneGroups[0] = new List<Label> { laneOne1, laneOne2, laneOne3, laneOne4, laneOne5 };
            laneGroups[1] = new List<Label> { laneTwo1, laneTwo2, laneTwo3, laneTwo4, laneTwo5 };
            laneGroups[2] = new List<Label> { menuOneLane1, menuOneLane2, menuOneLane3, menuOneLane4, menuOneLane5 };
            laneGroups[3] = new List<Label> { menuTwoLane1, menuTwoLane2, menuTwoLane3, menuTwoLane4, menuTwoLane5 };
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

        private void RaceGame_Load(object sender, EventArgs e) => InitializeGame();

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
            labelScore.Text = $"Score: {currentPlayer.Score / GameConstants.ScoreDivisor}";
            if (currentPlayer.CarSpeed != 0) currentPlayer.Score++;
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
                lane.Top += currentPlayer.CarSpeed;
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
                coin.Top += currentPlayer.CarSpeed;
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
                    currentPlayer.Coins++;
                    labelCoins.Text = $"Coins: {currentPlayer.Coins}";
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
            if (currentPlayer.CarSpeed != 0)
                mainCar.Left += GameConstants.CarMoveStep;

            if (mainCar.Right >= panelGame.Width)
            {
                mainCar.Left = 0 - mainCar.Width;
            }
        }

        private void MoveCarLeft()
        {
            if (currentPlayer.CarSpeed != 0)
                mainCar.Left -= GameConstants.CarMoveStep;

            if (mainCar.Left <= 0)
            {
                mainCar.Left = panelGame.Width;
            }
        }

        private void IncreaseSpeed()
        {
            if (currentPlayer.CarSpeed < GameConstants.MaxCarSpeed)
                currentPlayer.CarSpeed++;
        }

        private void DecreaseSpeed()
        {
            if (currentPlayer.CarSpeed > 0)
                currentPlayer.CarSpeed--;
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
            var speeds = new[]
            {
                currentPlayer.CarSpeed + GameConstants.OvertakeSpeedBonus,
                currentPlayer.CarSpeed + GameConstants.NormalSpeedBonus,
                currentPlayer.CarSpeed + GameConstants.FastSpeedBonus
            };

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
            if (isGameOver) return;
            isGameOver = true;

            if (currentPlayer.Coins < GameConstants.MinCoinsForContinue)
            {
                SaveGameResult();
                MessageBox.Show("Game Over!", "Приехали!");
                ShowPanel(panelMenu);
            }
            else
            {
                OfferContinueOption();
            }
        }

        private void OfferContinueOption()
        {
            var result = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveGameResult();
                ContinueGame();
            }
            else
                SaveGameResult();
            ShowPanel(panelMenu);
        }

        private void SaveGameResult()
        {
            if (currentPlayer.Score == 0 && currentPlayer.Coins == 0)
                return;

            var gameResult = new GameResult(
                currentPlayer.Name,
                currentPlayer.Score / GameConstants.ScoreDivisor,
                currentPlayer.Coins);

            resultsManager.SaveResult(gameResult);
        }

        private string ShowNameInputDialog()
        {
            using (var inputForm = new Form())
            {
                inputForm.Text = "Введите ваше имя";
                inputForm.Size = new Size(300, 150);
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.StartPosition = FormStartPosition.CenterParent;
                inputForm.MaximizeBox = false;
                inputForm.MinimizeBox = false;

                var textBox = new TextBox()
                {
                    Location = new Point(20, 20),
                    Size = new Size(240, 20),
                    MaxLength = GameConstants.MaxPlayerNameLength,
                    Text = currentPlayer.Name == "Анонимный гонщик" ? "" : currentPlayer.Name
                };

                var okButton = new Button()
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Location = new Point(80, 60),
                    Size = new Size(60, 25)
                };

                var cancelButton = new Button()
                {
                    Text = "Отмена",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(150, 60),
                    Size = new Size(100, 25)
                };

                inputForm.Controls.AddRange(new Control[] { textBox, okButton, cancelButton });
                inputForm.AcceptButton = okButton;
                inputForm.CancelButton = cancelButton;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    return textBox.Text.Trim();
                }

                return string.Empty;
            }
        }

        private void ButtonResults_Click(object sender, EventArgs e)
        {
            var result = resultsManager.GetResultsJson();

            if (result == "[]")
            {
                MessageBox.Show("Результатов пока нет!", "Таблица результатов");
                return;
            }

            MessageBox.Show(result, "Результаты (JSON)",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ContinueGame()
        {
            currentPlayer.Coins -= GameConstants.ContinueCost;
            labelCoins.Text = $"Coins: {currentPlayer.Coins}";
            ResetGameState();

        }

        private void StartGame()
        {
            currentPlayer.Score = 0;
            currentPlayer.Coins = 0;
            currentPlayer.CarSpeed = GameConstants.InitialCarSpeed;
            isGameOver = false;

            ResetGameState();
            ShowPanel(panelGame);
        }

        private void ResetGameState()
        {

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
            var menuSpeeds = new[] {
            GameConstants.OvertakeSpeedBonus,
            GameConstants.NormalSpeedBonus,
            GameConstants.FastSpeedBonus
        };

            for (var i = 0; i < menuCars.Count; i++)
            {
                MoveCar(menuCars[i], menuSpeeds[i]);
            }
        }


        private void ButtonPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            SetupTimers(true);
            ShowPanel(panelGame);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ShowPanel(panelMenu);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            try
            {

                var helpPath = Path.Combine(Application.StartupPath, "help.chm");

                if (!File.Exists(helpPath))
                {
                    MessageBox.Show($"Файл справки не найден:\n{helpPath}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Help.ShowHelp(this, helpPath, HelpNavigator.TableOfContents);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть справку:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            StartGame();
        }


        private void ButtonMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}