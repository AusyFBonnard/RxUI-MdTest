using ReactiveUI;
using RxUI_Test.ViewModels;
using RxUI_Test.Views;
using Splat;
using System;

namespace RxUI_Test
{
    public class AppBootstrapper : ReactiveObject
    {       
        public AppBootstrapper()
        {
            Locator.CurrentMutable.Register(() => new HomeViewModel(), typeof(HomeViewModel));
            Locator.CurrentMutable.Register(() => new MenuViewModel(), typeof(MenuViewModel));

            Locator.CurrentMutable.Register(() => new HomeView(), typeof(IViewFor<HomeViewModel>));
            Locator.CurrentMutable.Register(() => new DetailView(), typeof(IViewFor<DetailViewModel>));
        }

        public Xamarin.Forms.Page CreateMainPage()
        {
            return new MainView();
        }
    }
}
