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
	public partial class RelativeLayout : ContentPage
	{
		public RelativeLayout ()
		{
			InitializeComponent ();
		}

	  async  private void Button_OnClicked(object sender, EventArgs e)
	  {
	      await Navigation.PushModalAsync(new Stepper());
	  }

	 async   private void Button_OnClicked1(object sender, EventArgs e)
	 {
	     await Navigation.PopModalAsync();
	 }
	}
}