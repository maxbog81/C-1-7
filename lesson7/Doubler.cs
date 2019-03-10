using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте  библиотечный обобщенный класс System.Collections.Generic.Stack<int>.
// Вся логика игры должна быть реализована в классе с удвоителем.

namespace lesson7
{
    class Doubler
    {
        public Doubler()
        {
            //var rnd = new Random();
            this.Step = 0;
            this.CurVal = 1;
            //this.FinVal = rnd.Next(2,100);
        }

        public int CurVal { get; set; }
        public int FinVal { get; set; }
        public int Step { get; set; }

        public void IncrValBy1()
        {
            CurVal += 1;
        }
        public void MultValBy2()
        {
            CurVal *= 2;
        }
        public void ResetVal()
        {
            CurVal = 1;
            Step = 0;
        }

    }
}
