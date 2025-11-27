namespace Race
{
    public class Coin
    {
        public PictureBox PictureBox { get; private set; }
        public bool IsCollected { get; set; }
        private Random random;

        public Coin(PictureBox pictureBox, Random random)
        {
            PictureBox = pictureBox;
            this.random = random;
            IsCollected = false;
        }

        public void Move(int carSpeed, int formHeight, int formWidth)
        {
            if (!IsCollected)
            {
                PictureBox.Top += carSpeed;
                if (PictureBox.Top > formHeight)
                {
                    ResetPosition(formWidth);
                }
            }
        }

        public void ResetPosition(int formWidth)
        {
            PictureBox.Top = -PictureBox.Height;
            PictureBox.Left = random.Next(0, formWidth - PictureBox.Width);
            IsCollected = false;
        }

        public void Collect()
        {
            IsCollected = true;
            PictureBox.Top = -PictureBox.Height;
        }

        public bool CheckCollision(Rectangle bounds)
        {
            return !IsCollected && PictureBox.Bounds.IntersectsWith(bounds);
        }
    }
}
