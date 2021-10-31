using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Interfaces;

namespace Prisma.Warehouse.ViewModels
{
  public class MainViewModel : ModelBase, IMainModule, INavigationAware
  {
    public MainViewModel(IRegionManager i_regionManager)
    {
    }


    public string Title
    {
      get { return GetProperty<string>("Warehouse"); }
      set { SetProperty(value); }
    }


    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
      return true;
    }


    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }


    public void OnNavigatedTo(NavigationContext navigationContext)
    {
    }
  }
}
