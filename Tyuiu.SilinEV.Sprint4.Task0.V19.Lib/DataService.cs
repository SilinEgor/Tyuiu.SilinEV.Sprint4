using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SilinEV.Sprint4.Task0.V19.Lib
{
    public class DataService : ISprint4Task0V19
    {
        public int GetMultOddArrEl(int[] array)
        {
            int a = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    a *= array[i];
                }
            }

            return a;
        }
    }
}
