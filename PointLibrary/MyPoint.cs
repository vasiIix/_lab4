using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace PointLibrary
{
    public class MyPoint : ShapePoint
    {
        private Brush[] arr = { Brushes.Green, Brushes.Aqua, Brushes.Peru, Brushes.PaleGoldenrod, Brushes.Yellow, Brushes.Blue, Brushes.Transparent, Brushes.Gray, Brushes.Red, Brushes.Black };
        public MyPoint() { _point.Point1X = _point.Point1Y = 0; }
        public MyPoint(int x, int y)
        {
            _point.Point1X = x;
            _point.Point1Y = y;
        }
        protected Brush getRandomColor()
        {
            var rand = new Random();

            //  return new SolidColorBrush(Color.FromRgb((byte)bytes[1], (byte)bytes[2], (byte)bytes[3]));
            return arr[rand.Next(0, 9)];

        }



        public override void drow(Grid grid)
        {
            Line line = new Line();
            line.X1 = line.X2 = _point.Point1X;
            line.Y1 = line.Y2 = _point.Point1Y;
            line.Stroke = getRandomColor();
            line.Fill = getRandomColor();
            grid.Children.Add(line);
        }
    }
}
