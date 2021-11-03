using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Infrastructure.Browser.Interfaces
{
  public interface IBrowsableObjectService
  {
    IEnumerable<IBrowsableObject> GetBrowsableObjects();
    IBrowsableObject AttachBrowsableObject();
  }
}
