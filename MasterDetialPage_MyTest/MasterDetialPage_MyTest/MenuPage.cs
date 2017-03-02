using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetialPage_MyTest
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Content = new StackLayout
            {
                
                Children = {
                    
                    new Label { Text = "I am the Menu page" },
                     new Label { Text = "I am the Menu page" },
                      new Label { Text = "I am the Menu page" }
                }
            };
        }
    }
}
