using FirstMauiApp.ViewModel;

namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        MainViewModel mwm = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            //
            BindingContext = mwm;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
