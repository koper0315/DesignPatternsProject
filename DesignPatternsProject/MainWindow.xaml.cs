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

namespace DesignPatternsProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CoffeeBuilder builder;
        CoffeeMaker coffeemaker = new CoffeeMaker();
        int selectedbutton = 1;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void SelectButton(Button button)
        {
            button_esspresso.Background = Brushes.DarkGray;
            button_cappuccino.Background = Brushes.DarkGray;
            button_latte.Background = Brushes.DarkGray;
            button_lattemacchiato.Background = Brushes.DarkGray;
            button_caffeeamericano.Background = Brushes.DarkGray;
            button.Background = Brushes.Yellow;
        }

        private void button_esspresso_Click(object sender, RoutedEventArgs e)
        {
            SelectButton(button_esspresso);
        }
        private void button_cappuccino_Click(object sender, RoutedEventArgs e)
        {
            SelectButton(button_cappuccino);
            selectedbutton = 2;
        }

        private void button_latte_Click(object sender, RoutedEventArgs e)
        {
            SelectButton(button_latte);
            selectedbutton = 3;
        }

        private void button_lattemacchiato_Click(object sender, RoutedEventArgs e)
        {
            SelectButton(button_lattemacchiato);
            selectedbutton = 4;
        }

        private void button_caffeeamericano_Click(object sender, RoutedEventArgs e)
        {
            SelectButton(button_caffeeamericano);
            selectedbutton = 5;
        }

        private void button_pay_Click(object sender, RoutedEventArgs e)
        {
            int price = 0;
            string coffee_type = null;
            switch (selectedbutton)
            {
                case 1:
                    builder = new EspressoBuilder();
                    coffeemaker.Cook(builder);
                    price = builder.Coffee.GetPrice();
                    coffee_type = builder.Coffee.GetCoffeeType();
                    break;
                case 2:
                    builder = new CappuccinoBuilder();
                    coffeemaker.Cook(builder);
                    price = builder.Coffee.GetPrice();
                    coffee_type = builder.Coffee.GetCoffeeType();
                    break;
                case 3:
                    builder = new LatteBuilder();
                    coffeemaker.Cook(builder);
                    price = builder.Coffee.GetPrice();
                    coffee_type = builder.Coffee.GetCoffeeType();
                    break;
                case 4:
                    builder = new LatteMacchiatoBuilder();
                    coffeemaker.Cook(builder);
                    price = builder.Coffee.GetPrice();
                    coffee_type = builder.Coffee.GetCoffeeType();
                    break;
                case 5:
                    builder = new CaffeeAmericanoBuilder();
                    coffeemaker.Cook(builder);
                    price = builder.Coffee.GetPrice();
                    coffee_type = builder.Coffee.GetCoffeeType();
                    break;
            }
            window_pay pay_window = new window_pay();
            pay_window.Show();
            SingletonDB db = SingletonDB.GetInstance();
            db.Logger("type: " + coffee_type + ", price: " + price);
        }
    }
}
