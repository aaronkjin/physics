using System;

namespace tests
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Simulation())
                game.Run();
        }
    }
}