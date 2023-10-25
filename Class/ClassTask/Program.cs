namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User Nihad = new User("nihadjafarov", "12345678");
            Nihad.Login("nihadjafarov", "12345678");
            Nihad.Logout("nihadjafarov", "12345678");
        }
    }
}