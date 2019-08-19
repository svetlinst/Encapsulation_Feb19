namespace P01_ClassBox
{
    using System;
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public void GetSurfaceArea()
        {
            var area = 2 * length * width + 2 * length * height + 2 * width * height;
            Console.WriteLine($"Surface Area - {area:f2}");
        }

        public void GetLateralSurfaceArea()
        {
            var area = 2 * this.length * this.height + 2 * this.width * this.height;
            Console.WriteLine($"Lateral Surface Area - {area:f2}");
        }

        public void GetVolume()
        {
            var volume = length * width * height;
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
