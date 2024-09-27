using Lib_6;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void bt_Calc_Click(object sender, RoutedEventArgs e)
        {
            double calc, rnd, rez;
            calc = Class1.Lib_6(out rnd, out rez);// Успользуется библеотека Lib_6
            tb_RandomNumber.Text = Convert.ToString(rnd);// Выводит рандомное число
            tb_Rez.Text = Convert.ToString(rez);// Выводит результат подсчета
        }

        private void bt_Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил:Ермаков Павел ИСП-34 \nПрактическая работа№1" +
                "\nЗадание:Генерировать случайные числа Х, распределенные в диапазоне от -5 до 4 и вычислять для чисел > 0 X," +
                " а для чисел < 0 функцию x2. Вычисления прекратить, когда подряд появится два одинаковых случайных числа. На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках");
        }

        private void bt_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}