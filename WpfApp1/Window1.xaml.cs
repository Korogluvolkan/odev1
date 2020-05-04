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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml etkileşim mantığı
    /// </summary>
    public partial class Window1 : Window
    {
        kayitEkle kayit = new kayitEkle();

        
        
        public Window1()
        {
            InitializeComponent();

            

        }
        

       
        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
             
             if(TextBoxAd.Text!="" && TextBoxSoyad.Text!="" && TextBoxYas.Text!="" && TextBoxBolum.Text!="")
            {
                kayit.id++;
             kayit.ad = TextBoxAd.Text;
             kayit.soyad = TextBoxSoyad.Text;
             kayit.yas = int.Parse(TextBoxYas.Text);
             kayit.bolum = TextBoxBolum.Text;
                TextBoxAd.Text = null;
                TextBoxSoyad.Text = null;
                TextBoxYas.Text = null;
                TextBoxBolum.Text = null;
                a = 1;
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                if (TextBoxAd.Text == "")  MessageBox.Show("Ad boş geçilemez.", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Error);
               else if (TextBoxSoyad.Text == "") MessageBox.Show("Soyad boş geçilemez.", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Error);
               else if (TextBoxYas.Text == "") MessageBox.Show("Yaş boş geçilemez.", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Error);
               else if (TextBoxBolum.Text == "") MessageBox.Show("Bölüm boş geçilemez.", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Error);

            }


           

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            a = 1;
            this.Visibility = Visibility.Hidden;
        }
        public void Window_Closed(object sender, EventArgs e)
        {
            
            
        }
        
        public int a { get; set; }
        public string IDG
        {
            get
            {
                
                return (kayit.id).ToString();

            }
        }
        public string AdG
        {
            get
            {
                return kayit.ad; 
                
            }
        }
        public string SoyadG
        {
            get
            {
                return kayit.soyad;
            }
        }
        public string YasG
        {
            get
            {
                return kayit.yas.ToString();
            }
        }
        public string BolumG
        {
            get
            {
                return kayit.bolum;
            }
        }

        public class kayitEkle
        {
            public int id = -1;
            public string ad { get; set; }
            public string soyad { get; set; }
            public int yas { get; set; }
            public string bolum { get; set; }
    
        }

        
    }
}
