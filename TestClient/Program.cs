using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClient.MagisterService;
using BattleLib;


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

                Console.WriteLine("Getting Battle");

                string BattleID = client.StartBattle(key);
                Console.WriteLine("BattleID is:  " + BattleID);

                Battle current = client.GetBattleState(key, BattleID);

                if (client.TakeTurn(new RoundAction() { SkillIndex = 0, Target = current.Player2Team.ID, UnitID = current.Player1Team.ID }, key, BattleID))
                {
                    current = client.GetBattleState(key, BattleID);
                }
            }
        }
    }
}
