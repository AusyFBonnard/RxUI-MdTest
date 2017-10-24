using RxUI_Test.ViewModels;
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
	public partial class DetailView : ContentPageBase<DetailViewModel>
	{
		public DetailView ()
		{
			InitializeComponent ();
		}
	}
}