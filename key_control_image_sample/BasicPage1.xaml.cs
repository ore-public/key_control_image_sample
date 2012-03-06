using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace key_control_image_sample
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage1 : key_control_image_sample.Common.LayoutAwarePage
    {
        public BasicPage1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Grid_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Windows.System.VirtualKey.Up)
            {
                rect.Height += 10;
                rect.Width += 10;
            }
            if (e.Key == Windows.System.VirtualKey.Down)
            {
                rect.Height -= 10;
                rect.Width -= 10;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            rect.Height += 10;
            rect.Width += 10;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            rect.Height -= 10;
            rect.Width -= 10;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var newRect = new Windows.UI.Xaml.Shapes.Rectangle();

            canv1.Children.Add(newRect);
            newRect.Height = 40;
            newRect.Width = 40;

        }
    }
}
