using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Interop;

namespace TaskGUI6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image newImage = new Image();
        Boolean isFlying = false;
        Point point = new Point();
        int dx = 0;
        int dy = 0;
        int picWidth = 64;
        int picHeight = 64;
        int current = 0;
        List<Point> points = new List<Point> {
            new Point { X = 16, Y = 10 },
            new Point { X = 10, Y = 16 }
        };
        public MainWindow()
        {
            InitializeComponent();
            var img = Properties.Resources.ball;
            var ScreenCapture = Imaging.CreateBitmapSourceFromHBitmap(
                img.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
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
