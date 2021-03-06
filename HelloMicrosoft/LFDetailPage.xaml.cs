﻿using HelloMicrosoft.Models;
using HelloMicrosoft.Resources;
using HelloMicrosoft.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloMicrosoft
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LFDetailPage : Page
    {
        APPTheme AppTheme = new APPTheme();
        LFDetailPageViewModel VM;
        LFDetailPageModel Model = new LFDetailPageModel();
        public LFDetailPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            var temp = e.Parameter as string;
            VM = await Model.GetDetail(temp);
        }
    }
}
