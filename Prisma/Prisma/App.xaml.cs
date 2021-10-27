// Using .NET
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;

// Using Prism
using Prism.Unity;


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
      // Nothing to register at the moment.
    }
  }
}
