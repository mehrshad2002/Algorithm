namespace JustLearnForSelf
{
    internal class Bank
    {
        public string Mellat(string val)
        {
            IO io = new IO();
            List<UserAccount> accounts = new List<UserAccount>();
            accounts.Add(new UserAccount("Mehrhsad", "6104123409876789", "1234"));
            accounts.Add(new UserAccount("Aria", "6104566509875432", "1234"));
            accounts.Add(new UserAccount("Mehrhsad", "6104209509876316", "1234"));
            bool CheckVal;

            //IEnumerable<string> enumerable()
            //{
            //    foreach (var account in accounts)
            //    {
            //        if (account.NumberCard == val)
            //        {
            //            yield return account.Password;
            //        }
            //    }
            //}
            //var pass = enumerable();
            var passVal = "1";
            foreach( var account in accounts)
            {
                if( account.NumberCard == val)
                {
                    passVal = account.Password;
                }
            }
            if (passVal != null)
            {
                string PassStr = Convert.ToString(passVal);
                return PassStr;
            }
            else
            {
                io.Print("Card is Invalid ");
                return "!";
            }
        }

        internal bool Pasargad(string val)
        {
            throw new NotImplementedException();
        }

        internal bool Iran(string val)
        {
            throw new NotImplementedException();
        }
    }
}