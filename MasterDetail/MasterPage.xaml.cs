using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class MasterPage : ContentPage
    {
        static ListView menuListView;

        public static ListView MenuListView { get { return menuListView; } }
        public MasterPage()
        {
            InitializeComponent();
            MasterList.ItemsSource = new List<MenuItem>()
            {
                new MenuItem {
                    Name = "First Page",
                    Icon = "Icon",
                    TargeType = typeof(DetailPage)
                },
                new MenuItem {
                    Name = "Second Page",
                    Icon = "Icon",
                    TargeType = typeof(SecondPage)
                },
            };

            menuListView = MasterList;

        }
    }

    public class MenuItem {
        public string Name { get; set; }
        public string Icon { get; set; }
        public Type TargeType { get; set; }
    }
}
