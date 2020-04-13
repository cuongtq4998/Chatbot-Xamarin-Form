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
	public partial class InforPage3 : ContentPage
	{
		public InforPage3 ()
		{
			InitializeComponent ();
		}
        private void Btn_chat_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChatPage());
        }
    }
}