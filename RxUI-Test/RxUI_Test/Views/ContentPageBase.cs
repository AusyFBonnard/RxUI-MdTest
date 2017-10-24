using ReactiveUI.XamForms;

namespace RxUI_Test.Views
{
    public abstract class ContentPageBase<TViewModel> : ReactiveContentPage<TViewModel>
        where TViewModel : class
    {
    }
}
