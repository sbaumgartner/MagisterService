using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleLib
{
    public class BattleSkill
    {
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        Dictionary<string, int> vars;

        public BattleSkill(string name)
        {
            vars = new Dictionary<string, int>();
            SkillName = name;
        }

        public void UseSkill(Battle battle, string targetID)
        {
            vars = new Dictionary<string, int>();
            Unit target = battle.GetTargetUnitByID(targetID);
            target.Alive = false;
        }

        public int GetVar(string varName)
        {
            if (vars.ContainsKey(varName))
            {
                return vars[varName];
            }
            else throw new Exception("Looking for " + varName + " in skill " + SkillName + " but it does not exist");
        }

    }
}
