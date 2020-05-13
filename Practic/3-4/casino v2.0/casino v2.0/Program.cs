using System;

namespace casino_v2._0
{
    class Program
    {
        static void Main()
        {
            try
            {
            Game play = new Game();
            play.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
