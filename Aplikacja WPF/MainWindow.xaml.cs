using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfKosc
{
    public partial class MainWindow : Window
    {
        List<Kosc> kosci = new List<Kosc>();
        Image[] obrazy;

        public MainWindow()
        {
            InitializeComponent();
            obrazy = new Image[] { Img0, Img1, Img2, Img3, Img4 };
            for (int i = 0; i < 5; i++) kosci.Add(new Kosc(0));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                if (kosci[i].CzyDostepna) kosci[i].Rzut();
                obrazy[i].Source = new BitmapImage(new Uri($"kosc{kosci[i].LiczbaOczek}.png", UriKind.Relative));
                suma += kosci[i].LiczbaOczek;
            }
            TxtWynik.Text = suma.ToString();
        }

        private void Image_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            int index = int.Parse(img.Name.Substring(3));

            if (kosci[index].CzyDostepna)
            {
                kosci[index].Blokuj();
                img.Opacity = 0.5;
            }
            else
            {
                kosci[index].CzyDostepna = true;
                img.Opacity = 1.0;
            }
        }
    }
}