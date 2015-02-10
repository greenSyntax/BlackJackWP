using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace _21
{
    public partial class CasinoTable : PhoneApplicationPage
    {
        BlackJackkernel kernel = new BlackJackkernel();
        public CasinoTable()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Bettable.xaml", UriKind.Relative));
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            BlackJackkernel.CreditAmount = 1000;
            
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
           BlackJackkernel.CreditAmount = 5000;
        }

        private void PlayerNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            kernel.PlayerName = PlayerNameTextBox.Text.ToString();

        }

        
        
    }
}