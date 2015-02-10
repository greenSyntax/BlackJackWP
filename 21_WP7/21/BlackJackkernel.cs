using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


namespace _21
{
    public class BlackJackkernel
    {
        Random random_facecards=new Random();
        Random random_cards=new Random();

        public int PlayerPoint=0,
                   DealerPoint=0;

        public string PlayerName;

        public static int BetAmount;
        public static int CreditAmount;
       

        public bool PlayerWinner=false,
                    DealerWinner=false,
                    None=false;

        public int temp_dealer;


        public string temp_cards,
                      temp_Hit_Card;

        public static string Winner_Name;
                     
                      
        public bool temp_winner;

        public string [] faceCard ={
                          "King",
                          "Queen",
                          "Jack"
                          };

       public string Hit_Method()
        {
            temp_Hit_Card= RandomCards();
            return temp_Hit_Card;
        }

        public string RandomCards()
        {
            switch (random_cards.Next(1, 10))
            {
                case 1:
                 PlayerPoint += 1;
                    temp_cards = "Ace";
                    break;

                case 2:
                    PlayerPoint += 2;
                    temp_cards = "two";
                    break;

                case 3:
                    PlayerPoint += 3;
                    temp_cards = "three";
                    break;

                case 4:
                    PlayerPoint += 4;
                    temp_cards = "four";
                    break;

                case 5:

                    PlayerPoint += 5;
                    temp_cards = "five";
                    break;

                case 6:
                    PlayerPoint += 6;
                    temp_cards = "six";
                    break;
                case 7:
                    PlayerPoint += 7;
                    temp_cards = "seven";
                    break;
                case 8:
                    PlayerPoint += 8;
                    temp_cards = "eight";
                    break;
                case 9:
                    PlayerPoint += 9;
                    temp_cards = "nine";
                    break;

                case 10:
                    PlayerPoint += 10;
                    temp_cards = faceCard[random_facecards.Next(0, 2)].ToString();
                    break;

            }

            return temp_cards;
        }

        //________________________ EXCEED THE LIMIT
        public bool NotExceeded21()
        {
            bool temp_bool;
            if (PlayerPoint <= 21)
                temp_bool = true;
            else
                temp_bool = false;

            return temp_bool;
        }
            
        //PLAYER WINNER
        public bool IsPlayerWinner()
        {
             
            if (PlayerWinner == true)
            {
                temp_winner = true;
            }
            return temp_winner;
        }
        // DEALER WINNER
        public bool IsDealerWinner()
        {
            

            if (DealerWinner == true)
            {
                temp_winner = true;
            }
            return temp_winner;

        }

        // NONE IS WINNER

        public bool IsNoneWinner()
        {
          
            if (DealerWinner == true)
            {
                temp_winner = true;
            }
            return temp_winner;
            
        }

        public void ReturnWinner()
        {
            while (true)
            {
                if (IsPlayerWinner())
                {
                    Winner_Name = "Player";
                    break;
                }
                else if (IsDealerWinner())
                {
                    Winner_Name = "Dealer";
                    break;
                }
                else if (IsNoneWinner())
                {
                    Winner_Name = "Drawn";
                    break;
                }


            }
         

        }

        // ----------------------- STAND METHOD---------------DEALER COUNTING
        public int Stand_Method()
        {

           while (DealerPoint < 22)
            {
                if (DealerPoint >=0 && DealerPoint < 10)
                    DealerPoint += random_cards.Next(1, 10);
                else if (DealerPoint >= 10 && DealerPoint < 15)
                    DealerPoint += random_cards.Next(1, 5);
                else if (DealerPoint >= 15 && DealerPoint <= 16)
                    DealerPoint += random_cards.Next(1, 5);
                else
                {
                    MessageBox.Show("Dealer :" +" "+ DealerPoint.ToString());
                    break;
                }
            }


           return DealerPoint;
        }


        public static int RestCredit()
        {
            if (Winner_Name == "PLAYER")
                CreditAmount += BetAmount;
            else if (Winner_Name == "DEALER")
                CreditAmount -= BetAmount;
            else
                CreditAmount += 0;
            return CreditAmount;
        }

    }
}
