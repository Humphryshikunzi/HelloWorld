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
	public partial class Picker : ContentPage
	{
		public Picker ()
		{
			InitializeComponent ();
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactmethod = Contactmethod.Items[Contactmethod.SelectedIndex];
            DisplayAlert("Selection", contactmethod, "Okay");
        }

	 async   private void Button_OnClicked(object sender, EventArgs e)
	 {
	     await Navigation.PushModalAsync(new Stepper());
	 }

	async    private void Button_OnClicked1(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync();
	    }
	}
}