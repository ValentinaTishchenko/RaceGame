namespace Race
{
    public class CoinManager
    {
        private readonly Random random;
        private readonly List<PictureBox> coins;
        private readonly RacePlayer player;
        private readonly Label coinsLabel;

        private readonly int[] lanePositions;
        private readonly bool[] laneHasCoin;


        public CoinManager(Random random, List<PictureBox> coins, RacePlayer player, Label coinsLabel, int[] lanePositions)
        {
            this.random = random;
            this.coins = coins;
            this.player = player;
            this.coinsLabel = coinsLabel;

            this.lanePositions = lanePositions;
           
            

            ResetAllCoins();
        }

        
        public void MoveCoins(int carSpeed, int formWidth, int formHeight)
        {
            foreach (var coin in coins)
            {
                coin.Top += carSpeed;
                if (coin.Top > formHeight)
                {
                    ResetCoinPosition(coin);
                }
            }
        }

        public void CheckCoinCollection(PictureBox mainCar)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].Visible && mainCar.Bounds.IntersectsWith(coins[i].Bounds))
                {
                    CollectCoin(i);
                }
            }
        }

        private void CollectCoin(int coinIndex)
        {
            player.AddCoin();
            coinsLabel.Text = "Coins: " + player.Coins;        

            ResetCoinPosition(coins[coinIndex]);
        }

        private void ResetCoinPosition(PictureBox coin)
        {
            var randomLane = random.Next(lanePositions.Length);
            coin.Top = -coin.Height;
            coin.Left = lanePositions[randomLane] - (coin.Width / 2);
            coin.Visible = true;
        }       

       
        private void ResetAllCoins()
        {                    
            foreach (var coin in coins)
            {
                ResetCoinPosition(coin);
            }
        }

    }
}
