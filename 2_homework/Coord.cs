using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Coord
    {
        double x;
        double y;
        double z;

        public Coord(double X=0, double Y=0, double Z = 0)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public double X { get { return x; } }
        public double Y { get { return y; } }
        public double Z { get { return z; } }

        public void show()
        {
            Console.WriteLine("{0},{1},{2}", this.x, this.y, this.z);
        }

        public static double Dist(Coord A, Coord B)
        {
            double rez;
            rez = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2) + Math.Pow(A.z - B.z, 2));
            return rez;
        }

        public static bool Equasion2D(Coord A, Coord B, Coord C)
        {
            return ((C.x - A.x)/ B.x - A.x) == ((C.y - A.y)/ B.y - A.y) && ((C.z - A.z)/ B.z - A.z) == ((C.x - A.x) / B.x - A.x);
        }
        public static bool Equasion3D(Coord A, Coord B, Coord C, Coord D)
        {
           
            return ((D.x - A.x) * ((B.y - A.y) * (C.z - A.z) - (C.y - A.y) * (B.z - A.z))
                - (D.y - A.y) * ((B.x - A.x) * (C.z - A.z) - (B.z - A.z) * (C.x - A.x)) 
                + (D.z - A.z) * ((B.x - A.x) * (C.y - A.y) - (B.y - A.y) * (C.x - A.x)) == 0);
        }
        
        public static double DistBeg(Coord A)
        {
            double rez;
            rez = Math.Sqrt(Math.Pow(A.x, 2) + Math.Pow(A.y, 2) + Math.Pow(A.z, 2));
            return rez;
        }

        public static Coord operator +(Coord A, Coord B)
        {
            return new(A.x + B.x, A.y + B.y, A.z + B.z);
        }
        public static Coord operator -(Coord A, Coord B)
        {
            return new(A.x - B.x, A.y - B.y, A.z - B.z);
        }
        public static bool operator /(Coord A, Coord B)
        {
            return A.x / B.x >= 0 && A.y / B.y >= 0;
        }
        public static double operator *(Coord A, Coord B)
        {
            return A.x * B.x + A.y * B.y + A.z * B.z;
        }
        public static Coord VectMult(Coord A, Coord B)
        {
            Coord C = new Coord(A.y * B.z - A.z * B.y, -(A.x * B.z - A.z * B.x), A.x * B.y - A.y * B.x);
            return C;
        }
        public static double Sin(Coord A, Coord B)
        {
            return Math.Sqrt(1 - Math.Pow((A * B / (Coord.DistBeg(A) * Coord.DistBeg(B))), 2));
        }

        

    }

 
}