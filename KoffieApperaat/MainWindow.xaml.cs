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

namespace KoffieApperaat
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

        private void koffie_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.Blue;
            espresso.Background = Brushes.LightGray;
            cappiccino.Background = Brushes.LightGray;
            caffelatte.Background = Brushes.LightGray;
            caffemachiato.Background = Brushes.LightGray;
            caffelattemachiato.Background = Brushes.LightGray;
            caffemocha.Background = Brushes.LightGray;
        }

        private void espresso_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.LightGray;
            espresso.Background = Brushes.Blue;
            cappiccino.Background = Brushes.LightGray;
            caffelatte.Background = Brushes.LightGray;
            caffemachiato.Background = Brushes.LightGray;
            caffelattemachiato.Background = Brushes.LightGray;
            caffemocha.Background = Brushes.LightGray;
        }

        private void cappiccino_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.LightGray;
            espresso.Background = Brushes.LightGray;
            cappiccino.Background = Brushes.Blue;
            caffelatte.Background = Brushes.LightGray;
            caffemachiato.Background = Brushes.LightGray;
            caffelattemachiato.Background = Brushes.LightGray;
            caffemocha.Background = Brushes.LightGray;
        }

        private void caffelatte_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.LightGray;
            espresso.Background = Brushes.LightGray;
            cappiccino.Background = Brushes.LightGray;
            caffelatte.Background = Brushes.Blue;
            caffemachiato.Background = Brushes.LightGray;
            caffelattemachiato.Background = Brushes.LightGray;
            caffemocha.Background = Brushes.LightGray;
        }

        private void caffemachiato_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.LightGray;
            espresso.Background = Brushes.LightGray;
            cappiccino.Background = Brushes.LightGray;
            caffelatte.Background = Brushes.LightGray;
            caffemachiato.Background = Brushes.Blue;
            caffelattemachiato.Background = Brushes.LightGray;
            caffemocha.Background = Brushes.LightGray;
        }

        private void caffelattemachiato_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.LightGray;
            espresso.Background = Brushes.LightGray;
            cappiccino.Background = Brushes.LightGray;
            caffelatte.Background = Brushes.LightGray;
            caffemachiato.Background = Brushes.LightGray;
            caffelattemachiato.Background = Brushes.Blue;
            caffemocha.Background = Brushes.LightGray;
        }

        private void caffemocha_Click(object sender, RoutedEventArgs e)
        {
            koffie.Background = Brushes.LightGray;
            espresso.Background = Brushes.LightGray;
            cappiccino.Background = Brushes.LightGray;
            caffelatte.Background = Brushes.LightGray;
            caffemachiato.Background = Brushes.LightGray;
            caffelattemachiato.Background = Brushes.LightGray;
            caffemocha.Background = Brushes.Blue;
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            int melkvalue2 = int.Parse(melkvalue.Text);
            melkvalue2--;
            if (melkvalue2 == 0)
            {
                min.IsEnabled = false;
            }
            else
            {
                min.IsEnabled = true;
                plus1.IsEnabled = true;
            }
            melkvalue.Text = melkvalue2.ToString();
        }
        private void plus1_Click(object sender, RoutedEventArgs e)
        {
            int melkvalue2 = int.Parse(melkvalue.Text);
            melkvalue2++;
            if (melkvalue2 == 5)
            {
                plus1.IsEnabled = false;
            }
            else
            {
                plus1.IsEnabled = true;
                min.IsEnabled = true;
            }
            melkvalue.Text = melkvalue2.ToString();
        }

        private void plus2_Click(object sender, RoutedEventArgs e)
        {
            int suikervalue2 = int.Parse(suikervalue.Text);
            suikervalue2++;
            if (suikervalue2 == 5)
            {
                plus2.IsEnabled = false;
            }
            else
            {
                plus2.IsEnabled = true;
                min1.IsEnabled = true;
            }
            suikervalue.Text = suikervalue2.ToString();
        }

        private void min1_Click(object sender, RoutedEventArgs e)
        {
            int suikervalue2 = int.Parse(suikervalue.Text);
            suikervalue2--;
            if (suikervalue2 == 0)
            {
                min1.IsEnabled = false;
            }
            else
            {
                min1.IsEnabled = true;
                plus2.IsEnabled = true;
            }
            suikervalue.Text = suikervalue2.ToString();
        }

        private void minusminus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.Blue;
            minus.Background = Brushes.LightGray;
            middle.Background = Brushes.LightGray;
            plus.Background = Brushes.LightGray;
            plusplus.Background = Brushes.LightGray;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.LightGray;
            minus.Background = Brushes.Blue;
            middle.Background = Brushes.LightGray;
            plus.Background = Brushes.LightGray;
            plusplus.Background = Brushes.LightGray;
        }

        private void middle_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.LightGray;
            minus.Background = Brushes.LightGray;
            middle.Background = Brushes.Blue;
            plus.Background = Brushes.LightGray;
            plusplus.Background = Brushes.LightGray;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.LightGray;
            minus.Background = Brushes.LightGray;
            middle.Background = Brushes.LightGray;
            plus.Background = Brushes.Blue;
            plusplus.Background = Brushes.LightGray;
        }

        private void plusplus_Click(object sender, RoutedEventArgs e)
        {
            minusminus.Background = Brushes.LightGray;
            minus.Background = Brushes.LightGray;
            middle.Background = Brushes.LightGray;
            plus.Background = Brushes.LightGray;
            plusplus.Background = Brushes.Blue;
        }

        private void order_Click(object sender, RoutedEventArgs e)
        {
            if (minusminus.Background == Brushes.Blue)
            {
                if (koffie.Background == Brushes.Blue)
                {
                    string soortkoffie = "Koffie";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (espresso.Background == Brushes.Blue)
                {
                    string soortkoffie = "Espresso";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (cappiccino.Background == Brushes.Blue)
                {
                    string soortkoffie = "Cappiccino";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelatte.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelattemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemocha.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Mocha";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else
                {
                    MessageBox.Show("Er is geen koffie geselecteerd");
                }
            }
            else if (minus.Background == Brushes.Blue)
            {
                if (koffie.Background == Brushes.Blue)
                {
                    string soortkoffie = "Koffie";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (espresso.Background == Brushes.Blue)
                {
                    string soortkoffie = "Espresso";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (cappiccino.Background == Brushes.Blue)
                {
                    string soortkoffie = "Cappiccino";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelatte.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelattemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemocha.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Mocha";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else
                {
                    MessageBox.Show("Er is geen koffie geselecteerd");
                }
            }
            else if (middle.Background == Brushes.Blue)
            {
                if (koffie.Background == Brushes.Blue)
                {
                    string soortkoffie = "Koffie";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (espresso.Background == Brushes.Blue)
                {
                    string soortkoffie = "Espresso";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (cappiccino.Background == Brushes.Blue)
                {
                    string soortkoffie = "Cappiccino";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelatte.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelattemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemocha.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Mocha";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else
                {
                    MessageBox.Show("Er is geen koffie geselecteerd");
                }
            }
            else if (plus.Background == Brushes.Blue)
            {
                if (koffie.Background == Brushes.Blue)
                {
                    string soortkoffie = "Koffie";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (espresso.Background == Brushes.Blue)
                {
                    string soortkoffie = "Espresso";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (cappiccino.Background == Brushes.Blue)
                {
                    string soortkoffie = "Cappiccino";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelatte.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelattemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemocha.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Mocha";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else
                {
                    MessageBox.Show("Er is geen koffie geselecteerd");
                }
            }
            else if (plusplus.Background == Brushes.Blue)
            {
                if (koffie.Background == Brushes.Blue)
                {
                    string soortkoffie = "Koffie";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (espresso.Background == Brushes.Blue)
                {
                    string soortkoffie = "Espresso";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (cappiccino.Background == Brushes.Blue)
                {
                    string soortkoffie = "Cappiccino";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelatte.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffelattemachiato.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Latte Machiato";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else if (caffemocha.Background == Brushes.Blue)
                {
                    string soortkoffie = "Caffe Mocha";
                    MessageBox.Show("Geniet van uw lekkere kop " + soortkoffie + " met " + suikervalue.Text + " hoeveelheden suiker en " + melkvalue.Text + " hoeveelheden melk!");
                }
                else
                {
                    MessageBox.Show("Er is geen koffie geselecteerd");
                }
            }
            else
            {
                MessageBox.Show("Er is geen sterkste geselcteerd.");
            }
        }
    }
}
