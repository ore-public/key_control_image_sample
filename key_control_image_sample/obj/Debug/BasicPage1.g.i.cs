﻿

#pragma checksum "C:\Users\雅也\Documents\Visual Studio 11\Projects\key_control_image_sample\key_control_image_sample\BasicPage1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5B5AEEB48BBDF1537C269B9F4B9C0D92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace key_control_image_sample
{
    public partial class BasicPage1 : key_control_image_sample.Common.LayoutAwarePage
    {
        private key_control_image_sample.Common.LayoutAwarePage pageRoot;
        private Windows.UI.Xaml.Controls.Canvas canv1;
        private Windows.UI.Xaml.Shapes.Rectangle rect;
        private Windows.UI.Xaml.Controls.Button backButton;
        private Windows.UI.Xaml.Controls.TextBlock pageTitle;
        private Windows.UI.Xaml.VisualState FullScreenLandscape;
        private Windows.UI.Xaml.VisualState Filled;
        private Windows.UI.Xaml.VisualState FullScreenPortrait;
        private Windows.UI.Xaml.VisualState Snapped;
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///BasicPage1.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (key_control_image_sample.Common.LayoutAwarePage)this.FindName("pageRoot");
            canv1 = (Windows.UI.Xaml.Controls.Canvas)this.FindName("canv1");
            rect = (Windows.UI.Xaml.Shapes.Rectangle)this.FindName("rect");
            backButton = (Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            FullScreenLandscape = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenLandscape");
            Filled = (Windows.UI.Xaml.VisualState)this.FindName("Filled");
            FullScreenPortrait = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenPortrait");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
        }
    }
}



