using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace PointLibrary
{
    public class MyLine:MyPoint
    {
        public MyLine():base()
        {
            _point.Point2X = _point.Point2Y = 0;
        }
        public MyLine(int x1,int x2,int y1,int y2) : base(x1,y1)
        {
            _point.Point2X = x2;
            _point.Point2Y = y2;
        }
        public override void drow(Grid grid)
        {
            Line line = new Line();
            line.X1 = _point.Point1X;
            line.X2 = _point.Point2X;
            line.Y1 = _point.Point1Y;
            line.Y2 = _point.Point2Y;
            line.Stroke = getRandomColor();
            line.Fill = getRandomColor();
            grid.Children.Add(line);
        }
    }
}
