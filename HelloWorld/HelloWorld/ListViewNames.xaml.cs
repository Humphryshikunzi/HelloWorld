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
	public partial class ListViewNames : ContentPage
	{
		public ListViewNames ()
		{
			InitializeComponent ();
            var names = new List<string>
            {
                "Humphry",
                "Doreen",
                "Lilian",
                "Chacha",
                "Faith"
            };
            listView.ItemsSource = names;
		}

       async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

      async  private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}