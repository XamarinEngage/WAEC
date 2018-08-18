using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            Master = new MasterPage();
            Detail = new NavigationPage(new DetailPage());
            MasterPage.MenuListView.ItemSelected += MenuListView_ItemSelected;

            InitializeComponent();
        }


        void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = sender as ListView;
            var menuItem = listView.SelectedItem as MenuItem;

            var page = (Page)Activator.CreateInstance(menuItem.TargeType);
            Detail = new NavigationPage(page);
            IsPresented = false;
        }

    }
}
