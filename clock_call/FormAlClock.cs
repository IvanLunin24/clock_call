using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock_call
{
    public partial class FormAlClock : Form
    {
        private int Music = 0;//играет музыка?
        private string NameFile = "";//путь до файла
        private string Hour = "";//берет часы
        private string Minutes = "";//берет минуты
        private string Seconds = "";//берет секунды

        private string HourNow = "";//берет системные часы
        private string MinutesNow = "";//берет системные минуты 
        private string SecondsNow = "";//берет системные секунды

        WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();//возпроизводить файлы mp3

        public FormAlClock()
        {
            InitializeComponent();

            timer1.Interval = 500;//запускать каждые пол секунды функцию timer1_Tick
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void FormAlClock_Load(object sender, EventArgs e)
        {
            Hour = DateTime.Now.Hour.ToString();//взять системные данные
            Minutes = DateTime.Now.Minute.ToString();
            Seconds = DateTime.Now.Second.ToString();

            if (Hour.Length == 1)//подставить 0 для единичных значений 
            {
                Hour = "0" + Hour;
            }
            if (Minutes.Length == 1)
            {
                Minutes = "0" + Minutes;
            }
            if (Seconds.Length == 1)
            {
                Seconds = "0" + Seconds;
            }

            textBox1.Text = Hour;//вывод информации в text_box
            textBox2.Text = Minutes;
            textBox3.Text = Seconds;

        }

        private void textBox1_Leave(object sender, EventArgs e)//подставиь 0 при вводе единичного значения
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0" + textBox1.Text;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                textBox2.Text = "0" + textBox2.Text;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                textBox3.Text = "0" + textBox3.Text;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))//ограничение ввода
            {
                if (textBox1.Text.Length >= 0 && textBox1.Text.Length <= 1)//только двухзначные значения 
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))//в textbox можно использовать только backspace
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox2.Text.Length >= 0 && textBox2.Text.Length <= 1)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox3.Text.Length >= 0 && textBox3.Text.Length <= 1)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void ButtonMusic_Click(object sender, EventArgs e)
        {
            string extension = "";

            if (Music == 0)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)//открыть диалоговое окно 
                {
                    NameFile = openFileDialog1.FileName;//путь до файла
                    extension = Path.GetExtension(NameFile);

                    if (extension != ".mp3")//расширение файла
                    {
                        MessageBox.Show("Файл должен иметь расширение mp3");
                        return;
                    }

                    ButtonMusic.Text = NameFile.Substring(0, 14) + "...";
                }
            }
            else
            {
                WMP.controls.stop();
                ButtonMusic.Text = NameFile.Substring(0, 14) + "...";
                Music = 0;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HourNow = DateTime.Now.Hour.ToString();//время сейчас
            MinutesNow = DateTime.Now.Minute.ToString();
            SecondsNow = DateTime.Now.Second.ToString();
                
            if (HourNow.Length == 1)//ноль слева(для нормального сравнния, единая система координат)
            {
                HourNow = "0" + HourNow;
            }
            if (MinutesNow.Length == 1)
            {
                MinutesNow = "0" + MinutesNow;
            }
            if (SecondsNow.Length == 1)
            {
                SecondsNow = "0" + SecondsNow;
            }

            if ((Hour == HourNow) && (Minutes == MinutesNow) && (Seconds == SecondsNow))//врямя системы совподает с времянем в textbox
            {
                WMP.URL = NameFile;//имя файла
                WMP.settings.volume = 100;//громкость
                WMP.controls.play();//михалыч заводи
            }
            Music = 1;//музыка играет
            ButtonMusic.Text = "Выключить Музыку";
        }

        private void ButtonOn_Click(object sender, EventArgs e)
        {
            {
                if (ButtonOn.Text == "Стоп")
                {
                    if (Music == 1)//нужно прекротить воспроизведение музыки
                    {
                        WMP.controls.stop();
                        ButtonMusic.Text = NameFile.Substring(0, 14) + "...";
                        Music = 0;
                    }
                    textBox1.ReadOnly = false;//разрешить редактировать поля
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;

                    timer1.Enabled = false;//выключить трек
                    ButtonOn.BackColor = Color.MintCream;//меняем кнопку к исходному состоянию
                    ButtonOn.Text = "Запустить";
                }
                else

                if (textBox1.Text == "")//поля пустые
                {
                    MessageBox.Show("Поле часы пусто");
                    return;
                }

                if (textBox2.Text == "")//поля пустые
                {
                    MessageBox.Show("Поле минуты пусто");
                    return;
                }

                if (textBox3.Text == "")//поля пустые
                {
                    MessageBox.Show("Поле секунды пусто");
                    return;
                }

                if (!(Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 23))//ввод от 0 до 23 
                {
                    MessageBox.Show("Некорректно указаны часы");
                    return;
                }
                if (!(Convert.ToInt32(textBox2.Text) >= 0 && Convert.ToInt32(textBox2.Text) <= 59))//ввод от 0 до 23 
                {
                    MessageBox.Show("Некорректно указаны минуты");
                    return;
                }
                if (!(Convert.ToInt32(textBox3.Text) >= 0 && Convert.ToInt32(textBox3.Text) <= 59))//ввод от 0 до 23 
                {
                    MessageBox.Show("Некорректно указаны секунды");
                    return;
                }

                if (ButtonMusic.Text == "Выбрать песню mp3")//файл mp3 невыбран
                {
                    MessageBox.Show("Выберете песню mp3");
                }
                else
                {
                    ButtonOn.BackColor = Color.LavenderBlush;//поменять цвеь кнопки
                    ButtonOn.Text = "Стоп";//смена текста кнопки

                    Hour = textBox1.Text;//значение выбранных полей
                    Minutes = textBox2.Text;
                    Seconds = textBox3.Text;

                    textBox1.ReadOnly = true;//запрет редактирования 
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;

                    timer1.Enabled = true;//таймер вкл
                }

            }

           
        }
    }
}
