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

namespace Book_of_quotes
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
        private List<string> quotes = new List<string>()
        {
            "Кто поздно встаёт, тот едёт без пробок",
            "Биссектриса это крыса, которая \nбегает по углам и делит угол пополам",
            "Кто рано встаёт, тот меньше спит",
            "Я за малиной, тебе брать?",
            "Если заблудился в лесу, то иди домой",
            "В жизни всегда есть 2 дороги: \nодна - первая, другая - вторая",
            "Запомни: Всего одна ошибка и то ошибся",
            "Делай ка надо, как не надо не делай",
            "Работа это не волк. Работа - ворк. \nВолк это ходить",
            "Слово не воробей. Вообще ничто не воробей, \nкроме самого воробья."
        };
        private Random random = new Random();

        private void New_Quote(object sender, RoutedEventArgs e)
        {
            int rIndex = random.Next(quotes.Count);
            string rQuote = quotes[rIndex];

            Quote.Text = rQuote;
        }
    }
}