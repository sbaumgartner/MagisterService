using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BattleLib
{
    [DataContract]
    public class Battle
    {
        [DataMember]
        public string BattleID { get; set; }
        [DataMember]
        public string Player1ID { get; set; }
        [DataMember]
        public string Player2ID { get; set; }
        [DataMember]
        public Unit Player1Team { get; set; }
        [DataMember]
        public Unit Player2Team { get; set; }

        public Battle(string userKey)
        {
            BattleID = "" + Guid.NewGuid();
            Player1ID = userKey;
            Player2ID = "AI";
            Player1Team = new Unit() { Alive = true, ID = "Unit1ID", Name = "SteveUnit"};
            Player2Team = new Unit() { Alive = true, ID = "Unit2ID", Name = "AIUnit" };
        }

        public void ProcessRound(RoundAction actions, string playerID)
        {
            if (playerID == Player1ID)
            {
                Player1Team.Skills[actions.SkillIndex].UseSkill(this, actions.Target);
            }
        }

        public Unit GetTargetUnitByID(string id)
        {
            if (Player1Team.ID == id)
                return Player1Team;
            else
                return Player2Team;
        }
    }
}
