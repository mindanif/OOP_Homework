using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Matrices
{
    internal class Matr
    {
        private int n;
        private int m;
        private double[,] matr;
        public int N { get => n; set { n = value; } }
        public int M { get => m; set { m = value; } }
        public double[,] Matrix { get => matr; set { matr = value; } }

        public Matr(Matr m)
        {
            
            this.N = m.N;
            this.M = m.M;
            this.Matrix = m.Matrix;
            
        }
        public Matr(int n = 0, int m = 0, bool Zero = false)
        {
            this.n = n;
            this.m = m;
            double[,] matr = new double[n, m];
            Random r = new Random();
            Random d = new Random();
            if (Zero)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matr[i, j] = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matr[i, j] = r.Next(10);
                    }
                }
            }
            this.matr = matr;
        }
        public Matr(string filename = "")
        {
            StreamReader file = new StreamReader(filename);
            string s = file.ReadToEnd();
            file.Close();
            string[] строка = s.Split('\n');
            string[] столбец = строка[0].Split(' ');
            double[,] a = new double[строка.Length, столбец.Length];
            int t = 0;
            for (int i = 0; i < строка.Length; i++)
            {
                столбец = строка[i].Split(' ');
                for (int j = 0; j < столбец.Length; j++)
                {
                    t = Convert.ToInt32(столбец[j]);
                    a[i, j] = t;
                    //Console.Write(" {0}", a[i, j]);
                }
                //Console.WriteLine();
            }

            this.Matrix = a;
            this.N = строка.Length;
            this.M = столбец.Length;


        }
        public Matr()
        {
            this.n = 0;
            this.m = 0;
            this.matr = new double[n, m];
        }
        public void show()
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    Console.Write("{0} ", this.matr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static Matr operator +(Matr A, Matr B)
        {
            if (A.n == B.n && A.m == A.n)
            {
                Matr C = new Matr(A.n, A.m, true);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < A.m; j++)
                    {
                        C.matr[i, j] = A.matr[i, j] + B.matr[i, j];
                    }
                }
                return C;
            }
            else
            {
                throw new Exception("Матрицы нельзя сложить");
            }
        }
        public static Matr operator -(Matr A, Matr B)
        {
            return A + (-1 * B);
        }
        public static Matr operator *(Matr A, Matr B)
        {
            if (A.m == B.n)
            {
                Matr C = new Matr(A.n, B.m, true);
                for (int i = 0; i < A.n; i++)
                {
                    for (int j = 0; j < B.m; j++)
                    {
                        for (int k = 0; k < B.n; k++)
                        {
                            C.matr[i, j] += A.matr[i, k] * B.matr[k, j];
                        }
                    }
                }
                return C;

            }
            else
            {
                throw new Exception("Матрицы нельзя перемножить");
                
            }
        }
        public static Matr operator *(Matr A, double x)
        {
            Matr B = A;
            for (int i = 0; i < A.n; i++)
            {
                for (int j =0; j < A.m; j++)
                {
                    B.matr[i, j] *= x;
                }
            }
            return B;
        }
        public static Matr operator *(double x, Matr A)
        {
            Matr B = A;
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    B.matr[i, j] *= x;
                }
            }
            return B;
        }
        public static Matr operator /(Matr A, double x) => A * (1 / x);
        public Matr trans()
        {
            Matr C = new Matr(this.m, this.n, true);
            for (int i = 0; i < this.m; i++)
            {
                for (int j =0; j < this.n; j++)
                {
                    C.matr[i, j] = this.matr[j, i];
                }
            }
            return C;
            

        }



    }
}
