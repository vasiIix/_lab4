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
    public class MyEllipse:MyСircle
    {
        public MyEllipse() : base() { }
        public MyEllipse(int x1, int x2, int x3, int y1, int y2, int y3) : base(x1,x2,y1,y2) 
        {
            _point.Point3X = x3;
            _point.Point3Y = y3;
        }
        public override void drow(Grid grid)
        {
            Ellipse ellipse = new Ellipse();
            float value1 = (float)Math.Sqrt(Math.Abs((_point.Point1X - _point.Point2X) * (_point.Point1X - _point.Point2X) + (_point.Point1Y - _point.Point2Y) * (_point.Point1Y - _point.Point2Y)));
            float value2 = (float)Math.Sqrt(Math.Abs((_point.Point1X - _point.Point3X) * (_point.Point1X - _point.Point3X) + (_point.Point1Y - _point.Point3Y) * (_point.Point1Y - _point.Point3Y)));
            ellipse.Width = value1;
            ellipse.Height = value2;
            ellipse.Stroke = getRandomColor();
            ellipse.Fill = getRandomColor();
            grid.Children.Add(ellipse);
        }

    }
}
