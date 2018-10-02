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
    public partial class ApplicationProperties : ContentPage
    {
        public ApplicationProperties()
        {
            InitializeComponent();
            if(Application.Current.Properties.ContainsKey("Name"))
            title.Text = Application.Current.Properties["Name"].ToString();
            if (Application.Current.Properties.ContainsKey("two"))
                two.Text = Application.Current.Properties["two"].ToString();
            if (Application.Current.Properties.ContainsKey("notificationsEnabled"))
            notificationsEnabled.On = (bool) Application.Current.Properties["notificationsEnabled"];
        }

      
        private void Onchange(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["two"] = two.Text;
            Application.Current.Properties["notificationsEnabled"] = notificationsEnabled.On;

           // Application.Current.SavePropertiesAsync();
        }

        protected  override void OnDisappearing()
        {
             base.OnDisappearing();
        }

       async private void Button_OnClicked(object sender, EventArgs e)
       {
           await Navigation.PushModalAsync(new CleanApplicationProperties());
       }

      async  private void Button_OnClicked1(object sender, EventArgs e)
      {
          await Navigation.PopModalAsync();
      }
    }
}