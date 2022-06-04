namespace JustLearnForSelf
{
    internal class ATM
    {
        public bool Start()
        {
            IO io = new IO();
            bool Flag = io.GetCommand();
            return Flag;
        }
    }
}