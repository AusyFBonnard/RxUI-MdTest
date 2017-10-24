using RxUI_Test.ViewModels;
using Xamarin.Forms.Xaml;
using Splat;
using Xamarin.Forms;

namespace RxUI_Test.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPageBase<HomeViewModel>
	{
        public HomeView()
        {
            InitializeComponent();

            ViewModel = ViewModel ?? Locator.Current.GetService<HomeViewModel>();
        }
    }
}