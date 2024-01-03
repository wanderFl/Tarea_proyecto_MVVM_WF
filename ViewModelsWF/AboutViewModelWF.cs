﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WanderEjerRepaso.ViewModelsWF
{
    internal class AboutViewModelWF
    {

    
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";
        public ICommand ShowMoreInfoCommand { get; }

        public AboutViewModelWF()
        {
            ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
        }

        async Task ShowMoreInfo() =>
            await Launcher.Default.OpenAsync(MoreInfoUrl);
    }
}
