namespace StarWarsGameLibrary
{
    public abstract class Character
    {
        //Fields

        /* int maxlife (assign first in ctor)*/
        /* string name*/
        private string _name;
        private int _maxLife;
        /* int life (cannot be more than maxlife) */
        private int _life;
        /* int hit chance*/
        private int _hitChance;
        /* int block*/
        private int _block;

        //Properties - 1 for each field
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Life
        {
            get { return _life; }
            set { _life = value <= _maxLife? value:_maxLife; }
        }


        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        //Ctors - 1 fully qualified, 1 default/unqualified
        public Character() { }
        public Character(string name, int maxLife, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            Life = maxLife;
            HitChance = hitChance;
            Block = block;
        }

        //Methods
        //ToString() override
        public override string ToString()
        {
            //return base.ToString();
            return $"Name: {Name}\n\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit chance: {HitChance}% \n" +
                $"Block: {Block} \n";
        }
        //CalcBlock() returns an int -> return Block;
        public virtual int CalcBlock()
        {
            return _block;
        }

        //CalcHitChance() returns an int -> return HitChance;
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        //CalcDamage() returns an int -> return 0;
        public abstract int CalcDamage();//an abstract just says somewhere down the line, one of the child
    }
}