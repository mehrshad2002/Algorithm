using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLearnForSelf
{
    public class Command
    {
        public void Account(string cardNumber)
        {
            
            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);
            string Money;
            switch (Card4digit)
            { 
                case "6104":
                    Money = bank.SayMoneyMelat();
                    break;

                case "6393":
                    Money = bank.SayMoneyPassargad();
                    break;

                case "5892":
                    Money = bank.SayMoneyIran();   
                     break;

                default:
                    break;
            
            }
            io.Print("Your Accounts --> {}");
        }

        internal void GetMoney(string cardNumber)
        {
            throw new NotImplementedException();
        }

        internal void SendMoney(string cardNumber)
        {
            throw new NotImplementedException();
        }

        internal void GetCharge(string cardNumber)
        {
            throw new NotImplementedException();
        }

        internal void SendCharge(string cardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
