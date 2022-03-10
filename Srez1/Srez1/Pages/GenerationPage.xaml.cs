using MainClass;
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

namespace Srez1.Pages
{
    /// <summary>
    /// Логика взаимодействия для GenerationPage.xaml
    /// </summary>
    public partial class GenerationPage : Page
    {
        public GenerationPage()
        {
            InitializeComponent();
            tbSurname.Text = "Иванов";
            tbGroup.Text = "342";
            string[] marks1 = new string[] { "5", "4", "3", "4", "5", "н", "5","3","3" };
            tbAVG.Text = Class1.MinAVG(marks1).ToString();
        }

        private void btnGen_Click(object sender, RoutedEventArgs e)
        {
            NumSber.Text = Class1.GetStudentNumber(int.Parse(tbYear.Text), int.Parse(tbGR.Text), tbFIO.Text);
        }
    }
}
