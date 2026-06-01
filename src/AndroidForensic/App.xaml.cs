using System.Windows;
namespace AndroidForensic
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            InitializeServices();
        }
        private void InitializeServices()
        {
            // TODO: Initialize DI, logging, AI services
        }
    }
}