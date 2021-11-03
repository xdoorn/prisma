using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Interfaces;

namespace Prisma.Warehouse.ViewModels
{
  public class MainViewModel : ModelBase, IMainModule
  {
    public MainViewModel()
    {
    }


    public string Title
    {
      get { return GetProperty<string>("Warehouse"); }
      set { SetProperty(value); }
    }
  }
}
