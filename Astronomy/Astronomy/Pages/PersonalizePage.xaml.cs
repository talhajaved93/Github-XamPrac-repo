using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astronomy.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonalizePage : ContentPage
	{
		public PersonalizePage ()
		{
			InitializeComponent ();

            btnSave.Clicked += BtnSaveClicked;
            btnCancel.Clicked += BtnCancelClicked;
		}

        async void BtnCancelClicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        async void BtnSaveClicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = entryName.Text;
            Application.Current.Properties["Icon"] = pickerIcon.SelectedItem as string;


            await Application.Current.SavePropertiesAsync();

            await this.Navigation.PopModalAsync()
        }

    }
}