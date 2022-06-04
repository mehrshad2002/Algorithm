using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLearnForSelf
{
    public class IO
    {
        public void Print<E>(E val)
        {
            Console.WriteLine(val);
        }

        public void PrintAt<E>(E val)
        {
            Console.Write(val);
        }

        public string Get()
        {
            string val;
            val = Convert.ToString(Console.ReadLine());
            return val;
        }

        public string GetAt()
        {
            string val;
            val = Convert.ToString(Console.Read());
            return val;
        }

        public bool GetCommand()
        {
            Print("Please Enter Your Command Number! || #<Commnad>");
            Print("1-See Your Account\n2-Get Money\n3-Send Money" +
                "\n4-Get Charge\n5-Send Charge\n6Exite");
            PrintAt("Enter Your Command : ");
            var CommandVal = Get();
            if( CommandVal == "6")
            {
                return false;
            }
            else
            {
                CallCommand(CommandVal);
                return true;
            }
        }

        public void CallCommand( string val)
        {
            switch (val)
            {
                case "1":
                    //Account;
                    break;

                case "2":
                    //Get Money ;
                    break;

                case "3":
                    //Send Money 
                    break;

                case "4":
                    //Get Charge 
                    break;

                case "5":
                    //Send Charge
                    break;

                default:
                    Print("Invalid Case!");
                    break;
            }
        }

        public string  ReadCard()
        {
            Card card = new Card();
            var CardNumberVal = card.CardNumber();
            return CardNumberVal;
        }
        public bool CallCheck()
        {
            Card card = new Card();
            Check check = new Check();
            bool StartFlag;
            string CardNumberVal = card.CardNumber();
            string Card4digit = CardNumberVal.Substring(0, 4);
            switch ( Card4digit)
            {
                case "6104":
                    StartFlag = check.CheckMellat(CardNumberVal);
                    break;

                case "6393":
                    StartFlag = check.CheckMellat(CardNumberVal);
                    break;

                case "5892":
                    StartFlag = check.CheckMellat(CardNumberVal);
                    break;

                default :
                    Print("Invalid Card!");
                    StartFlag = false;
                    break;
            }

            return StartFlag;
        }
    }

}
