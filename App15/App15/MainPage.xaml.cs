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
        int num=1;
		public MainPage()
		{
			InitializeComponent();
            bt.Clicked += Bt_Clicked;
		}

        private void Bt_Clicked(object sender, EventArgs e)
        {
            if (num == 1)
            {
                if (!Poll2.IsVisible)
                {
                    Poll2.IsVisible = true;
                    //Poll1.Focus();
                    num = 2;
                    return;
                }
            }
            else {

                if (!Poll3.IsVisible)
                {
                    Poll3.IsVisible = true;
                    //Poll1.Focus();
                    return;
                }
            }

        }
    }
}
