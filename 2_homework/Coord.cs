using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class coord
    {
        double x;
        double y;
        double z;

        public coord(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public void show()
        {
            Console.WriteLine("{0},{1},{2}", this.x, this.y, this.z);
        }

        public static double Dist(coord A, coord B)
        {
            double rez;
            rez = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2) + Math.Pow(A.z - B.z, 2));
            return rez;
        }

        public static void Equasion2D(coord A, coord B)
        {
            Console.WriteLine("(x-{0})/{1}=(y-{2})/{3}=(z-{4})/{5}", A.x, B.x - A.x, A.y, B.y - A.y, A.z, B.z - A.z);
        }
        public static void Equasion3D(coord A, coord B, coord C)
        {
            Console.WriteLine("(x-{0})*{1}-(y-{2})*{3}+(z-{4})*{5} = 0", A.x, (B.y - A.y) * (C.z - A.z) - (C.y - A.y) * (B.z - A.z), A.y, (B.x - A.x) * (C.z - A.z) - (B.z - A.z) * (C.x - A.x), A.z, (B.x - A.x) * (C.y - A.y) - (B.y - A.y) * (C.x - A.x));
        }
        public static double DistBeg(coord A)
        {
            double rez;
            rez = Math.Sqrt(Math.Pow(A.x, 2) + Math.Pow(A.y, 2) + Math.Pow(A.z, 2));
            return rez;
        }

        public static coord operator +(coord A, coord B)
        {
            return new(A.x + B.x, A.y + B.y, A.z + B.z);
        }

        public static double operator *(coord A, coord B)
        {
            return A.x * B.x + A.y * B.y + A.z * B.z;
        }
        public static void VectMult(coord A, coord B)
        {
            Console.WriteLine("{0}*i - ({1})*j + ({2})*k", A.y * B.z - A.z * B.y, A.x * B.z - A.z * B.x, A.x * B.y - A.y * B.x);
        }
    }


}