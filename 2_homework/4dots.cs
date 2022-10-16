using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice2
{
    class Dots : Coord
    {
        private Coord A;
        private Coord B;
        private Coord C;
        private Coord D;


        public Dots(Coord A, Coord B, Coord C, Coord D)
        {
            if (Coord.Equasion3D(A, B, C, D)){
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
            }
            else
            {
                Console.WriteLine("This is not quadrileteral))");
                this.A =  new Coord(0,0,0);
                this.B = new Coord(0, 0, 0);
                this.C = new Coord(0, 0, 0);
                this.D = new Coord(0, 0, 0);
            }

            
        }
        public static double S(Dots QR)
        {
            return Math.Abs(Coord.Dist(QR.A, QR.C) * Coord.Dist(QR.B, QR.D) * Coord.Sin(QR.A - QR.C, QR.B - QR.D)/2);
        }
        public static double P(Dots QR)
        {
            return Coord.Dist(QR.A, QR.B) + Coord.Dist(QR.B, QR.C) + Coord.Dist(QR.C, QR.D) + Coord.Dist(QR.D, QR.A);
        }
        public static double[] Diagon(Dots QR)
        {
            double D1 = Coord.Dist(QR.A, QR.C);
            double D2 = Coord.Dist(QR.B, QR.D);
            double[] Diagon = new double[2] { D1, D2 };
            return Diagon;
        }
        public static bool Сonvex(Dots Qr)
        {
            if (VectMult(Qr.B - Qr.A, Qr.C - Qr.B) / VectMult(Qr.A - Qr.D, Qr.B - Qr.A) &&
                VectMult(Qr.C - Qr.B, Qr.D - Qr.C) / VectMult(Qr.A - Qr.D, Qr.B - Qr.A) &&
                VectMult(Qr.D - Qr.C, Qr.A - Qr.D) / VectMult(Qr.A - Qr.D, Qr.B - Qr.A))
            {
                return true;
            }

            return false;
        }


        public static new double Dist(Coord A, Coord B)
        {
            return Math.Abs(A.X - B.X) + Math.Abs(A.Y - B.Y) + Math.Abs(A.Z - B.Z);
        }
    }
}
