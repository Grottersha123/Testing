using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Вывести массив из 10 целых положительных чисел Вывести количество чисел массива , у которых максимальная цивра равна 7
//и средне арифмитическое этих чисел меньше 7, если таких элементов нет то вывести сообщения об этом
namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox2.Text;
            //MessageBox.Show(text);
            String result = "";
            if (Module1.CheckCountDigit(text) && Module1.PositiveDigits(text))
            {
                result = Module2.NumberWithOptions(text);
               // MessageBox.Show(Module2.CheckSeven(text).ToString());
               // MessageBox.Show(Module2.CheckSevenAverage(text).ToString());
                if (result != "")
                {
                    textBox1.Text = result;
                }
                else
                {
                    MessageBox.Show("Таких чисел нет");
                    //Module2.NumberWithOptions(text);
                }
            }
            else
            {
                MessageBox.Show("Неправильно введена строка нужно чтобы было 10 положительных цифр введнных через пробел");
              // MessageBox.Show(Module1.CheckCountDigit(text).ToString());
               //MessageBox.Show(Module1.checkStrLength(text).ToString());
                //MessageBox.Show(Module1.PositiveDigits(text).ToString());


            }

        }
        public class Module2
        {
            public static Boolean CheckSeven(String s) // Подсчет слов , у которых нечетное количество сиволов и если их больше 3 то тру
            {
                
                //Char delimiter = ' ';
                //String[] substrings = s.Split(delimiter);// делим строку по пробелам
                int max = 0;
                Char[] t = s.ToCharArray(0, s.Length);
                foreach(var i in t)
                {
                    int number = int.Parse(i.ToString());
                    if ( max < number)
                        max = number;
                        
                }
               //MessageBox.Show(max.ToString());

                if (max == 7)
                {
                    return true;
                }
                return false;
            }
            public static void CheckSeven1(String s) // Подсчет слов , у которых нечетное количество сиволов и если их больше 3 то тру
            {

                //Char delimiter = ' ';
                //String[] substrings = s.Split(delimiter);// делим строку по пробелам
                int max = 0;
                Char[] t = s.ToCharArray(0, s.Length);
                foreach (var i in t)
                {
                    int number = int.Parse(i.ToString());
                    //MessageBox.Show(number.ToString());
                    if (max < number)
                        max = number;

                }
               // MessageBox.Show(max.ToString());

              
            }


            public static Boolean CheckSevenAverage(String s) // Подсчет слов , у которых нечетное количество сиволов и если их больше 3 то тру
            {
        
                int sum = 0;
                foreach (var t in s)
                {
                    int number = int.Parse(t.ToString());
                    sum += number;

                }
                sum = sum / 4;
                if (sum < 7)
                {
                    return true;
                }
                return false;
            }

            public static  String NumberWithOptions(String s) // Подсчет слов , у которых нечетное количество сиволов и если их больше 3 то тру
            {
                Boolean result = false;
                Char delimiter = ' ';
                String[] substrings = s.Split(delimiter);// делим строку по пробелам
                String str = "";
                int sum = 0;
                foreach (var t in substrings)
                {
                    if (CheckSeven(t) && CheckSevenAverage(t))
                    {
                        //MessageBox.Show(CheckSeven(t).ToString());
                        //MessageBox.Show(CheckSevenAverage(t).ToString());
                        str +=" " + t;
                    }
            
                }
                return str;
                
                
            }
        }
        public class Module1 // Модуль один на проверку количества символов в строке, строки должны быть меньше 30,
        {
            public static Boolean checkStrLength(String s)
            {
                if (s.Length < 55)
                    return true;
                else
                    return false;

            }
       

            public static Boolean CheckCountDigit(String s) // Подсчет слов , у которых нечетное количество сиволов и если их больше 3 то тру
            {
                Boolean result = false;
                Char delimiter = ' ';
                String[] substrings = s.Split(delimiter);// делим строку по пробелам
               // MessageBox.Show(substrings.ToString());
                foreach (var t in substrings)
                {
                   // MessageBox.Show(t);
                    if (t.Length != 4)
                        return false;
                }

                return true;
            }

            public static Boolean PositiveDigits(String s) // Положительные ли числа
            {
                Char delimiter = ' ';
                String[] substrings = s.Split(delimiter);// делим строку по пробелам
                foreach (var t in substrings)
                {
                    int number = int.Parse(t);
                 //   MessageBox.Show(number.ToString());

                    if (number < 0)
                        return false;
                }

                return true;
            }
            // Написать программу по определнию есть ли сиволы в строке или удаление символов в строке
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String lol = textBox1.Text;
            Module2.CheckSeven1(lol);
            
        }
    }
}
