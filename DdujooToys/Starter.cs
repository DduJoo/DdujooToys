using DdujooToys.Properties;
using System;

namespace DdujooToys
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            new App()
                .AddInversionModule<ViewModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
