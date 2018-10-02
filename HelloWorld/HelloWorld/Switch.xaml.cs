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
	public partial class Switch : ContentPage
	{
		public Switch ()
		{
			InitializeComponent ();
		}

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            label.IsVisible = e.Value;
        }

	 async   private void Button_OnClicked(object sender, EventArgs e)
	 {
	     await Navigation.PushModalAsync(new TableView());
	 }

	   async private void Button_OnClicked1(object sender, EventArgs e)
	   {
	       await Navigation.PopModalAsync();
	   }
	}
}