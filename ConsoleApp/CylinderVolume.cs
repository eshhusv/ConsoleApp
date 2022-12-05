using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CylinderVolume
    {
        private double Diameter;
        private double Height;

        public CylinderVolume(double diameter, double height)
        {
            Diameter = diameter;
            Height = height;
        }

        public double getVolume()
        {
            return Math.PI * Diameter * Height;
        }
    }
}
