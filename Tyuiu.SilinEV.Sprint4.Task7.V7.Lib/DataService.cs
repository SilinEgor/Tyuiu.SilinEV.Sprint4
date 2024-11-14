using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SilinEV.Sprint4.Task7.V7.Lib
{
    public class DataService : ISprint4Task7V7
    {
        public int Calculate(int n, int m, string value)
        {
            int a = 0;
            int[,] s = new int[4, 2];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int d = Convert.ToInt32(value[i * 2 + j]);
                    s[i, j] = d;
                    if (d % 2 == 1) a++;
                }
            }

            return a;
        }
    }
}
