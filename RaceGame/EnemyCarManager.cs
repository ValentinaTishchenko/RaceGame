namespace Race
{
    public class EnemyCarManager
    {
        private readonly Random random;
        private readonly PictureBox[] enemyCars;
        private readonly int[] speedBonuses;
        public EnemyCarManager(Random random, PictureBox[] enemyCars, int[] speedBonuses)
        {
            this.random = random;
            this.enemyCars = enemyCars;
            this.speedBonuses = speedBonuses;
        }

        public void MoveEnemyCars(int playerCarSpeed, int formWidth, int formHeight)
        {
            for (int i = 0; i < enemyCars.Length; i++)
            {
                MoveSingleEnemyCar(enemyCars[i], playerCarSpeed + speedBonuses[i], formWidth, formHeight);
            }
        }

        public bool CheckCollisions(PictureBox mainCar)
        {
            foreach (var enemyCar in enemyCars)
            {
                if (mainCar.Bounds.IntersectsWith(enemyCar.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        public void ResetEnemyCars(int formWidth, int formHeight)
        {
            foreach (var car in enemyCars)
            {
                ResetEnemyCarPosition(car, formWidth, formHeight);
            }
        }

        private void MoveSingleEnemyCar(PictureBox car, int speed, int formWidth, int formHeight)
        {
            car.Top += speed;
            if (car.Top > formHeight)
            {
                ResetEnemyCarPosition(car, formWidth, formHeight);
            }
        }

        private void ResetEnemyCarPosition(PictureBox car, int formWidth, int formHeight)
        {
            car.Top = -car.Height;
            car.Left = random.Next(0, formWidth - car.Width);
        }
    }
}

    
