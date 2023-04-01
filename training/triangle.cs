using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    public class Triangle: IComparable<Triangle>
    {
        public double a { get; set; }
        public double b { get; set; }  
        public double c { get; set; }

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;

        }

        public Triangle(double _a, double _b, double _c)
        {
            a = _a; b= _b; c = _c;
        }

        public virtual double Perimeter()
        {
            return a + b + c;
        }
        public virtual double Semi_P()
        {
            return Perimeter()/2;
        }
        public virtual double Square()
        {
           double p = Semi_P();
           return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override string ToString()
        {
            return $"Triangle: a = {a} см, b = {b} см, c = {c} см\nP = {Perimeter()} см, p = {Semi_P()} см, S = {Square()} см2\n";
        }
        public int CompareTo(Triangle other)
        {
            return Square().CompareTo(other.Square());
        }
        public static bool operator <(Triangle lhs, Triangle rhs)
        {
            return lhs.Square() < rhs.Square();
        }
        public static bool operator >(Triangle lhs, Triangle rhs)
        {
            return lhs.Square() > rhs.Square();
        }

        public static bool operator ==(Triangle lhs, Triangle rhs)
        {
            return lhs.Square() == rhs.Square();
        }

        public static bool operator !=(Triangle lhs, Triangle rhs)
        {
            return lhs.Square() != rhs.Square();
        }

        public static double operator +(Triangle lhs, Triangle rhs)
        {
            return lhs.Square() + rhs.Square();
        }

        public static double operator -(Triangle lhs, Triangle rhs)
        {
            return lhs.Square() - rhs.Square();
        }
      
    }

}
