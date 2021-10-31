using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Interfaces;

namespace Prisma.Studio.ViewModels
{
  public class MainViewModel : ModelBase, IMainModule
  {
    public string Title 
    { 
      get => GetProperty<string>("Studio"); 
      set => SetProperty(value);
    }
  }
}
