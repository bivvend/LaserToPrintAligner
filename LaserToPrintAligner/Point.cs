using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaserToPrintAligner
{
    public class Point
    {
        public double XMeasured;
        public double YMeasured;
        public double XRemap;
        public double YRemap;
        
        public Point()
        {
            this.XMeasured = 0.0d;
            this.YMeasured = 0.0d;
            this.XRemap = 0.0d;
            this.YRemap = 0.0d;

        }

        public Point(double xm, double ym, double xr, double yr)
        {
            this.XMeasured = xm;
            this.YMeasured = ym;
            this.XRemap = xr;
            this.YRemap = yr;
        }
    }
}
