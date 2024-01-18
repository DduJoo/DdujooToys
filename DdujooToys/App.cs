
using Jamesnet.Wpf.Controls;
using MainFrame.Forms.UI;
using System.Windows;


namespace DdujooToys
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new MainView();
        }        
    }
}
