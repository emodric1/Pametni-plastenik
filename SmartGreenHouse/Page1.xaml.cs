using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartGreenHouse
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
            btnIzmijeniSadnice.Click += BtnIzmijeniSadnice_Click;
            upisiNarudzbu.Click += UpisiNarudzbu_Click;
            cbIzvjestaj.SelectionChanged += CbIzvjestaj_SelectionChanged;
            Exit.Click += Exit_Click;
         }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void CbIzvjestaj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var name = ((sender as ComboBox).SelectedItem as ComboBoxItem).Name;
            if (name == "IzvjestajProdaja")
            {
                this.Content = new Page5();
            }
            else {
                this.Content = new Page4();
            }
        }

        private void UpisiNarudzbu_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Page2();
        }

        private void BtnIzmijeniSadnice_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Page3();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



    }
}
