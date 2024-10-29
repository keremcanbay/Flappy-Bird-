using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        float yercekimi = 1f; // Başlangıç düşme hızı
        float ivme = 0.5f; // Düşme hızının kademeli olarak artış miktarı
        float maksimumYercekimi = 10f; // Kuşun düşebileceği maksimum hız
        int score = 0;
        int highestScore = 0; // En yüksek skoru tutan değişken
        Random rnd = new Random();
        bool oyunBitti = false; // Oyun durumunu takip eden değişken

        public Form1()
        {
            InitializeComponent();
            scoreText.Text = "SCORE : " + score; // Başlangıç skoru
            highestScoreText.Text = "HIGHEST SCORE : " + highestScore; // Başlangıç en yüksek skoru
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (oyunBitti) return; // Eğer oyun bittiyse, geri kalan işlemleri yapma

            // Yerçekimi etkisini artırarak kuşun daha pürüzsüz bir şekilde düşmesini sağlıyoruz.
            if (yercekimi < maksimumYercekimi)
            {
                yercekimi += ivme; // Yerçekimi hızını yavaş yavaş artırıyoruz.
            }

            Kuş.Top += (int)yercekimi; // Kuşun pozisyonunu güncelleyerek düşmesini sağlıyoruz.
            boruAlt.Left -= boruHızı; // Alt borunun sola doğru hareket etmesi
            boruUst.Left -= boruHızı; // Üst borunun sola doğru hareket etmesi
            scoreText.Text = "SCORE : " + score; // Skoru güncelliyoruz.

            if (boruAlt.Left < -60)
            {
                boruAlt.Left = rnd.Next(500, 601);
                boruAlt.Top = rnd.Next(300, 400);
                score++;
            }

            if (boruUst.Left < -60)
            {
                boruUst.Left = rnd.Next(500, 601);
                boruUst.Top = rnd.Next(-250, -150);
                score++;
            }

            // Kuşun borular veya zeminle çarpışmasını kontrol ediyoruz.
            if (Kuş.Bounds.IntersectsWith(boruAlt.Bounds) || Kuş.Bounds.IntersectsWith(boruUst.Bounds) || Kuş.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }

            if (Kuş.Top < -25) // Kuşun üst sınırdan çıkmasını kontrol ediyoruz.
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (oyunBitti)
                {
                    restartGame(); // Eğer oyun bittiyse, boşluk tuşuna basıldığında oyunu yeniden başlat
                }
                else
                {
                    yercekimi = -15f; // Kuşa yukarı doğru bir zıplama etkisi veriyoruz.
                }
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekimi = 1f; // Kuşun tekrar aşağı yönlü hareket etmesini sağlıyoruz.
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "GAME OVER !" + " " + "YENİDEN BAŞLAMAK İÇİN BOŞLUK TUŞUNA BASINIZ";
            oyunBitti = true; // Oyun bitti durumunu işaretle

            // En yüksek skoru güncelle
            if (score > highestScore)
            {
                highestScore = score;
                highestScoreText.Text = "HIGHEST SCORE : " + highestScore; // En yüksek skoru güncelle ve ekrana yazdır
            }
        }

        private void restartGame()
        {
            oyunBitti = false; // Oyun durumu sıfırlanır
            yercekimi = 1f; // Yerçekimini başlangıç değerine getir
            score = 0; // Skoru sıfırla
            scoreText.Text = "SCORE : " + score; // Skoru güncelle
            Kuş.Top = 100; // Kuşun başlangıç pozisyonu
            boruAlt.Left = 800; // Alt borunun başlangıç pozisyonu
            boruUst.Left = 800; // Üst borunun başlangıç pozisyonu
            boruAlt.Top = rnd.Next(250, 450);
            boruUst.Top = rnd.Next(-250, -150);
            gameTimer.Start(); // Zamanlayıcıyı yeniden başlat
        }
    }
}
