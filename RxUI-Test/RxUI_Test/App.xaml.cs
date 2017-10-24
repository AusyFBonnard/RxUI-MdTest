using RxUI_Test.Views;

using Xamarin.Forms;

namespace RxUI_Test
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var appBoot = new AppBootstrapper();

            MainPage = appBoot.CreateMainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
