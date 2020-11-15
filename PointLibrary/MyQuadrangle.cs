using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PointLibrary
{
    public class MyQuadrangle:MyLine
    {
        public MyQuadrangle() : base() { }
        public MyQuadrangle(int x1, int x2, int y1, int y2) : base(x1,x2,y1,y2) { }
        public override void drow(Grid grid)
        {
            Polygon polygon= new Polygon();
            polygon.Points.Add(new Point(_point.Point1X, _point.Point1Y));
            polygon.Points.Add(new Point(_point.Point1X, _point.Point2Y));
            polygon.Points.Add(new Point(_point.Point2X, _point.Point2Y));
            polygon.Points.Add(new Point(_point.Point2X, _point.Point1Y));
            polygon.Stroke = getRandomColor();
            polygon.Fill = getRandomColor();
            grid.Children.Add(polygon);
        }
    }
}
