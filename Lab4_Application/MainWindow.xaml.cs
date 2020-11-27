using System;
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

            if (str1.Length == 3)
            {
                if (textBox1.Text == "" || (str1.Length > 3 || str1.Length < 2) || (char.IsLower(str1[0][0]))
                    || (char.IsLower(str1[1][0])) || (char.IsLower(str1[2][0])))
                    MessageBox.Show("В строке 'ФИО' ошибка");
            }
            else if (str1.Length == 2)
            {
                if (textBox1.Text == "" || (str1.Length > 3 || str1.Length < 2) || (char.IsLower(str1[0][0]))
                    || (char.IsLower(str1[1][0])))
                    MessageBox.Show("В строке 'ФИО' ошибка");
            }
            else MessageBox.Show("В строке 'ФИО' ошибка");
        }


        /// <summary> Кнопка Проверка Даты Рождения </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] str2 = textBox2.Text.Split('.');

            if (str2[0].Length != 2 || str2[1].Length != 2 || str2[2].Length != 4)
                MessageBox.Show("В строке 'Дата рождения' ошибка");
        }


        /// <summary> Кнопка Проверка Телефона </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string str3 = textBox3.Text;

            if (Convert.ToString(str3[0]) != "+")
            {
                try
                {
                    if (int.TryParse(str3, out int tel) && str3.Length == 11)
                        MessageBox.Show("Телефон введён верно");
                }
                catch (Exception)
                {
                    MessageBox.Show("Не верно введёт номер телефона");
                }
            }
            //if () return;
            //else 

            if (Convert.ToString(str3[0]) == "+")
            {
                str3 = str3.Replace(Convert.ToString(str3[0]), "0");
                MessageBox.Show("asd " + str3);

                try
                {
                    if (int.TryParse(str3, out int tel) && str3.Length == 12)
                        MessageBox.Show("Телефон введён верно");
                }
                catch (Exception)
                {
                    MessageBox.Show("Не верно введёт номер телефона");
                }
                

                
                //else MessageBox.Show("Не верно введёт номер телефона");
            }

        }


        /// <summary> Кнопка Проверка e-mail </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
