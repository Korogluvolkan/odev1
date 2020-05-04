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
using System.Collections;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 win1 = new Window1();
        public ArrayList IDlist = new ArrayList();
        public ArrayList Namelist = new ArrayList();
        public ArrayList Surnamelist = new ArrayList();
        public ArrayList Agelist = new ArrayList();
        public ArrayList DepartentList= new ArrayList();

        public MainWindow()
        {
            
            InitializeComponent();
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            if(win1.a==1)
            {
                Window1.kayitEkle kayitEkle = new Window1.kayitEkle();
                if (sayac < int.Parse(win1.IDG))
                {
                    sayac++;
                    student kayit = new student();
                    kayit.studentID = win1.IDG;
                    kayit.studentName = win1.AdG;
                    kayit.studentSurname = win1.SoyadG;
                    kayit.studentAge = win1.YasG;
                    kayit.studentDepartment = win1.BolumG;
                    DataGridXMAL.Items.Add(kayit);
                    ComboBox1.Items.Add(kayit.studentID);
                    IDlist.Add(win1.IDG);
                    Namelist.Add(win1.AdG);
                    Surnamelist.Add(win1.SoyadG);
                    Agelist.Add(win1.YasG);
                    DepartentList.Add(win1.BolumG);

                }
                win1.a = 2;
            }
        }


        public class student
        {
            public string studentID { get; set; }
            public string studentName { get; set; }
            public string studentSurname { get; set; }
            public string studentAge { get; set; }
            public string studentDepartment { get; set; }

        }

        private void DataGridXMAL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            win1.Show();
           
            
            
        }
        int sayac = -1;
        private void ShowBTN__Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(IDlist[ComboBox1.SelectedIndex].ToString()+"-"+Namelist[ComboBox1.SelectedIndex].ToString()+"-"+Surnamelist[ComboBox1.SelectedIndex].ToString()+"-"+Agelist[ComboBox1.SelectedIndex].ToString()+"-"+ DepartentList[ComboBox1.SelectedIndex].ToString());
        }

        private void TListBTN_Click(object sender, RoutedEventArgs e)
        {
            DataGridXMAL.Visibility = Visibility.Visible;
            ComboBox1.Visibility = Visibility.Visible;
            EkleBTN.Visibility = Visibility.Visible;
            PersonaLInfGrid.Visibility = Visibility.Hidden;
        }

        private void KisiBilgiBTN_Click(object sender, RoutedEventArgs e)
        {
            PersonaLInfGrid.Visibility = Visibility.Visible;
            DataGridXMAL.Visibility = Visibility.Hidden;
            EkleBTN.Visibility = Visibility.Hidden;
            ComboBox1.Visibility = Visibility.Hidden;
        }
    }
}
