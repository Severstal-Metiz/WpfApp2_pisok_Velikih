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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();

            FillUsersSuka();
            listBox1.ItemsSource = users;
        }

        void FillUsersSuka()
        {
            users.Add(new User
            {
                Age = 35,
                Klichka = "Пиздюк",
                Name = "Вася Петрович Куть",
                Opisanie = "Хорошим человеком был этот малый!\nЛишь шарф ему мешал дышать.\nРаз затянул его на шее как удавом.\nИ чуть не сдох, ебать!"
            });
            users.Add(new User
            {
                Age = 15,
                Klichka = "Лошара",
                Name = "Мася Хоритонов Обдолбыш",
                Opisanie = "Мне лень сочинять ЭССЭ. По этому его сочиняет Порфирьевич.\nЭтот господин был из тех загадочных господ, которые создают вам проблемы просто потому, что они есть на самом деле, и он в числе прочих причин и здесь.  Хотя он, может быть, не такой, как все… Вам не кажется, что он ведет себя как-то странно? Неадекватно?"
            });
            users.Add(new User
            {
                Age = 999,
                Klichka = "Зомби",
                Name = "Петухов Леонид Фуфломицинович",
                Opisanie = "Удивительная личность, этот товарищ!  - пробурчал  Столяров и вышел в коридор. - Пластическая операция сделала его красивее, чем он был.  А руки и ноги - никогда не узнал бы его без этого гардура. Как  его на дыбу, как палача..."
            });
            users.Add(new User
            {
                Age = 46,
                Klichka = "Залупа",
                Name = "Газманов Вова Фуфломицинович",
                Opisanie = "Удивительная личность, этот товарищ!  - пробурчал  Столяров и вышел в коридор. - Пластическая операция сделала его красивее, чем он был.  А руки и ноги - никогда не узнал бы его без этого гардура. Как  его на дыбу, как палача..."
            });
            users.Add(new User
            {
                Age = 40,
                Klichka = "ИНЖЫР",
                Name = "Дмитрий Владимирович",
                Opisanie = "Наивеличайший из самых великих людей во всём мире!"
            });
            users.Add(new User
            {
                Age = 40,
                Klichka = "RomixERR",
                Name = "Роман Анатолич",
                Opisanie = "Величайший из самых великих программистов во всём мире!"
            });
            users.Add(new User
            {
                Age = 41,
                Klichka = "VIK -=TOR=-",
                Name = "Виктор Саныч",
                Opisanie = "Величайший из самых великих электриков во всём мире!"
            });
        }
    }

    

    class User
    {
        public string Name{get; set; }
        public int Age { get; set; }
        public string Klichka { get; set; }
        public string Opisanie { get; set; }
    }
}
