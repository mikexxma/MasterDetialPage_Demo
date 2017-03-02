using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetialPage_MyTest
{
    public class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            Master = new MenuPage
            {
                Title = "Fuck"
            };
            //Detail = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.Red };

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage))) { BarBackgroundColor = Color.Red };
        }
    }
}
