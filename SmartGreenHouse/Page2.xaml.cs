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
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
            btnNazadNarudzba.Click += BtnNazadNarudzba_Click;
            btnDodaj.Click += BtnDodaj_Click;
            cbSort.SelectedIndex = 0;

        }

        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            lvKosarica.Items.Add(txtKolicina.Text + "x " + (cbSort.SelectedItem as ComboBoxItem).Content);
        }

        private void BtnNazadNarudzba_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Page1();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
