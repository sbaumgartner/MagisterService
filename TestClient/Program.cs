using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClient.MagisterService;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MagisterBattleClient client = new MagisterBattleClient())
            {
                Console.WriteLine("User Name:  ");
                string userName = Console.ReadLine();

                Console.WriteLine("Password:  ");
                string password = Console.ReadLine();

                string key = client.LogIn(userName, password);
                Console.WriteLine(key);
            }
        }
    }
}
