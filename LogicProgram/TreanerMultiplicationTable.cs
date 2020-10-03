using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable.LogicProgram
{
    
    /// <summary>
    /// Класс где объекты обладают полным набором методов для создания тернажера таблицы умножения
    /// </summary>
    class TreanerMultiplicationTable
    {
        Random randomDigits = new Random();

        public int x { get; set; }
        public int y { get; set; }
        public int result { get; set; }

        public TreanerMultiplicationTable() { }


        /// <summary>
        /// Метод генерирующий случайное число из диапазона который нужно указать в аргументах
        /// </summary>
        /// <returns></returns>
        public int GeneratingRandomNumbers(int x, int y)
        {
            int res = randomDigits.Next(x, y);
            
            return res;
        }




    }
}
