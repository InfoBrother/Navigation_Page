using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Page
{

	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
			InitializeComponent ();
		}

        async void prevbtn4(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}