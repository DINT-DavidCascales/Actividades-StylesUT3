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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock t1=new TextBlock();
            Viewbox v1= new Viewbox(); 
            Button btn1= new Button();

            t1.Text = "1";
            btn1.Tag = "1";
            btn1.Margin = new Thickness(12);
            v1.Child = t1;
            btn1.Content = v1;

            btn1.Click += Button_Click;

            Grid.SetColumn(btn1,0);
            Grid.SetRow(btn1,1);
           gridPrincipal.Children.Add(btn1);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String boton = (sender as Button).Tag.ToString();
            numeros.Text += boton;

        }

        
    }
}
