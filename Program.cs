using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fplayer princeHarry = new Fplayer("manU", "cb", 4);
            Fplayer KDB = new Fplayer("manCity", "amf", 17);
            Console.WriteLine(princeHarry.Club);
            Console.WriteLine(KDB.Position);


        }
    }
}