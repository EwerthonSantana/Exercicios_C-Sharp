using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client[] client = new Client[9];

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                client[room] = new Client { Name = name, Email = email, Room = room };
            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < client.Length; i++)
            {
                if (client[i] != null)
                {                   
                    Console.WriteLine(client[i].Room + ": " + client[i].Name + ", " + client[i].Email);
                }
                   
            }

        }
    }
}
