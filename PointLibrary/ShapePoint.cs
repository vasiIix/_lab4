using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace PointLibrary
{
    public struct pictureData
    {
        public int Point1X { get; set; }
        public int Point1Y { get; set; }
        public int Point2X { get; set; }
        public int Point2Y { get; set; }
        public int Point3X { get; set; }
        public int Point3Y { get; set; }
    }
    public class ShapePoint
    {

        protected pictureData _point;
        public ShapePoint()
        {

        }
        public virtual void drow(Grid grid)
        {

        }
    }
}