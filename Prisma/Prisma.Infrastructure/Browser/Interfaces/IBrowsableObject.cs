using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Infrastructure.Browser.Interfaces
{
  public interface IBrowsableObject
  {
    public string DisplayName { get; set; }
    public string FilePath { get; set; }
  }
}
