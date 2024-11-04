using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string[] codeColors = { "Red", "Orange", "Yellow", "Green", "White", "Blue" };
        private string[] generatedCode;
        public MainWindow()
        {
            InitializeComponent();
            GenerateRandomCode();
            
        }
         private void GenerateRandomCode()
        {
            Random random = new Random();
            generatedCode = new string[4];

            for (int i = 0; i < 4; i++)
            {
                generatedCode[i] = codeColors[random.Next(codeColors.Length)];
            }

            this.Title = "MasterMind  /  Code: ( " + string.Join(" , ", generatedCode)+" )"; 
        }
    }
}