using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BattleLib;

namespace MagisterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MagisterBattleService: IMagisterBattle
    {
        public static Dictionary<string, Battle> Battles = new Dictionary<string, Battle>();

        public string LogIn(string name, string pass)
        {
            return "" + Guid.NewGuid();
        }

        public string StartBattle(string UserKey)
        {
            Battle currentBattle = new Battle(UserKey);
            Battles.Add(currentBattle.BattleID, currentBattle);
            return currentBattle.BattleID;
        }

        public Battle GetBattleState(string UserKey, string battleID)
        {
            return Battles[battleID];
        }

        public bool TakeTurn(RoundAction Turn, string UserKey, string BattleKey)
        {
            Battles[BattleKey].ProcessRound(Turn, UserKey);
            return true;
        }
    }
}
