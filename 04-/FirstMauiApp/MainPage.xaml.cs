using FirstMauiApp.ViewModel;
using Plugin.Maui.Audio; //Add this

namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        MainViewModel mwm = new MainViewModel();
        private readonly IAudioManager audioManager;
        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();
            //
            BindingContext = mwm;
            this.audioManager = audioManager;
        }

        private async void OnPlayClicked(object sender, EventArgs e)
        {

            using var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("BeMyLover.mp3"));
            player.Play();


            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
