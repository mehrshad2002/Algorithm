namespace JustLearnForSelf
{
    public class Check
    {
        public bool CheckMellat( string val)
        {
            IO io = new IO();
            string Password;
            Bank bank = new Bank();
            string PassVal = bank.Mellat(val);
            io.PrintAt("Enter Your Password : ");
            Password = io.Get();
            io.Print(PassVal);
            io.Print(Password);
            if( Password == PassVal)
            {
                io.Print("Correct!");
                return true;
            }
            else
            {
                io.Print("Nooooooo");
                return false;
            }
        }
        //--------------------------------
        public bool CheckPasargad( string val)
        {
            string Password;
            Bank bank = new Bank();
            bool CheckVal = bank.Pasargad(val);
            return CheckVal;
        }

        public bool CheckIran(string val)
        {
            string Password;
            Bank bank = new Bank();
            bool CheckVal = bank.Iran(val);
            return CheckVal;
        }

        public bool CheckPassword( string val)
        {
            string Password;
            IO io = new IO();
            return true;

        }

    }
}