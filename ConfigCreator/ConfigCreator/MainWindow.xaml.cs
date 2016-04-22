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
using System.IO;

namespace ConfigCreator
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(docPath + @"\config.yml", true))
            {
                if (factoryName.Text == null) { outputFile.WriteLine(""); }
                if (factoryIdentifier.Text == null) { outputFile.WriteLine("  {0}:", factoryIdentifier.Text); }
                if (factoryType.Text == null) { outputFile.WriteLine("    type: {0}", factoryType.Text.ToUpper()); }
                if (factoryName.Text == null) { outputFile.WriteLine("    name: {0}", factoryName.Text); }
                if (factoryName.Text == null) { outputFile.WriteLine("    recipes:"); }
                if (recipe1Name.Text == null) { outputFile.WriteLine("    - {0}", recipe1Name.Text); }
                if (recipe2Name.Text == null) { outputFile.WriteLine("    - {0}", recipe2Name.Text); }
                if (recipe3Name.Text == null) { outputFile.WriteLine("    - {0}", recipe3Name.Text); }
                if (recipe4Name.Text == null) { outputFile.WriteLine("    - {0}", recipe4Name.Text); }
                if (recipe5Name.Text == null) { outputFile.WriteLine("    - {0}", recipe5Name.Text); }
                if (recipe6Name.Text == null) { outputFile.WriteLine("    - {0}", recipe6Name.Text); }
                if (recipe7Name.Text == null) { outputFile.WriteLine("    - {0}", recipe7Name.Text); }
                if (recipe8Name.Text == null) { outputFile.WriteLine("    - {0}", recipe8Name.Text); }
                if (recipe9Name.Text == null) { outputFile.WriteLine("    - {0}", recipe9Name.Text); }
                if (recipe10Name.Text == null) { outputFile.WriteLine("    - {0}", recipe10Name.Text); }
                if (recipe11Name.Text == null) { outputFile.WriteLine("    - {0}", recipe11Name.Text); }
                if (recipe12Name.Text == null) { outputFile.WriteLine("    - {0}", recipe12Name.Text); }
                if (recipe13Name.Text == null) { outputFile.WriteLine("    - {0}", recipe13Name.Text); }
                if (recipe14Name.Text == null) { outputFile.WriteLine("    - {0}", recipe14Name.Text); }
                if (recipe15Name.Text == null) { outputFile.WriteLine("    - {0}", recipe15Name.Text); }
                if (recipe16Name.Text == null) { outputFile.WriteLine("    - {0}", recipe16Name.Text); }
                if (recipe17Name.Text == null) { outputFile.WriteLine("    - {0}", recipe17Name.Text); }
                if (recipe18Name.Text == null) { outputFile.WriteLine("    - {0}", recipe18Name.Text); }
                if (recipe19Name.Text == null) { outputFile.WriteLine("    - {0}", recipe19Name.Text); }
                if (recipe20Name.Text == null) { outputFile.WriteLine("    - {0}", recipe20Name.Text); }
                if (recipe21Name.Text == null) { outputFile.WriteLine("    - {0}", recipe21Name.Text); }
                if (recipe22Name.Text == null) { outputFile.WriteLine("    - {0}", recipe22Name.Text); }
                if (recipe23Name.Text == null) { outputFile.WriteLine("    - {0}", recipe23Name.Text); }
                if (recipe24Name.Text == null) { outputFile.WriteLine("    - {0}", recipe24Name.Text); }
                if (recipe25Name.Text == null) { outputFile.WriteLine("    - {0}", recipe25Name.Text); }
                if (recipe26Name.Text == null) { outputFile.WriteLine("    - {0}", recipe26Name.Text); }
                if (recipe27Name.Text == null) { outputFile.WriteLine("    - {0}", recipe27Name.Text); }
                if (recipe28Name.Text == null) { outputFile.WriteLine("    - {0}", recipe28Name.Text); }
                if (recipe29Name.Text == null) { outputFile.WriteLine("    - {0}", recipe29Name.Text); }
                if (recipe30Name.Text == null) { outputFile.WriteLine("    - {0}", recipe30Name.Text); }
                if (recipe31Name.Text == null) { outputFile.WriteLine("    - {0}", recipe31Name.Text); }
                if (recipe32Name.Text == null) { outputFile.WriteLine("    - {0}", recipe32Name.Text); }
                if (recipe33Name.Text == null) { outputFile.WriteLine("    - {0}", recipe33Name.Text); }
                if (recipe34Name.Text == null) { outputFile.WriteLine("    - {0}", recipe34Name.Text); }
                if (recipe35Name.Text == null) { outputFile.WriteLine("    - {0}", recipe35Name.Text); }
                if (recipe36Name.Text == null) { outputFile.WriteLine("    - {0}", recipe36Name.Text); }
                if (recipe37Name.Text == null) { outputFile.WriteLine("    - {0}", recipe37Name.Text); }
                if (recipe38Name.Text == null) { outputFile.WriteLine("    - {0}", recipe38Name.Text); }
                if (recipe39Name.Text == null) { outputFile.WriteLine("    - {0}", recipe39Name.Text); }
                if (recipe40Name.Text == null) { outputFile.WriteLine("    - {0}", recipe40Name.Text); }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            factoryIdentifier.Clear();
            factoryName.Clear();
            factoryType.Clear();
            recipe1Name.Clear();
            recipe2Name.Clear();
            recipe3Name.Clear();
            recipe4Name.Clear();
            recipe5Name.Clear();
            recipe6Name.Clear();
            recipe7Name.Clear();
            recipe8Name.Clear();
            recipe9Name.Clear();
            recipe10Name.Clear();
            recipe11Name.Clear();
            recipe12Name.Clear();
            recipe13Name.Clear();
            recipe14Name.Clear();
            recipe15Name.Clear();
            recipe16Name.Clear();
            recipe17Name.Clear();
            recipe18Name.Clear();
            recipe19Name.Clear();
            recipe20Name.Clear();
            recipe21Name.Clear();
            recipe22Name.Clear();
            recipe22Name.Clear();
            recipe23Name.Clear();
            recipe24Name.Clear();
            recipe25Name.Clear();
            recipe26Name.Clear();
            recipe27Name.Clear();
            recipe28Name.Clear();
            recipe29Name.Clear();
            recipe30Name.Clear();
            recipe31Name.Clear();
            recipe32Name.Clear();
            recipe33Name.Clear();
            recipe34Name.Clear();
            recipe35Name.Clear();
            recipe36Name.Clear();
            recipe37Name.Clear();
            recipe38Name.Clear();
            recipe39Name.Clear();
            recipe40Name.Clear();
        }
    }
}
