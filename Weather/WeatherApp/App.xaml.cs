using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        
        

     
    }
  
    protected override async void OnStart()
        {
            // Handle when your app starts

            // show the splash
            MainPage = new WelcomePage();
            // simple wait or initialize some services
            await Task.Delay(10000);
            // show the real page
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
