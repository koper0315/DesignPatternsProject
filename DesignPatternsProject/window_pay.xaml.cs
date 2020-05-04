using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesignPatternsProject
{
    /// <summary>
    /// Interaction logic for window_pay.xaml
    /// </summary>
    public partial class window_pay : Window
    {
        public window_pay()
        {
            InitializeComponent();
        }

        private void button_card1_Click(object sender, RoutedEventArgs e)
        {
            AbPayClass card1 = new Card1ConcreteClass();
            card1.payPreparing();
            card1.TemplateMethod();
            bool succesful = card1.Feedback();
            if (succesful)
            {
                //kész
            }
        }

        private void button_card2_Click(object sender, RoutedEventArgs e)
        {
            AbPayClass card2 = new Card1ConcreteClass();
            card2.payPreparing();
            card2.TemplateMethod();
            bool succesful = card2.Feedback();
            if (succesful)
            {
                //kész
            }
        }

        private void button_card3_Click(object sender, RoutedEventArgs e)
        {
            AbPayClass card3 = new Card1ConcreteClass();
            card3.payPreparing();
            card3.TemplateMethod();
            bool succesful = card3.Feedback();
            if (succesful)
            {
                //kész
            }
        }
    }
}
