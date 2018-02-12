using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
		}

        async void prevbtn3(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void nextbtn5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}