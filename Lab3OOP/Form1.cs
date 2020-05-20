using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lode_Runner;
using Lode_Runner.Models;

namespace Lab3OOP
{
    public partial class Form1 : Form
    {
        private Cell[,] _field;

        private string[] words = new[] {"Coin", "Door", "EmptyCell", "Ladder", "Platform", "Player", "Wall"};
        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;
            _field = GameField.CreateField();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = Controls.Find("textBox1" , false)[0].Text;

        }

        private int CountElementsY(string elem, int col)
        {
            int counter = 0;
            if (!(words.Contains(elem)) || col > _field.GetLength(0) || col<0)
            {
                throw new Exception("Введено недопустимое слово и/или недопустимое значение номера ряда");
            }
            for (int j = 0; j < _field.GetLength(0); j++)
            {
                if (_field[j, col].GetType().Name == elem)
                {
                    counter++;
                }
            }
            return counter;
        }
        private int CountElementsX(string elem, int row)
        {
            int counter = 0;
            if (!(words.Contains(elem)) || row > _field.GetLength(1) || row<0)
            {
                throw new Exception("Введено недопустимое слово и/или недопустимое значение номера строки");
            }
            for (int j = 0; j < _field.GetLength(1); j++)
            {
                if (_field[row,j].GetType().Name == elem)
                {
                    counter++;
                }
            }
            return counter;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            Controls.Clear();
            Button button2 = new Button();
            button2.Location = new Point(30, 20);
            button2.Text = "Назад";
            button2.Size = new Size(130, 40);
            button2.Click += GoBack;
            Controls.Add(button2);
            Panel panel = new Panel();
            int counterForY = 70;
            for (int i = 0; i < _field.GetLength(0); i++)
            {
                int counterForX = 20;
                for (int j = 0; j < _field.GetLength(1); j++)
                {
                    Cell cell = _field[i, j].Clone();
                    cell.CellView.Visible = true;
                    cell.CellView.Show();
                    cell.CellView.ClientSize = new Size(50, 60);
                    cell.CellView.Location = new Point(counterForX, counterForY);
                    panel.Controls.Add(cell.CellView);
                    counterForX += 85;
                }
                counterForY += 80;
            }
            this.AutoScroll = true;
            panel.AutoScroll = true;
            panel.Size = new Size(5000, 5000);
            panel.AutoScroll = true;
            panel.Show();
            Controls.Add(panel);
        }

        private void ShowX(object sender, EventArgs e)
        {
            string val = Controls.Find("InputForElementName", false)[0].Text;
            string val2 = Controls.Find("InputForRows", false)[0].Text;
            int result = -1;
            try
            {
               result = CountElementsX(val, Convert.ToInt32(val2));
            }
            catch(Exception ex)
            {
                if (ex.Message == "Входная строка имела неверный формат.")
                {
                    MessageBox.Show("Значение строки должно быть цифровым");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (result!=-1)
            {
                MessageBox.Show(result.ToString());
            }
        }
        private void ShowY(object sender, EventArgs e)
        {
            string val = Controls.Find("InputForElementName", false)[0].Text;
            string val2 = Controls.Find("InputForCols", false)[0].Text;
            int result = -1;
            try
            {
                result = CountElementsY(val, Convert.ToInt32(val2));
            }
            catch (Exception ex)
            {
                if (ex.Message == "Входная строка имела неверный формат.")
                {
                    MessageBox.Show("Значение строки должно быть цифровым");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (result != -1)
            {
                MessageBox.Show(result.ToString());
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Label label = new Label();
            label.Text =
                "Вводить можно только такие названия элементов: \"Coin\", \"Door\", \"EmptyCell\", \"Ladder\", \"Platform\", \"Player\", \"Wall\"";
            label.Location = new Point(100,20);
            label.Size = new Size(700,20);
            Controls.Add(label);
            TextBox textbox = new TextBox();
            textbox.Name = "InputForRows";
            textbox.Text = "Введите номер строки для поиска";
            textbox.Location = new Point(300, 40);
            textbox.Size = new Size(200, 150);
            Controls.Add(textbox);
            TextBox textbox2 = new TextBox();
            textbox2.Name = "InputForElementName";
            textbox2.Text = "Введите название элемента";
            textbox2.Location = new Point(300, 77);
            textbox2.Size = new Size(200, 150);
            Controls.Add(textbox2);
            Button button = new Button();
            button.Text = "Посчитать";
            button.Location = new Point(340, 100);
            button.Size = new Size(130, 40);
            button.Click += ShowX;
            Controls.Add(button);
            Button button2 = new Button();
            button2.Location = new Point(20, 300);
            button2.Text = "Назад";
            button2.Size = new Size(130, 40);
            button2.Click += GoBack;
            Controls.Add(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Label label = new Label();
            label.Text =
                "Вводить можно только такие названия элементов: \"Coin\", \"Door\", \"EmptyCell\", \"Ladder\", \"Platform\", \"Player\", \"Wall\"";
            label.Location = new Point(100, 20);
            label.Size = new Size(700, 20);
            Controls.Add(label);
            TextBox textbox = new TextBox();
            textbox.Name = "InputForCols";
            textbox.Text = "Введите номер ряда для поиска";
            textbox.Location = new Point(300, 40);
            textbox.Size = new Size(200, 150);
            Controls.Add(textbox);
            TextBox textbox2 = new TextBox();
            textbox2.Name = "InputForElementName";
            textbox2.Text = "Введите название элемента";
            textbox2.Location = new Point(300, 77);
            textbox2.Size = new Size(200, 150);
            Controls.Add(textbox2);
            Button button = new Button();
            button.Text = "Посчитать";
            button.Location = new Point(340, 100);
            button.Size = new Size(130, 40);
            button.Click += ShowY;
            Controls.Add(button);
            Button button2 = new Button();
            button2.Location = new Point(20, 300);
            button2.Text = "Назад";
            button2.Size = new Size(130, 40);
            button2.Click += GoBack;
            Controls.Add(button2);
        }
    }
}
