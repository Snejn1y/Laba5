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

namespace Laba5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tabul = new Tabul();
            tabul.GetList(Convert.ToDouble(Start.Text), Convert.ToDouble(End.Text), Convert.ToDouble(Crock.Text));
            list.Items.Clear();

            for(int i = 0; i < tabul.tabul.Count; i++)
            {
                list.Items.Add( "x= " + Math.Round(tabul.tabul[i].X, 3) + 
                                " y= " + Math.Round(tabul.tabul[i].Y, 3) + 
                                " For = " + Math.Round(tabul.tabul[i].Y_for, 3) + 
                                " Rek= " + Math.Round(tabul.tabul[i].Y_rek, 3));
            }
        }
    }
}
