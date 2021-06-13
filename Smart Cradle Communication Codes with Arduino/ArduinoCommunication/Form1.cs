using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using System.Media;
using System.IO.Ports;

namespace arduinohaberlesme
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Baglan();
            CheckForIllegalCrossThreadCalls = false;

        }

        //private void ArduinodanMesajAl()
        //{
        //    string gelen;
        //    while(arduino.IsOpen)
        //    {
        //        gelen = arduino.ReadLine();
        //        if(gelen=="Uyandi")
        //        {
        //            mesaj.Text = "Çocuk Uyandı";
        //            MessageBox.Show("Çocuk Uyandı");
        //        }
        //    }
        //}

        private void Baglan()
        {
            try
            {
                arduino.PortName = "COM8";
                arduino.BaudRate = 9600;
                arduino.Open();
                //Thread arduinoMesaji = new Thread(ArduinodanMesajAl);
                //arduinoMesaji.Start();
                //MessageBox.Show("Bağlantı Başarılı");
            }
            catch
            {
                MessageBox.Show("arduino algilanamadi");
            }
        }
        int say = 0;
        string arduOkunan;
        private void Ardu_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //arduOkunan = arduino.ReadLine();
            if (say % 2 == 0)
            {
                try
                {
                    Fonksiyonlar.Gonder("cocuk", "uyandi");
                    Fonksiyonlar.Muzik_Cal();
                    arduino.Write("T");
                }
                catch
                {
                    MessageBox.Show("Hata Oluştu");
                }

            }
            say++;

        }
    }
}
