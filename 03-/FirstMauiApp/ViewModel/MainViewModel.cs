using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string color;

        [ObservableProperty]
        ObservableCollection<string> colorItems;

        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity)
        {
            ColorItems = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [RelayCommand]
        async Task AddColor()
        {
            //Checking network connection 
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                //Show up a pop-up
                //"Shell" --> Common Structure
                await Shell.Current.DisplayAlert("Error", "No Internet connection", "OK");
                return;
            }
            ColorItems.Add(Color);
            Color = string.Empty;
        }

        [RelayCommand]
        void DeleteColor(string colorName)
        {
            if(ColorItems.Contains(colorName))
            {
                if(ColorItems.Contains(colorName))
                {
                    ColorItems.Remove(colorName);
                }
            }
        }

    }
}
