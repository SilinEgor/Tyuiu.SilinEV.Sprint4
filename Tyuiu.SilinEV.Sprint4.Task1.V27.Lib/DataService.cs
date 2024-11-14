using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SilinEV.Sprint4.Task1.V27.Lib
{
    public class DataService : ISprint4Task1V27
    {
        public int Calculate(int[] array)
        {
            int a = 1;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    a *= i;
                }
            }

            return a;
        }
    }
}
