namespace Contacts.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); //specific cal of main page "appshell".it is created by default.
        }
    }
}
