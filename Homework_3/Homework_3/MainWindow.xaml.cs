using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework_3
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

        

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            char[] glasnie = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
            char[] soglasnie = new char[46] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ь' };
            string str = tbA.Text;
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glasnie.Length; j++)
                {
                    if (glasnie[j] == str[i]) { count1++; }
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < soglasnie.Length; j++)
                {
                    if (soglasnie[j] == str[i]) { count2++; }
                }
            }

           


            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            char[] glasnie = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
            char[] soglasnie = new char[46] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ь' };
            string str = tbA.Text;
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glasnie.Length; j++)
                {
                    if (glasnie[j] == str[i]) { count1++; }
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < soglasnie.Length; j++)
                {
                    if (soglasnie[j] == str[i]) { count2++; }
                }
            }

            int selection = Combo.SelectedIndex;
            int result = 0;
            switch (selection)
            {
                case 0:
                    result = count1;
                    break;
                case 1:
                    result = count2;
                    break;
            }
            tbResult.Text = String.Format("{0}", result);






        }
    }
}
