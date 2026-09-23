using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1
{
    public partial class CharacterDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string detailText = "Let that be a lesson to ya! No chicken escapes from Tweety's farm.";


        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

    }
}
