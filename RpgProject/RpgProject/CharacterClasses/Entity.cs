using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgProject.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown, Androginous }
    
    public abstract class Entity
    {
        #region Fields Region

        protected string name;
        protected EntityGender gender;
        protected int strength, dexterity, wisdom, inteligence, charism, health;
        protected int strenghtModifier, dexterityModifier, wisdomModifier, inteligenceModifier, charismModifier, healthModifier;
        #endregion

        #region Properties 

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public EntityGender Gender { get; set; }
        
        public int Strenght
        {
            get { return strength + strenghtModifier; }
            protected set { strength = value; }
        }
        public int Dexterity
        {
            get { return dexterity + dexterityModifier; }
            protected set { dexterity = value; }
        }
        public int Wisdom
        {
            get { return wisdom + wisdomModifier; }
            protected set { wisdom = value; }
        }
        public int Inteligence
        {
            get { return inteligence + inteligenceModifier; }
            protected set { inteligence = value; }
        }
        public int Charism
        {
            get { return charism + charismModifier; }
            protected set { charism = value; }
        }
        public int Health
        {
            get { return health + healthModifier; }
            protected set { health = value; }
        }
        public int Attack
        {
            get { return attack; }
            protected set { attack = value; }
        }
        public int Damage
        {
            get { return damage; }
            protected set { damage = value; }
        }
        public int Defense
        {
            get { return defense; }
            protected set { defense = value; }
        }
        public int Level
        {
            get { return level; }
            protected set { level = value; }
        }
        public long Experience
        {
            get { return experience; }
            protected set { experience = value; }
        }

        #endregion

        #region Combat

        protected int attack;
        protected int damage;
        protected int defense;

        protected int level;
        protected long experience;

        #endregion

        #region Constructor

        public Entity()
        {
            Name = string.Empty;
            Strenght = 0;
            Dexterity = 0;
            Wisdom = 0;
            Inteligence = 0;
            Charism = 0;
            Health = 0;

        }
        #endregion

        #region Methods

        #endregion


    }
}
