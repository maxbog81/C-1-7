using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Богатов Максим
//1.	а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте  библиотечный обобщенный класс System.Collections.Generic.Stack<int>.
// Вся логика игры должна быть реализована в классе с удвоителем.


namespace lesson7
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            Enabl(false);            
        }
        Form2 form2;// обьявление обьекта второй формы
        Doubler doub = new Doubler();
        Stack<int> numbers = new Stack<int>();

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            numbers.Push(doub.CurVal);
            doub.IncrValBy1();
            doub.Step++;
            StepLabelNum.Text = doub.Step.ToString();
            lblNumber.Text = doub.CurVal.ToString();           

            Valid(doub.CurVal, doub.FinVal);
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            numbers.Push(doub.CurVal);
            doub.MultValBy2();
            doub.Step++;
            StepLabelNum.Text = doub.Step.ToString();
            lblNumber.Text = doub.CurVal.ToString();
            Valid(doub.CurVal, doub.FinVal);            

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            doub.ResetVal();            
            StepLabelNum.Text = doub.Step.ToString();
            lblNumber.Text = doub.CurVal.ToString();
            this.BackColor = SystemColors.Control;
            numbers.Clear();
            Enabl(true);
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            doub.FinVal = rnd.Next(2, 100);
            MessageBox.Show("Число кот.должен получить игрок: " + doub.FinVal.ToString(), "Игра началась!");
            FinishLabel.Text = doub.FinVal.ToString();
            btnReset_Click(sender, e);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (numbers.Count > 0)
            {
                int stackElement = numbers.Pop();
                doub.CurVal = stackElement;
                doub.Step--;
                StepLabelNum.Text = doub.Step.ToString();
                lblNumber.Text = doub.CurVal.ToString();
            }
        }

        /// <summary>
        /// Метод для проверки выигрыша или проигрыша
        /// </summary>
        /// <param name="cur">Текущее число</param>
        /// <param name="fin">Конечное число</param>

        private void Valid(int cur,int fin)
        {
            if (cur > fin)
            {
                MessageBox.Show("Вы проиграли!!!", "Конец игре!");
                this.BackColor = System.Drawing.Color.Red;
                Enabl(false);
            }
            if (cur == fin)
            {
                MessageBox.Show("Вы выиграли!!!", "Конец игре!");
                this.BackColor = System.Drawing.Color.Chocolate;
                Enabl(false);
            }
        }

        /// <summary>
        /// Метод для настройки доступности компонентов
        /// </summary>
        /// <param name="stat"></param>
        private void Enabl(bool stat)
        {
            btnCommand1.Enabled = stat;
            btnCommand2.Enabled = stat;
            btnReset.Enabled = stat;
            btnReverse.Enabled = stat;
        }

        private void MenuItemGusNum_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }
    }
}
