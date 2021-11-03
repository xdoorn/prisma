using Prisma.Infrastructure.Application.Models;
using Prisma.Infrastructure.Browser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Infrastructure.Browser.Models
{
  public class BrowsableObject : ModelBase, IBrowsableObject
  {
    public string DisplayName { get => GetProperty<string>(); set => SetProperty(value); }
    public string FilePath { get => GetProperty<string>(); set => SetProperty(value); }
  }
}
