using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWProfileMaker.Domain.VirtualEntities;
using WWProfileMaker.Domain.Enums;

namespace WWProfileMaker.Domain.Entities
{
    public class Human : Character
    {
        public string job { get; set; }

        public Human(string name, 
                     string background, 
                     CharacterType characterType, 
                     int age, 
                     float height, 
                     float weight, 
                     Address address, 
                     int willPoints, 
                     int lifePoints, 
                     int unarmedCombat, 
                     int meleeCombat, 
                     int rangedCombat, 
                     int defenseCombat, 
                     int lockPicking, 
                     int sneaking, 
                     int hacking, 
                     int inspection, 
                     int haggle, 
                     int intimidate, 
                     int persuasion, 
                     int seduction, 
                     int stamina, 
                     int strength, 
                     int dexterity, 
                     int charisma, 
                     int manipulation, 
                     int appearance, 
                     int perception, 
                     int intelligence, 
                     int wits, 
                     int dodge, 
                     int intimidation, 
                     int subterfuge, 
                     int brawl, 
                     int melee, 
                     int security, 
                     int stealth, 
                     int firearms, 
                     int computer, 
                     int finance, 
                     int investigation, 
                     int scholarship, 
                     string job
            )
        {
            this.name = name;
            this.background = background;
            this.characterType = characterType;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.address = address;
            this.willPoints = willPoints;
            this.lifePoints = lifePoints;
            this.unarmedCombat = unarmedCombat;
            this.meleeCombat = meleeCombat;
            this.rangedCombat = rangedCombat;
            this.defenseCombat = defenseCombat;
            this.lockPicking = lockPicking;
            base.sneaking = sneaking;
            base.hacking = hacking;
            base.inspection = inspection;
            this.haggle = haggle;
            this.intimidate = intimidate;
            this.persuasion = persuasion;
            this.seduction = seduction;
            this.stamina = stamina;
            this.strength = strength;
            this.dexterity = dexterity;
            this.charisma = charisma;
            this.manipulation = manipulation;
            this.appearance = appearance;
            this.perception = perception;
            this.intelligence = intelligence;
            this.wits = wits;
            this.dodge = dodge;
            this.intimidation = intimidation;
            this.subterfuge = subterfuge;
            this.brawl = brawl;
            this.melee = melee;
            this.security = security;
            this.stealth = stealth;
            this.firearms = firearms;
            this.computer = computer;
            this.finance = finance;
            this.investigation = investigation;
            this.scholarship = scholarship;
            
            this.job = job;
        }
    }
}
