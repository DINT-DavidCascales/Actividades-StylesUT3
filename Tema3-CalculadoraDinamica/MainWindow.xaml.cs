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
            int numBoton=1;
            
            for (int i = 1; i <= 3; i++)
            {

                for (int j = 0; j <=2 ; j++)
                {
                    TextBlock t1 = new TextBlock();
                    Viewbox v1 = new Viewbox();
                    Button btn = new Button();

                    t1.Text = $"{numBoton}";
                    btn.Tag = $"{numBoton}";
                    btn.Margin = new Thickness(12);
                    v1.Child = t1;
                    btn.Content = v1;

                    btn.Click += Button_Click;

                    Grid.SetColumn(btn, j);
                    Grid.SetRow(btn, i);
                    gridPrincipal.Children.Add(btn);
                    numBoton++;
                }
            }

           
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String boton = (sender as Button).Tag.ToString();
            numeros.Text += boton;

        }

        
    }
}
