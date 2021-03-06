using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prisma.Warehouse.Models;
using Prisma.Warehouse.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Warehouse
{
  public class WarehouseModule : IModule
  {
    public void RegisterTypes(IContainerRegistry i_containerRegistry)
    {
      i_containerRegistry.RegisterForNavigation<MainView>("WarehouseMainView");
      i_containerRegistry.RegisterSingleton<WarehouseCommands>();
    }


    public void OnInitialized(IContainerProvider i_containerProvider)
    {
      var regionManager = i_containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion("RibbonTabRegion", () => i_containerProvider.Resolve<RibbonTabView>());
      regionManager.RegisterViewWithRegion("BrowserRegion", () => i_containerProvider.Resolve<BrowserView>());
      regionManager.RegisterViewWithRegion("BrowserDetailsRegion", () => i_containerProvider.Resolve<BrowserDetailsView>());
    }
  }
}
