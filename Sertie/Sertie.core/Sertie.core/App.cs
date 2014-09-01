using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Sertie.core
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new CreateQuestionPage();
            //return new ContentPage
            //{
            //    Content = new Label
            //    {
            //        Text = "Hello Olga !",
            //        VerticalOptions = LayoutOptions.CenterAndExpand,
            //        HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    },
            //};
        }
    }
}
