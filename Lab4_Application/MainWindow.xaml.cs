﻿using System;
using System.Windows;

namespace Lab4_Application
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary> Кнопка Проверка ФИО </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] str1 = textBox1.Text.Split(' ');

            //str1 = Convert.ToString(str1).Trim();
            while (true)
            {
                if (str1[str1.Length - 1] == "")
                {
                    str1[2] = Convert.ToString(str1).Trim(new Char[] { ' ', '*', '.' });
                }
                else break;
            }

            if (str1.Length == 3)
            {
                //str1 = Convert.ToString(str1[2].Trim());
                if (textBox1.Text == "" || (str1.Length > 3 || str1.Length < 2) || (char.IsLower(str1[0][0]))
                    || (char.IsLower(str1[1][0])) || (char.IsLower(str1[2][0]))) MessageBox.Show("В строке 'ФИО' ошибка");
                else MessageBox.Show("В строке 'ФИО' нет ошибок");
            }
            else if (str1.Length == 2)
            {
                if (textBox1.Text == "" || (str1.Length > 3 || str1.Length < 2) || (char.IsLower(str1[0][0]))
                    || (char.IsLower(str1[1][0]))) MessageBox.Show("В строке 'ФИО' ошибка");
                else MessageBox.Show("В строке 'ФИО' нет ошибок");
            }
            else MessageBox.Show("В строке 'ФИО' ошибка");
        }




        /// <summary> Кнопка Проверка Телефона </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string str3 = textBox3.Text;

            if (str3.Length != 0)
            {
                if (Convert.ToString(str3[0]) != "+")
                {
                    bool success = long.TryParse(str3, out long tel);

                    if (success && str3.Length == 11) MessageBox.Show("Верно введён номер телефона");
                    else MessageBox.Show("Не верно введён номер телефона");
                }

                if (Convert.ToString(str3[0]) == "+")
                {
                    str3 = str3.Replace(Convert.ToString(str3[0]), "0");
                    //MessageBox.Show("asd " + str3);

                    bool success = long.TryParse(str3, out long tel);

                    if (success && str3.Length == 12) MessageBox.Show("Верно введён номер телефона");
                    else MessageBox.Show("Не верно введён номер телефона");
                }
            }
            else MessageBox.Show("Не верно введён номер телефона");
        }




        /// <summary> Кнопка Проверка Даты Рождения </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string str2 = textBox2.Text;

            while (true)
            {
                foreach (var ch in str2)
                {
                    if (ch == '.')
                    {
                        str2 = str2.Replace(ch, '0');
                    }
                }
                bool success = long.TryParse(str2, out long birth);

                if (!success)
                {
                    MessageBox.Show("В строке 'Дата рождения' ошибка");
                    break;
                }
                else MessageBox.Show("Дата Рождения введена корректно");

                string[] strSplit = textBox2.Text.Split('.');


                if ((strSplit[0].Length == 2 && strSplit[1].Length == 2 &&
                    strSplit[2].Length == 4)) MessageBox.Show("Дата рождения введена корректно");
                else MessageBox.Show("В строке 'Дата рождения' ошибка");

                //Дни
                if (!(Convert.ToInt32(strSplit[0]) > 31) &&
                    !(Convert.ToInt32(strSplit[0]) < 1)) MessageBox.Show("В строке 'Дата рождения' ошибка");
                else MessageBox.Show("Дата Рождения введена корректно");

                //Месяцы
                if (!(Convert.ToInt32(strSplit[1]) > 12) &&
                    !(Convert.ToInt32(strSplit[1]) < 1)) MessageBox.Show("В строке 'Дата рождения' ошибка");
                else MessageBox.Show("Дата Рождения введена корректно");

                //Года
                if (!(Convert.ToInt32(strSplit[2]) > 2020) &&
                    !(Convert.ToInt32(strSplit[2]) < 1900)) MessageBox.Show("В строке 'Дата рождения' ошибка");
                else MessageBox.Show("Дата Рождения введена корректно");

                break;
            }
        }




        /// <summary> Кнопка Проверка e-mail </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string strMail = textBox4.Text;
            string mailWord = "mail.ru";
            int countDog = 0;

            while (true)
            {
                foreach (var ch in strMail) if (ch == '@' && strMail[0] != '@' &&
                        strMail[strMail.Length - 1] != '@') countDog++;
                if (countDog != 1)
                {
                    MessageBox.Show("E-mail введён не корректно");
                    break;
                }
                else MessageBox.Show("E-mail введён корректно");

                int a = strMail.IndexOf(mailWord);

                if (a < 0) MessageBox.Show("E-mail введён не корректно");
                else MessageBox.Show("E-mail введён корректно");



                break;
            }
        }
    }
}
