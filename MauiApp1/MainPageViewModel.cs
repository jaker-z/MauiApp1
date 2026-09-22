using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string labelText = "Welcome to cool pizza.";

        private string text1 = "Welcome to cool pizza.";
        private string text2 = "You pressed the button, Baby!";

        [ObservableProperty]
        private string buttonName = "Press the Button, Baby!";

        [ObservableProperty]
        private string entryText = string.Empty;

        [RelayCommand]
        async Task ChangeButtonAsync()
        {
            if (LabelText == text1)
                LabelText = text2;
            else
                LabelText = text1;           
        }

        [RelayCommand]
        async Task GetDetailsAsync()
        {
            //await Shell.Current.GoToAsync();
            return;
        }

    }
}
