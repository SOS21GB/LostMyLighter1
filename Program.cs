namespace LostMyLighter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Testing.PremadeUsers();
            Testing.PremadeActiveMarchallers();
            Testing.PremadeInactiveMarchallers();
            PageManager.RunApp();
        }
    }
}