// Using .NET
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

// Using Prism
using Prism.Ioc;
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
  }
}