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
	public partial class TableView : ContentPage
	{
		public TableView ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

	 async   private void Button_OnClicked(object sender, EventArgs e)
	 {
	     await Navigation.PushModalAsync(new Stacklayout());
	 }

	   async private void Button_OnClicked1(object sender, EventArgs e)
	   {
	       await Navigation.PopModalAsync();
	   }
	}
}