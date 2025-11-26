
namespace Race
{
    public class MenuCarManager
    {
        private readonly Random random;
        private readonly PictureBox[] menuCars;
        private readonly int[] menuCarSpeeds;

        public MenuCarManager(Random random, PictureBox[] menuCars, int[] menuCarSpeeds)
        {
            this.random = random;
            this.menuCars = menuCars;
            this.menuCarSpeeds = menuCarSpeeds;
        }

        public void MoveMenuCars(int formWidth, int formHeight)
        {
            for (int i = 0; i < menuCars.Length; i++)
            {
                MoveSingleMenuCar(menuCars[i], menuCarSpeeds[i], formWidth, formHeight);
            }
        }

        private void MoveSingleMenuCar(PictureBox car, int speed, int formWidth, int formHeight)
        {
            car.Top += speed;
            if (car.Top > formHeight)
            {
                ResetMenuCarPosition(car, formWidth, formHeight);
            }
        }

        private void ResetMenuCarPosition(PictureBox car, int formWidth, int formHeight)
        {
            car.Top = -car.Height;
            car.Left = random.Next(0, formWidth - car.Width);
        }
    }
}
