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
using System.Net.Http;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace App7
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        
        public BlankPage1()
        {
            this.InitializeComponent();
            

        }
       
       
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoForward)
                Frame.GoForward();
            else
                Frame.Navigate(typeof(BlankPage2));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoForward)
                Frame.GoForward();
            else
                Frame.Navigate(typeof(BlankPage2));
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int a, b;
            string s;
            s = tx1.Text;
           a = Convert.ToInt32(s);
            
              int c = 84;
            b = a * c;
            tx2.Text = Convert.ToString(b);

           
        }

       
    }
}
