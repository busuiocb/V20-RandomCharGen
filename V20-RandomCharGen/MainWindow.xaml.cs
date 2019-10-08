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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Character ion = new Character();
            List<Character.AttributeGroup> test = ion.GenerateAttributes();

            //Write Values to Physical Attributes
            textbox1.Text = test[0].Attribute1Val.ToString();
            textbox2.Text = test[0].Attribute2Val.ToString();
            textbox3.Text = test[0].Attribute3Val.ToString();

            //Write Values to Social Attributes
            textbox4.Text = test[1].Attribute1Val.ToString();
            textbox5.Text = test[1].Attribute2Val.ToString();
            textbox6.Text = test[1].Attribute3Val.ToString();

            //Write Values to Mental Attributes
            textbox7.Text = test[2].Attribute1Val.ToString();
            textbox8.Text = test[2].Attribute2Val.ToString();
            textbox9.Text = test[2].Attribute3Val.ToString();
        }
    }
}
