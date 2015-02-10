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
    public partial class BetTable : PhoneApplicationPage
    {
        BlackJackkernel kernel = new BlackJackkernel();
        public BetTable()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void NextClick(object sender,EventArgs e)
        {
            if (BlackJackkernel.BetAmount > BlackJackkernel.CreditAmount)
            {
                MessageBoxResult result = MessageBox.Show("You Have Less Credit In Your Balance :'(", "You Are Lier:x ", MessageBoxButton.OK);
                NavigationService.Navigate(new Uri("/GameOver.xaml", UriKind.Relative));
            }
            else
            
            NavigationService.Navigate(new Uri("/Table.xaml", UriKind.Relative));
        }

        private void dollor50_Checked(object sender, RoutedEventArgs e)
        {
           BlackJackkernel.BetAmount = 50;
        }

        private void dollar100_Checked(object sender, RoutedEventArgs e)
        {
            BlackJackkernel.BetAmount= 100;
        }

        private void Dollar200_Checked(object sender, RoutedEventArgs e)
        {
            BlackJackkernel.BetAmount = 200;
        }

        private void Dollar500_Checked(object sender, RoutedEventArgs e)
        {
            BlackJackkernel.BetAmount = 500;
        }

        private void Dollor1000_Checked(object sender, RoutedEventArgs e)
        {
            BlackJackkernel.BetAmount = 1000;
        }
        private void Close_Click(object sender, EventArgs e)
        {
           
            
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}