using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatBot.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InforPage2 : ContentPage
	{
		public InforPage2 ()
		{
			InitializeComponent ();
		}
        private void Btnnextinfor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InforPage3());
        }
    }
}