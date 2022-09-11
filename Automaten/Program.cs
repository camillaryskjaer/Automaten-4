namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates the Objekt VendingMachine and starts the program within the objekt
            VendingMachine machine = new VendingMachine();
            machine.Run();
        }
    }
}