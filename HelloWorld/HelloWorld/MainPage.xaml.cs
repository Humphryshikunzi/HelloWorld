using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
         
            InitializeComponent();
           // slider.Value = 50;
            
        }

    
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
           
            label.Text = string.Format("Slider value {0:F2}", e.NewValue);
        }


        private void Button_OnClicked(object sender, EventArgs e)
        {
            StreamReader readfile=new StreamReader(@"C: \Users\user\source\repos\HelloWorld\HelloWorld\HelloWorld\New Text Document.txt");
            string value = readfile.ReadLine();
            int num = int.Parse(value);
            readfile.Close();
            int firstvalue = num;
            int secondvalue = 50;
            int sum= (firstvalue + secondvalue);
            string result = sum.ToString();
            DisplayAlert("Value",result,"Okay");
        }

     async   private void Button_OnClicked1(object sender, EventArgs e)
     {
         await Navigation.PushModalAsync( new Picker());
     }

   async     private void Button_OnClicked2(object sender, EventArgs e)
   {
       await Navigation.PopModalAsync();
   }
    }
}
