using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Matrices
{
    internal class InMatr:SQMatr
    {
        public InMatr(SQMatr m) : base(m)
        {
            if (m.Det() != 0)
            {
                this.N = m.N;
                this.M = m.M;
                this.Matrix = m.Matrix;
            }
        }
        public InMatr(Matr m) : base(m)
        {
            if (m.N == m.M)
            {
                SQMatr a  = new SQMatr(m);
                if (a.Det() != 0)
                {
                    this.N = m.N;
                    this.M = m.M;
                    this.Matrix = m.Matrix;
                }
            }
        }

        public static InMatr Cop(InMatr A)
        {
            return A;
        }
        public InMatr Inverce()
        {
            InMatr Copy = new InMatr(new Matr(this.N, this.M, true));
            for (int i = 0; i < this.N; i++)
            {
                for (int j = 0; j < this.M; j++)
                {
                    Copy.Matrix[j, i] = this.Minor(i, j).Det() * Math.Pow(-1, i + j);
                }
            }
            Matr S = Copy / this.Det();
            InMatr SS = new InMatr(S);
            return SS;

        }
    }
}
