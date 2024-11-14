using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SilinEV.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            int a = 0;
            string[] s = new string[a];

            foreach (string d in array)
            {
                if (d.Length == 7)
                {
                    a++;
                    Array.Resize(ref s, a);
                    s[a - 1] = d;
                }
            }

            return s;
        }
    }
}
