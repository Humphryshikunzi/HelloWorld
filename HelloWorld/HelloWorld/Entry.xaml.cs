using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Entry : ContentPage
	{
		public Entry ()
		{
			InitializeComponent ();
		}

	   async private void Button_OnClicked(object sender, EventArgs e)
	   {
	       await Navigation.PushModalAsync(new ListViewNames());
	   }

	   async private void Button_OnClicked1(object sender, EventArgs e)
	   {
	       await Navigation.PopModalAsync();
	   }
	}
}