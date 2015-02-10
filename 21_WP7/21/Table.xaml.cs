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
using System.Windows.Media.Imaging;

namespace _21
{
    public partial class Table : PhoneApplicationPage
    {
        BlackJackkernel kernel = new BlackJackkernel();

        public bool DealerWinner, PlayerWinner, None;

        public Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ShowImage(kernel.Hit_Method().ToString());
           /*
            * BitmapImage Card = new BitmapImage(new Uri(kernel.Hit_Method(), UriKind.Relative));
            CardImage.Source = Card;
            */

            //DisplayTextBlock.Text = kernel.Hit_Method();
           PlayerPointTextBox.Text= kernel.PlayerPoint.ToString();
            while (true)
            {
                if (kernel.NotExceeded21())
                {
                    
                    break;
                }
                
                {
                   NavigationService.Navigate(new Uri("/Report.xaml", UriKind.Relative));
                   BlackJackkernel.Winner_Name = "DEALER";
                }
                break;
             }

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            kernel.PlayerPoint = 0;
            kernel.DealerPoint = 0;
            CreditTableDisplay.Text = "Player Credit :"+" "+BlackJackkernel.CreditAmount.ToString()+"$";
            
            ShowImage(kernel.Hit_Method().ToString());
            // DisplayTextBlock.Text = kernel.Hit_Method();
            PlayerPointTextBox.Text = kernel.PlayerPoint.ToString();
           
    
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
             kernel.Stand_Method();
            PlayerPointTextBox.Text += kernel.DealerPoint.ToString();

            if (kernel.PlayerPoint > kernel.DealerPoint)
                BlackJackkernel.Winner_Name = "PLAYER";
            else if (kernel.PlayerPoint < kernel.DealerPoint)
                BlackJackkernel.Winner_Name = "DEALER";
            else if (kernel.PlayerPoint == kernel.DealerPoint)
                BlackJackkernel.Winner_Name = "MATCH DRAWN";

            NavigationService.Navigate(new Uri("/Report.xaml", UriKind.Relative));


        }
        public void ShowImage(string val)
        {
            
            if (val == "Ace")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/Ace.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "two")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/two.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "three")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/three.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "four")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/four.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "five")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/five.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "six")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/six.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "seven")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/seven.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "eight")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/eight.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "nine")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/nine.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "King")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/King.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "Queen")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/Queen.png", UriKind.Relative));
                CardImage.Source = Card;
            }
            else if (val == "Jack")
            {
                BitmapImage Card = new BitmapImage(new Uri("/Cards/Jack.png", UriKind.Relative));
                CardImage.Source = Card;
            }
        }
    
    
    }


}