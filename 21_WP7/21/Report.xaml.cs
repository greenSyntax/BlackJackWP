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
    public partial class Report : PhoneApplicationPage
    {
        BlackJackkernel kernel = new BlackJackkernel();
        
        public Report()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           
            WinnerTextBlock.Text = BlackJackkernel.Winner_Name.ToString()+" "+"WON :)";
            BetAmountDisplay.Text = BlackJackkernel.BetAmount.ToString() + " " + "$";
            PlayerCurrentCredit.Text = BlackJackkernel.RestCredit().ToString() + " " + "$";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (BlackJackkernel.CreditAmount == 0)
                NavigationService.Navigate(new Uri("/GameOver.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/BetTable.xaml", UriKind.Relative));
        }


    }
}