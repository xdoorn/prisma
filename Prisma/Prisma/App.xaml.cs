// Using .NET
using System;
using System.Windows;

// Using Prism
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Prisma.Infrastructure.Browser.Interfaces;
using Prisma.Infrastructure.Browser.Models;

// Using Prisma
using Prisma.Views;

namespace Prisma
{
  /// <summary>
  ///   Interaction logic for App.xaml
  ///   
  ///   For PrismApplication <see cref="https://prismlibrary.com/docs/wpf/getting-started.html"/>
  /// </summary>
  public partial class App : PrismApplication
  {
    protected override Window CreateShell()
    {
      var shell = Container.Resolve<Shell>();
      return shell;
    }


    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterSingleton<IBrowsableObjectService, BrowsableObjectService>();
    }


    protected override IModuleCatalog CreateModuleCatalog()
    {
      return new ConfigurationModuleCatalog();
    }
  }
}
