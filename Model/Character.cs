using System.ComponentModel;

namespace WizardryCodex.Model
{
    public class Character : INotifyPropertyChanged
    {
        // Base stuff
        private string      _name;
        private int         _level;
        private int         _hp;
        private int         _maxHp;
        private Race        _race;
        private Alignement  _alignement;
        private int         _armorClass;
        private float       _speed;
        private int         _age;
        private float       _height;
        private float       _weight;
        private List<SpokenLanguage> _languages;

        // Class related
        private CharacterClass  _characterClass;
        private List<Spell>     _spells;

        // Ability scores
        private int _strength;
        private int _dexterity;
        private int _constitution;
        private int _intelligence;
        private int _wisdom;
        private int _charisma;

        // Ability bonus 
        public int StrBonus() { return Strength - 10; }
        public int DexBonus() { return Dexterity - 10; }
        public int ConstBonus() { return Constitution - 10; }
        public int IntelBonus() { return Intelligence - 10; }
        public int WisdomBonus() { return Wisdom - 10; }
        public int CharBonus() { return Charisma - 10; }

        // Skills
        private List<int> _masteryBonus; // Hold index of every mastered skill
        private int _athletics;
        private int _acrobatics;
        private int _sleightOfHand;
        private int _stealth;
        private int _arcana;
        private int _history;
        private int _investigation;
        private int _nature;
        private int _religion;
        private int _animalHandling;
        private int _insight;
        private int _medicine;
        private int _perception;
        private int _survival;
        private int _deception;
        private int _intimidation;
        private int _performance;
        private int _persuasion;

        public Character()
        {
            _name = "";
            _hp = _maxHp = 1;
            _languages = [];
            _spells = [];
            _masteryBonus = [];
        }

        public Character(string name, CharacterClass characterClass, int level = 0, Race race = Race.Humain) : this()
        {
            Name = name;
            CharacterClass = characterClass;
            Level = level;
            Race = race;
        }

        public void setAbilities(int str, int dex, int con, int intel, int wis, int cha)
        {
            Strength = str;
            Dexterity = dex;
            Constitution = con;
            Intelligence = intel;
            Wisdom = wis;
            Charisma = cha;
        }

        #region Properties

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public CharacterClass CharacterClass
        {
            get => _characterClass;
            set
            {
                if (_characterClass != value)
                {
                    _characterClass = value;
                    OnPropertyChanged(nameof(CharacterClass));
                }
            }
        }

        public int Hp
        {
            get => _hp;
            set
            {
                if (_hp != value)
                {
                    _hp = value;
                    OnPropertyChanged(nameof(Hp));
                }
            }
        }

        public int MaxHp
        {
            get => _maxHp;
            set
            {
                if (_maxHp != value)
                {
                    _maxHp = value;
                    OnPropertyChanged(nameof(MaxHp));
                }
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                if (_level != value)
                {
                    _level = value;
                    OnPropertyChanged(nameof(Level));
                }
            }
        }

        public Race Race
        {
            get => _race;
            set
            {
                if (_race != value)
                {
                    _race = value;
                    OnPropertyChanged(nameof(Race));
                }
            }
        }

        public Alignement Alignement { get => _alignement; set => _alignement = value; }
        public int Age { get => _age; set => _age = value; }
        public float Height { get => _height; set => _height = value; }
        public float Weight { get => _weight; set => _weight = value; }
        public int ArmorClass { get => _armorClass; set => _armorClass = value; }
        public float Speed { get => _speed; set => _speed = value; }
        public List<SpokenLanguage> Languages { get => _languages; set => _languages = value; }
        public List<Spell> Spells { get => _spells; set => _spells = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Wisdom { get => _wisdom; set => _wisdom = value; }
        public int Charisma { get => _charisma; set => _charisma = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion
}
