using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_World_Flyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome to Xamarin.Forms!";
        }

        public Page1(MainPageFlyoutInitItem initData) : this()
        {
            lblWelcome.Text = initData.SomeInitData;
        }
    }
}