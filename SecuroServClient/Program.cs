using System;

namespace SecuroServClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"   _____                           _____                 ");
            Console.WriteLine(@"  / ____|                         / ____|                ");
            Console.WriteLine(@" | (___   ___  ___ _   _ _ __ ___| (___   ___ _ ____   __");
            Console.WriteLine(@"  \___ \ / _ \/ __| | | | '__/ _ \\___ \ / _ \ '__\ \ / /");
            Console.WriteLine(@"  ____) |  __/ (__| |_| | | | (_) |___) |  __/ |   \ V / ");
            Console.WriteLine(@" |_____/ \___|\___|\__,_|_|  \___/_____/ \___|_|    \_/  ");
            Console.WriteLine("Server Address: ");
            String? serverAddress = Console.ReadLine();
            Console.WriteLine(serverAddress);
        }
    }
}