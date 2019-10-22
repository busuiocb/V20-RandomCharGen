using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace V20_RandomCharGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


          

        }

        //Generate random character
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Character ion = new Character();
            List<Character.AttributeGroup> rollAttributes = ion.GenerateAttributes();
            List<Character.AbilityGroup> rollAbilities = ion.GenerateAbilities();
            Character.DisciplineGroup rollDisciplines = ion.GenerateDisciplines();
            Character.BackgroundGroup rollBackgrounds = ion.GenerateBackgrounds();
            Character.VirtueGroup rollVirtues = ion.GenerateVirtues();

            //Write Values to Physical Attributes
            textbox1.Text = rollAttributes[0].Attribute1Val.ToString();
            textbox2.Text = rollAttributes[0].Attribute2Val.ToString();
            textbox3.Text = rollAttributes[0].Attribute3Val.ToString();

            //Write Values to Social Attributes
            textbox4.Text = rollAttributes[1].Attribute1Val.ToString();
            textbox5.Text = rollAttributes[1].Attribute2Val.ToString();
            textbox6.Text = rollAttributes[1].Attribute3Val.ToString();

            //Write Values to Mental Attributes
            textbox7.Text = rollAttributes[2].Attribute1Val.ToString();
            textbox8.Text = rollAttributes[2].Attribute2Val.ToString();
            textbox9.Text = rollAttributes[2].Attribute3Val.ToString();


            //Write Values to Talent Abilities
            textbox10.Text = rollAbilities[0].Ability1Val.ToString();
            textbox11.Text = rollAbilities[0].Ability2Val.ToString();
            textbox12.Text = rollAbilities[0].Ability3Val.ToString();
            textbox13.Text = rollAbilities[0].Ability4Val.ToString();
            textbox14.Text = rollAbilities[0].Ability5Val.ToString();
            textbox15.Text = rollAbilities[0].Ability6Val.ToString();
            textbox16.Text = rollAbilities[0].Ability7Val.ToString();
            textbox17.Text = rollAbilities[0].Ability8Val.ToString();
            textbox18.Text = rollAbilities[0].Ability9Val.ToString();
            textbox19.Text = rollAbilities[0].Ability10Val.ToString();

            //Write Values to Skill Abilities
            textbox20.Text = rollAbilities[1].Ability1Val.ToString();
            textbox21.Text = rollAbilities[1].Ability2Val.ToString();
            textbox22.Text = rollAbilities[1].Ability3Val.ToString();
            textbox23.Text = rollAbilities[1].Ability4Val.ToString();
            textbox24.Text = rollAbilities[1].Ability5Val.ToString();
            textbox25.Text = rollAbilities[1].Ability6Val.ToString();
            textbox26.Text = rollAbilities[1].Ability7Val.ToString();
            textbox27.Text = rollAbilities[1].Ability8Val.ToString();
            textbox28.Text = rollAbilities[1].Ability9Val.ToString();
            textbox29.Text = rollAbilities[1].Ability10Val.ToString();

            //Write Values to Knowledge Abilities
            textbox30.Text = rollAbilities[2].Ability1Val.ToString();
            textbox31.Text = rollAbilities[2].Ability2Val.ToString();
            textbox32.Text = rollAbilities[2].Ability3Val.ToString();
            textbox33.Text = rollAbilities[2].Ability4Val.ToString();
            textbox34.Text = rollAbilities[2].Ability5Val.ToString();
            textbox35.Text = rollAbilities[2].Ability6Val.ToString();
            textbox36.Text = rollAbilities[2].Ability7Val.ToString();
            textbox37.Text = rollAbilities[2].Ability8Val.ToString();
            textbox38.Text = rollAbilities[2].Ability9Val.ToString();
            textbox39.Text = rollAbilities[2].Ability10Val.ToString();

            //Write Values to Disciplines
            textbox40.Text = rollDisciplines.Discipline1Val.ToString();
            textbox41.Text = rollDisciplines.Discipline2Val.ToString();
            textbox42.Text = rollDisciplines.Discipline3Val.ToString();


            //Write Values to Backgrounds
            textbox43.Text = rollBackgrounds.Background1Val.ToString();
            textbox44.Text = rollBackgrounds.Background2Val.ToString();
            textbox45.Text = rollBackgrounds.Background3Val.ToString();
            textbox46.Text = rollBackgrounds.Background4Val.ToString();
            textbox47.Text = rollBackgrounds.Background5Val.ToString();
            textbox48.Text = rollBackgrounds.Background6Val.ToString();
            textbox49.Text = rollBackgrounds.Background7Val.ToString();
            textbox50.Text = rollBackgrounds.Background8Val.ToString();
            textbox51.Text = rollBackgrounds.Background9Val.ToString();
            textbox52.Text = rollBackgrounds.Background10Val.ToString();
            textbox53.Text = rollBackgrounds.Background11Val.ToString();
            textbox54.Text = rollBackgrounds.Background12Val.ToString();
            textbox55.Text = rollBackgrounds.Background13Val.ToString();


            //Write Values to Virtues
            textbox56.Text = rollVirtues.Virtue1Val.ToString();
            textbox57.Text = rollVirtues.Virtue2Val.ToString();
            textbox58.Text = rollVirtues.Virtue3Val.ToString();


            //Calculate Humanity
            textbox59.Text = (Int32.Parse(textbox56.Text) + Int32.Parse(textbox57.Text)).ToString();

            //Calculate Willpower
            textbox60.Text = textbox58.Text;

        }
    }
}
