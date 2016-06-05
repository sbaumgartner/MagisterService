using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleLib.SkillActions
{
    public class DealDamage
    {
        public string DamageValVar { get; set; }
        public string DmgType { get; set; }
        public string TargetIDVar { get; set; }

        public DealDamage(string damageVar, string dmgType, string targetIDVar)
        {
            DamageValVar = damageVar;
            DmgType = dmgType;
            TargetIDVar = targetIDVar;
        }



    }
}
