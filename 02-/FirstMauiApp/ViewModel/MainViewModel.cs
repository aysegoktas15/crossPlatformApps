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

        public MainViewModel()
        {
            ColorItems = new ObservableCollection<string>();
        }

        [RelayCommand]
        void AddColor()
        {
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
