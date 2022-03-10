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
    /// Логика взаимодействия для PageRadar.xaml
    /// </summary>
    public partial class PageRadar : Page
    {
        public PageRadar()
        {
            InitializeComponent();
          

            double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

            Radar.Plot.AddRadar(values);

            // improve plot styling
            Radar.Plot.Frameless();
            Radar.Plot.Grid(enable: false);
            Radar.Refresh();
        }
    }
}
