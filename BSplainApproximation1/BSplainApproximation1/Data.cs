using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Mode
{
    Star,
    Standard,
    NotEquidistant
}

namespace BSplainApproximation1
{
    class Data
    {
        public Mode mode;
        public List<double> t;
        public List<double> p;
        public List<List<double[,]>> GammaMatrix = new List<List<double[,]>>();
        public List<List<double>> GammaMult = new List<List<double>>();

        public Data()
        {
            t = new List<double>();
            p = new List<double>();
            DefineGamma();
        }

        void DefineGamma()
        {
            while (GammaMatrix.Count > 0)
            {
                while (GammaMatrix[0].Count > 0)
                {
                    GammaMatrix[0].RemoveAt(0);
                    GammaMult[0].RemoveAt(0);
                }
                GammaMatrix.RemoveAt(0);
                GammaMult.RemoveAt(0);
            }
            GammaMatrix.Add(new List<double[,]>());
            GammaMult.Add(new List<double>());
            GammaMatrix[0].Add(new double[,] { { 1 } });
            GammaMult[0].Add(1);
            ////////
            GammaMatrix.Add(new List<double[,]>());
            GammaMult.Add(new List<double>());
            GammaMatrix[1].Add(new double[,] { { 1, -1 }, { 1, 1 } });
            GammaMult[1].Add(0.5);
            ////////
            GammaMatrix.Add(new List<double[,]>());
            GammaMult.Add(new List<double>());
            GammaMatrix[2].Add(new double[,] { { 1,-2, 1 },
                                               { 6, 0,-2 },
                                               { 1, 2, 1 } });
            GammaMult[2].Add(0.125);
            GammaMatrix[2].Add(new double[,] { { -1,2,-1 },
                                               { 2,-16,10 },
                                               { 46,0,-18},
                                               { 2,16,10},
                                                { -1,-2,-1} });
            GammaMult[2].Add(1d/48);
            GammaMatrix[2].Add(new double[,] { { 1,-2,1 },
                                               { -4,20,-12 },
                                               { -5,-106,75},
                                               { 304,0,-128},
                                               {-5,106,75},
                                                { -4,-20,-12},
                                                { 1,2,1}});
            GammaMult[2].Add(1d / 288);
            ////////
            GammaMatrix.Add(new List<double[,]>());
            GammaMult.Add(new List<double>());
            GammaMatrix[3].Add(new double[,] { { 1,-3, 3, -1 },
                                               { 23,-15,-3,3 },
                                               { 23,15,-3,-3 },
                                               { 1,3,3,1} });
            GammaMult[3].Add(1d/48);
            GammaMatrix[3].Add(new double[,] { {-5,15,-15,5},
                                               { -81,-27,117,-49 },
                                               { 662,-570,-102,122},
                                               { 662,570,-102,-122},
                                                { -81,27,117,49 },
                                                 {-5,-15,-15,-5}});
            GammaMult[3].Add(1d / 1152);
            GammaMatrix[3].Add(new double[,] { {47,-141,141,-47},
                                               { 653,579,-1425,569 },
                                               { -6849,1383,6885,-3339},
                                               { 33797,-33705,-5601,7501},
                                                { 33797,33705,-5601,-7501},
                                                 { -6849,-1383,6885,3339},
                                                { 653,-579,-1425,-569 },
                                                {47,141,141,47}});
            GammaMult[3].Add(1d / 55296);
            ////////
            GammaMatrix.Add(new List<double[,]>());
            GammaMult.Add(new List<double>());
            GammaMatrix[4].Add(new double[,] { { 1, -4,6,-4,1 },
                                               { 76,-88,24,8,-4},
                                               { 230,0,-60,0,6 },
                                                { 76,88,24,-8,-4},
                                                { 1,4,6,4,1} });
            GammaMult[4].Add(1d / 384);
            GammaMatrix[4].Add(new double[,] { {-1,4,-6,4,-1 },
                                               { -70,64,12,-32,10},
                                               { 225,-524,198,52,-31 },
                                                { 1228,0,-408,0,44},
                                                { 225,524,198,-52,-31},
                                                  { -70,-64,12,32,10},
                                                {-1,-4,-6,-4,-1}
            });
            GammaMult[4].Add(1d / 1536);
            GammaMatrix[4].Add(new double[,] { {13,-52,78,-52,13},
                                               { 876,-696,-360,552,-164},
                                               {-5084,8104,-840,-2648,964},
                                                { 8404,-36952,16872,3848,-2588},
                                                { 83742,0,-31500,0,3550},
                                                  { 8404,36952,16872,-3848,-2588},
                                                {-5084,-8104,-840,2648,964},
                                                { 876,696,-360,-552,-164},
                                                {13,52,78,52,13}

            });
            GammaMult[4].Add(1d / 92160);
            /////
            GammaMatrix.Add(new List<double[,]>());
            GammaMult.Add(new List<double>());
            GammaMatrix[5].Add(new double[,] { {1,-5,10,-10,5,-1},
                                               { 237,-375,210,-30,-15,5},
                                               { 1682,-770, -220,140,10,-10},
                                                { 1682,770,-220,-140,10,10},
                                                { 237,375,210,30,-15,-5},
                                                { 1,5,10,10,5,1} });
            GammaMult[5].Add(1d / 3840);
        }

        public void Clear()
        {
            t.Clear();
            p.Clear();
        }

        public void SortByT()
        {
            int i, j;
            double temp;
            for (i = 0; i < t.Count; i++)
            {
                for (j = 0; j < t.Count - 1 - i; j++)
                {
                    if (t[j] > t[j + 1])
                    {
                        temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                        temp = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = temp;
                    }
                }
            }
        }
    }
}
