using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using System.Media;
namespace arduinohaberlesme
{
    public class Fonksiyonlar
    {
        public static bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("baby.sister.8899@gmail.com");
            //
            ePosta.To.Add("elif.curuk@hotmail.com");
            ePosta.To.Add("elif.curuk.1993@gmail.com");
            //
            ePosta.Attachments.Add(new Attachment(@"D:\Deneme.txt"));
            //
            ePosta.Subject = konu;
            //
            ePosta.Body = icerik;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("baby.sister.8899@gmail.com", "Bebek*12345");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }

        public static void Muzik_Cal()
        {

            SoundPlayer player = new SoundPlayer();

            string path = "D:\\ninni.wav"; // Çalmasini istediginiz ses dosyasinin yolu

            player.SoundLocation = path;

            player.Play();
        }
    }
}
