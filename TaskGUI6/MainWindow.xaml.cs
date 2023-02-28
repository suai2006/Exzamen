using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TaskGUI6
{
    internal class Timeout : System.Timers.Timer
    {
        public Timeout(Action action, double delay)
        {
            this.AutoReset = false;
            this.Interval = delay;
            this.Elapsed += (sender, args) => action();
            this.Start();
        }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public System.Windows.Controls.Image newImage = new System.Windows.Controls.Image();
        public Boolean isFlying = false;
        public Point point = new Point();
        public int dx = 0;
        public int dy = 0;
        public int picWidth = 64;
        public int picHeight = 64;
        public int current = 0;
        public List<Point> points = new List<Point> {
            new Point { X = 16, Y = 10 },
            new Point { X = 10, Y = 16 }
        };
        public MainWindow()
        {
            InitializeComponent();
            var ball = Properties.Resources.football;
            var ScreenCapture = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                ball.GetHbitmap(),
                IntPtr.Zero,
                System.Windows.Int32Rect.Empty,
                BitmapSizeOptions.FromWidthAndHeight(picWidth, picHeight));
            newImage.Source = ScreenCapture;
            newImage.Width = picWidth;
            newImage.Height = picHeight;
            point.X = 0;
            point.Y = 0;
            BallField.Children.Add(newImage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!isFlying)
            {
                isFlying = true;
                if (current >= points.Count) current = 0;
                Point point = points.ElementAt(current);
                dx = (int)point.X;
                dy = (int)point.Y;
                BallFly();
                current++;
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            isFlying = false;
        }
        private async void BallFly()
        {
            if (isFlying)
            {
                var maxX = BallField.ActualWidth - newImage.Width;
                var maxY = BallField.ActualHeight - newImage.Height;
                if (point.Y + dy > maxY || point.Y + dy < 0) dy = -dy;
                if (point.X + dx > maxX || point.X + dx < 0) dx = -dx;
                point.X += dx;
                point.Y += dy;
                if (maxY > point.Y) Canvas.SetTop(newImage, point.Y);
                if (maxX > point.X) Canvas.SetLeft(newImage, point.X);
                await Task.Delay(1);
                BallFly();
            }
        }
    }
}
