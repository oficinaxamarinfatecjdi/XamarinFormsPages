using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesProject.MasterDetailPageFolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailPageMain : MasterDetailPage
	{
		public MasterDetailPageMain ()
		{
			InitializeComponent ();

            this.Master = new MasterPagina();
            this.Detail = new NavigationPage(new DetailPagina());
		}
	}
}