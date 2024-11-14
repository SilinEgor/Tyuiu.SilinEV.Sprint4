using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SilinEV.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            int a = 1;

            foreach (int i in array)
            {
                if (i % 2 == 1)
                {
                    a *= i;
                }
            }

            return a;
        }
    }
}
