using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExP_Dquan
{
    public class Vector
    {
        public string[] numbers;
        public int contador = 0;

        public void add(int VectorSize)
        {
            numbers = new string[VectorSize];
        }

        public void AddDataVector(string valor)
        {
            numbers[contador] = valor;
            contador++;
        }

        public string returnValue(int position)
        {
            return numbers[position];
        }

        public void cleanData()
        {
            contador = 0;
            for (int i = 0; i <= 9; i++)
            {
                numbers[i] = "";
            }
        }
    }
}
