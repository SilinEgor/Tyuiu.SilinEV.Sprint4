using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SilinEV.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int a = 0;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[4, i] > a)
                {
                    a = array[4, i];
                }
            }

            return a;
        }
    }
}
