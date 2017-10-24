using RxUI_Test.ViewModels;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RxUI_Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ReactiveUI.XamForms.ReactiveMasterDetailPage<MainViewModel>, IScreen
    {
        public RoutingState Router { get; }

        public MainView()
        {
            Router = new RoutingState();
            Router.NavigationStack.Add(new HomeViewModel());
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));            

            InitializeComponent();

            var viewHost = new ReactiveUI.XamForms.RoutedViewHost { Router = this.Router };
            Detail = viewHost as NavigationPage;
        }
    }
}