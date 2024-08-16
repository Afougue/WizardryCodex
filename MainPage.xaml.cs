using WizardryCodex.Model;

namespace WizardryCodex
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Character("Corven Ambragon", CharacterClass.Bard , 1, Race.Humain);
        }
    }
}
