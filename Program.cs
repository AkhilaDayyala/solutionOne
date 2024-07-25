namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

          Operations operate = new Operations();
            operate.operates();
           
            StatementDemo statement = new StatementDemo();
            statement.statement();

            EvenDemo even = new EvenDemo();
            even.even();
            Loops loops = new Loops();  
            loops.loop();
            LoopsDemo loop = new LoopsDemo();
            loop.loop();
            OddFor odd= new OddFor();
            odd.odd();
           
          
           
          
        }
    }
}
