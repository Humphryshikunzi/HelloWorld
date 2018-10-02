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
	public partial class Stacklayout : ContentPage
	{
		public Stacklayout ()
		{
			InitializeComponent ();
		}

      async  private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GridPage());
        }

       async private void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}