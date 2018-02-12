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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        async void prevbtn2(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void nextbtn3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}