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
using System.Windows.Shapes;

namespace MVVMExample
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ((MVVMExample.ModelView.HolesViewModel)Detail.DataContext).CurrentHole.Stemming += 1;
        }

        private void ToogleButton2_Checked(object sender, RoutedEventArgs e)
        {
            Detail.FurosList.AllHoles.Add(
                new Model.HolesModel()
                {
                    NumeroID = "17",
                    Length = 5,
                    Stemming = 0
                });
        }

        private void ToogleButton2_Unchecked(object sender, RoutedEventArgs e)
        {

            Detail.FurosList.AllHoles.RemoveAt(Detail.FurosList.AllHoles.Count - 1);
        }
    }
}
