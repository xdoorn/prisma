using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Interfaces;

namespace Prisma.Warehouse.ViewModels
{
  public class MainViewModel : ModelBase, IMainModule
  {
    public string Title 
    {
      get { return GetProperty<string>("Warehouse"); }
      set { SetProperty(value); }
    }
  }
}
