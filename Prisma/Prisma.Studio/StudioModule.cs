using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prisma.Studio.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Studio
{
  public class StudioModule : IModule
  {
    public void RegisterTypes(IContainerRegistry i_containerRegistry)
    {
      i_containerRegistry.RegisterForNavigation<MainView>("StudioMainView");
    }


    public void OnInitialized(IContainerProvider i_containerProvider)
    {
      var regionManager = i_containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion("RibbonTabRegion", () => i_containerProvider.Resolve<RibbonTabView>());
    }
  }
}
