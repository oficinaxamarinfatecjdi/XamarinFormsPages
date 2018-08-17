using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PagesProject
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        //Click do botão para navegar para a Content Page
        private void ToContentPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageFolder.ContentPagePagina());
        }
        //Click do botão para navegar para a Tabbed Page
        private void ToTabbedPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPageFolder.TabbedPagePagina());
        }
        //Click do botão para navegar para a Carousel Page
        private void ToCarouselPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselPageFolder.CarouselPagePagina());
        }
        //Click do botão para navegar para a MasterDetail Page
        private void ToMasterDetailPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MasterDetailPageFolder.MasterDetailPageMain());
            //Para a MasterDetail Page utiliza-se o PushModelAsync, já que se usar o PushAsync irão aparecer 2 toolbars
        }
    }
}
