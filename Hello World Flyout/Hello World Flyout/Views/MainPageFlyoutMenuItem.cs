using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_Flyout.Views
{
    public class MainPageFlyoutInitItem
    {
        //Used to initialize Forecas
        public string SomeInitData { get; set; }
    }
    public class MainPageFlyoutMenuItem
    {
        public MainPageFlyoutMenuItem()
        {
            TargetType = typeof(MainPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
        public MainPageFlyoutInitItem PageInit { get; set; }
    }
}