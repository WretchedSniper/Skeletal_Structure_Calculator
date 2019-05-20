using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeletal_Structure_Calculator
{
    class Calculator
    {
        public int ND { get; set; }
        public int NF { get; set; }
        public int NP { get; set; }
        public int NE { get; set; }
        public int NM { get; set; }
        public int NR { get; set; }
        public int[] NAE { get; set; }
        public double[] EE { get; set; }
        public double[] AA { get; set; }
        public double[] X { get; set; }
        public double[] Y { get; set; }
        public double[] Z { get; set; }
        public int[][] ME { get; set; }
        public int[] NRR { get; set; }
        public double[] P { get; set; }
        public double[] P1 { get; private set; }
        public int[] LD { get; private set; }
        public double[] AK { get; private set; }
        public double[,] Fee { get; private set; }
        public double[,] Dee { get; private set; }
        public double[,] F { get; private set; }
        public double[] PP { get; private set; }
        public double[] SG { get; private set; }
        private double x1, x2, y1, y2, z1, z2, L, E, A;
        private double[,] KE, T, TT, K;
        private int[] IS;
        public void SolveProblem()
        {
            P1 = new double[NP * NF];
            Array.Copy(P, P1, P.Length);
            StructureMatrix();
            Cholesky();
            InternalForce();
        }
        private void MatrixK(int id)
        {
            x1 = X[ME[0][id - 1] - 1];
            x2 = X[ME[1][id - 1] - 1];
            y1 = Y[ME[0][id - 1] - 1];
            y2 = Y[ME[1][id - 1] - 1];
            z1 = Z[ME[0][id - 1] - 1];
            z2 = Z[ME[1][id - 1] - 1];
            L = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            E = EE[NAE[id - 1] - 1];
            A = AA[NAE[id - 1] - 1];
            KE = new double[2, 2] { { E * A / L, -E * A / L }, { -E * A / L, E * A / L } };
            T = new double[2, 6] { { (x2 - x1) / L, (y2 - y1) / L, (z2 - z1) / L, 0, 0, 0 }, { 0, 0, 0, (x2 - x1) / L, (y2 - y1) / L, (z2 - z1) / L } };
            TT = new double[6, 2] { { (x2 - x1) / L, 0 }, { (y2 - y1) / L, 0 }, { (z2 - z1) / L, 0 }, { 0, (x2 - x1) / L }, { 0, (y2 - y1) / L }, { 0, (z2 - z1) / L } };
            K = new double[6, 6];
            double[,] temp = new double[6, 2];
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 2; ++j)
                {
                    temp[i, j] = 0;
                    for (int k = 0; k < 2; ++k)
                        temp[i, j] += TT[i, k] * KE[k, j];
                }
            for (int i = 0; i < 6; ++i)
                for (int j = 0; j < 6; ++j)
                {
                    K[i, j] = 0;
                    for (int k = 0; k < 2; ++k)
                        K[i, j] += temp[i, k] * T[k, j];
                }
        }
        private void MatrixLD()
        {
            LD = new int[NP * NF];
            for (int k = 0; k < NP; ++k)
            {
                int Nmin = k;
                for (int i = 0; i < NE; ++i)
                    for (int j = 0; j < ND; ++j)
                        if (ME[j][i] - 1 == k)
                            for (int l = 0; l < ND; ++l)
                                Nmin = Math.Min(Nmin, ME[l][i] - 1);
                for (int i = 0; i < NF; ++i)
                {
                    int J = NF * k + i;
                    if (J != 0)
                        LD[J] = LD[J - 1] + NF * (k - Nmin) + i + 1;
                }
            }
        }
        private void MatrixIS(int id)
        {
            IS = new int[6];
            IS[0] = (ME[0][id - 1] - 1) * NF;
            IS[1] = (ME[0][id - 1] - 1) * NF + 1;
            IS[2] = (ME[0][id - 1] - 1) * NF + 2;
            IS[3] = (ME[1][id - 1] - 1) * NF;
            IS[4] = (ME[1][id - 1] - 1) * NF + 1;
            IS[5] = (ME[1][id - 1] - 1) * NF + 2;
        }
        private void StructureMatrix()
        {
            MatrixLD();
            AK = new double[LD[LD.Length - 1] + 1];
            for (int id = 1; id < NE + 1; ++id)
            {
                MatrixK(id);
                MatrixIS(id);
                for (int i = 0; i < NF * ND; ++i)
                    for (int j = 0; j < NF * ND; ++j)
                        if (IS[i] >= IS[j])
                        {
                            int POS = LD[IS[i]] - (IS[i] - IS[j]);
                            AK[POS] += K[i, j];
                        }
            }
            for (int i = 0; i < NR; ++i)
            {
                int POS = LD[NRR[i] - 1];
                AK[POS] = 1e25;
            }
        }
        private void Cholesky()
        {
            int starti, startj, POS, mij, mi, mj;
            for (int i = 0; i < NP * NF; ++i)
            {
                if (i > 0)
                {
                    mi = i - (LD[i] - LD[i - 1]) + 1;
                    if (mi < i)
                    {
                        starti = LD[i] - i;
                        for (int j = mi; j < i; ++j)
                        {
                            if (j > mi)
                            {
                                mj = j - (LD[j] - LD[j - 1]) + 1;
                                POS = LD[i] - (i - j);
                                mij = Math.Max(mi, mj);
                                startj = LD[j] - j;
                                if (mij < j)
                                    for (int k = mij; k < j; ++k)
                                        AK[POS] -= AK[starti + k] * AK[LD[k]] * AK[startj + k];
                            }
                            else
                                POS = LD[i - 1] + 1;
                            AK[POS] /= AK[LD[j]];
                            P[i] -= AK[POS] * AK[LD[j]] * P[j];
                        }
                        for (int k = mi; k < i; ++k)
                            AK[LD[i]] -= AK[starti + k] * AK[starti + k] * AK[LD[k]];
                    }
                }
                P[i] /= AK[LD[i]];
            }
            for (int i = NP * NF - 1; i > 0; --i)
            {
                mi = i - (LD[i] - LD[i - 1]) + 1;
                if (mi == i)
                    continue;
                starti = LD[i] - i;
                for (int k = mi; k < i; ++k)
                    P[k] -= AK[starti + k] * P[i];
            }
        }
        private void InternalForce()
        {
            Fee = new double[NE, ND];
            Dee = new double[NE, ND];
            F = new double[NE, NF * ND];
            PP = new double[NP * NF];
            SG = new double[NE];
            for (int id = 1; id < NE + 1; ++id)
            {
                MatrixK(id);
                MatrixIS(id);
                for (int j = 0; j < 2; ++j)
                {
                    Dee[id - 1, j] = 0;
                    for (int k = 0; k < 6; ++k)
                        Dee[id - 1, j] += P[IS[k]] * TT[k, j];
                }
                for (int j = 0; j < 2; ++j)
                {
                    Fee[id - 1, j] = 0;
                    for (int k = 0; k < 2; ++k)
                        Fee[id - 1, j] += Dee[id - 1, k] * KE[j, k];
                }                
                SG[id - 1] = Fee[id - 1,1] / A;
                for (int j = 0; j < 6; ++j)
                {
                    F[id - 1, j] = 0;
                    for (int k = 0; k < 2; ++k)
                        F[id - 1, j] += Fee[id - 1, k] * T[k, j];
                }
                for (int k = 0; k < NF * ND; ++k)
                    PP[IS[k]] += F[id - 1, k];
            }
            for (int i = 0; i < NP * NF; ++i)
                P1[i] = PP[i] - P1[i];
        }
    }
}