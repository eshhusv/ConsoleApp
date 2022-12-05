using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CylinderVolume
    {
        private double diameter;
        private double height;

        public CylinderVolume(double diameter, double height)
        {
            Diameter = diameter;
            Height = height;
        }
        
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double getVolume()
        {
            return Math.PI * Diameter * Height;
        }
    }
}
