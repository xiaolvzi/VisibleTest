using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App15
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            bt.Clicked += Bt_Clicked;
		}

        private void Bt_Clicked(object sender, EventArgs e)
        {
            if (!Poll1.IsVisible)
            {
                Poll1.IsVisible = true;
                Poll1.Focus();
                return;
            }
        }
    }
}
