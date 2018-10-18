using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace androidform
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : MasterDetailPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            Detail = new NavigationPage(new Page2());
            IsPresented = false;
        }


        void linker(object sender,System.EventArgs e) {

            Detail = new NavigationPage( new Page2());
            IsPresented = false;


        }

        void linker2(object sender, System.EventArgs e)
        {

            Detail = new NavigationPage(new Page3());
            IsPresented = false;


        }

    }
}