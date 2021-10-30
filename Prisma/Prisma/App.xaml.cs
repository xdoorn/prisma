// Using .NET
using System;
using System.Windows;

// Using Prism
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

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
      containerRegistry.Register<Services.ICustomerStore, Services.DbCustomerStore>();
    }


    protected override IModuleCatalog CreateModuleCatalog()
    {
      return new XamlModuleCatalog(new Uri("/Prisma;component/ModuleCatalog.xaml", UriKind.Relative));
    }
  }
}
