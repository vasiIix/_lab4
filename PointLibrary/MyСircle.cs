using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace PointLibrary
{
    public class MyСircle:MyPoint
    {
        public MyСircle():base()
        {
            _point.Point2X = _point.Point2Y = 0;
        }

        public MyСircle(int x1,int x2, int y1, int y2):base(x1,y1)
        {
            _point.Point2X = x2;
            _point.Point2Y = y2;
        }
        public override void drow(Grid grid)
        {
            Ellipse ellipse = new Ellipse();
            float value= (float)Math.Sqrt(Math.Abs((_point.Point1X- _point.Point2X)* (_point.Point1X - _point.Point2X) + (_point.Point1Y- _point.Point2Y)* (_point.Point1Y - _point.Point2Y)));
            ellipse.Width = ellipse.Height = value;
            ellipse.Stroke = getRandomColor();
            ellipse.Fill = getRandomColor();
            grid.Children.Add(ellipse);
        }
    }
}
