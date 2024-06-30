using FirstMauiApp.ViewModel;
using Microsoft.Maui.Networking;
using Plugin.Maui.Audio; //Add this

namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        MainViewModel mwm;
        private readonly IAudioManager audioManager;
        public MainPage(IAudioManager audioManager, IConnectivity connectivity)
        {
            InitializeComponent();
            //
            BindingContext = mwm;
            this.audioManager = audioManager;
            BindingContext = new MainViewModel(connectivity);
        }

        private async void OnPlayClicked(object sender, EventArgs e)
        {

            using var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("BeMyLover.mp3"));
            player.Play();
        }
        private async void OnChangeImageClicked(object sender, EventArgs e)
        {
            var stream = await myDrawing.GetImageStream(800, 200);

            // Create a MemoryStream to store the image data
            var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            memoryStream.Position = 0;  // Reset the stream position

            // Set the Image source
            myImage.Source = ImageSource.FromStream(() => memoryStream);
        }
    }

}
