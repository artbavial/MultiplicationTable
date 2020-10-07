using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable.LogicProgram
{

    /// <summary>
    /// Класс где объекты обладают полным набором методов для создания тернажера таблицы умножения
    /// </summary>
    class TreanerMultiplicationTable
    {
        Random randomDigits = new Random();

        public string timerstring { get; set; }
        public int x_num { get; set; }
        public int y_num { get; set; }
        public int result { get; set; }
        

        public TreanerMultiplicationTable() { }


        /// <summary>
        /// Метод генерирующий случайные числа для двух Label контролов из диапазона который нужно указать в первых двух аргументах. Метод также задает сгенерированные значение полям x_num и y_num
        /// </summary>
        /// <returns></returns>
        public void GeneratingRandomNumbers(int x, int y, Label lx, Label ly)
        {
            x = randomDigits.Next(x, y);
            x_num = x;
            lx.Text = x.ToString();

            y = randomDigits.Next(x, y);
            y_num = y;
            ly.Text = y.ToString();

        }




    }
}
