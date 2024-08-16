namespace WizardryCodex.Model
{
    public class Spell
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public float Range { get; set; }


        public Spell() : this("", 0, 0)
        {
        }

        public Spell(string name, int level, float range)
        {
            Name = name;
            Level = level;
            Range = range;
        }
    }
}
