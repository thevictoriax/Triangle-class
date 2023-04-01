using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    public class RightTriangle: Triangle
    {
        private double side { get; set; }

        public RightTriangle(double side): base(side, side, side)
        {
            this.side = side;
        }
        public double OnscribedRadius()
        {
            return (side * Math.Cbrt(3)) / 3;
        }
        public double InscribedRadius()
        {
            return (side * Math.Cbrt(3)) / 6;
        }
        public override string ToString()
        {
            return $"Right triangle: a = {side} см, b = {side} см, c = {side} см\nP = {Perimeter()} см, p = {Semi_P()} см, S = {Square()} см2\nR = {OnscribedRadius()} см, r = {InscribedRadius()} см\n";
        }
    }
}
