using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Splat;
using RxUI_Test.ViewModels;

namespace RxUI_Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPageBase<MenuViewModel>
    {
        public MenuView()
        {
            InitializeComponent();

            ViewModel = ViewModel ?? Locator.Current.GetService<MenuViewModel>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ViewModel.HostScreen
                .Router
                .Navigate
                .Execute(new DetailViewModel())
                .Subscribe();
        }
    }
}