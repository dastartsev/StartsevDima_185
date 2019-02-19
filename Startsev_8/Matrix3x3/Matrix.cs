using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix3x3
{
    public class Matrix
    {
        protected double[,] _mtr = new double[3, 3];

        public Matrix(double[,] new_Mtr)
        {
            _mtr = new_Mtr;
        }

        public double[,] mtr
        {
            get
            {
                return _mtr;
            }
        }

        public double get_Det_2(double[,] mtr)
        {
            return mtr[0, 0] * mtr[1, 1] - mtr[0, 1] * mtr[1, 0];
        }

        public Matrix getMinors()
        {
            double[,] res = new double[3, 3];
            for (int i = 0; i < _mtr.GetLength(0); i++)
            {
                for (int j = 0; j < _mtr.GetLength(1); j++)
                {
                    res[i, j] = get_Det_2(getMinor(i, j));
                }
            }
            return new Matrix(res);
        }

        private double[,] getMinor(int i, int j)
        {
            double[,] res = new double[2, 2];
            int ni = 0;
            for (int i1 = 0; i1 < _mtr.GetLength(0); i1++)
            {
                int nj = 0;
                for (int j1 = 0; j1 < _mtr.GetLength(1); j1++)
                {
                    if (i1 == i || j1 == j)
                        continue;
                    res[ni, nj] = _mtr[i1, j1];
                    nj++;
                }
                if (i1 != i)
                    ni++;
            }
            return res;

        }


        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < _mtr.GetLength(0); i++)
            {
                for (int j = 0; j < _mtr.GetLength(1); j++)
                {
                    res += $"{_mtr[i, j],6:f3} ";
                }
                res += "\n";
            }
            return res;
        }
    }
}
