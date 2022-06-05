using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWProfileMaker.Domain.Enums;

namespace WWProfileMaker.Domain.VirtualEntities
{
    public abstract class Character : BaseEntity
    {
        protected Character()
        {
            
        }

        public string name { get; set; }
        public string background { get; set; }
        public CharacterType characterType { get; set; }
        public int age { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public Address address { get; set; }
        public int willPoints { get; set; }
        public int lifePoints { get; set; }
        public int unarmedCombat { get; set; }
        public int meleeCombat { get; set; }
        public int rangedCombat { get; set; }
        public int defenseCombat { get; set; }
        public int lockPicking { get; set; }
        public int sneaking { get; set; }
        public int hacking { get; set; }
        public int inspection { get; set; }
        public int haggle { get; set; }
        public int intimidate { get; set; }
        public int persuasion { get; set; }
        public int seduction { get; set; }
        public int stamina { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int charisma { get; set; }
        public int manipulation { get; set; }
        public int appearance { get; set; }
        public int perception { get; set; }
        public int intelligence { get; set; }
        public int wits { get; set; }
        public int dodge { get; set; }
        public int intimidation { get; set; }
        public int subterfuge { get; set; }
        public int brawl { get; set; }
        public int melee { get; set; }
        public int security { get; set; }
        public int stealth { get; set; }
        public int firearms { get; set; }
        public int computer { get; set; }
        public int finance { get; set; }
        public int investigation { get; set; }
        public int scholarship { get; set; }
    }
}
