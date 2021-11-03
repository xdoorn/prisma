using Prisma.Infrastructure.Browser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Infrastructure.Browser.Models
{
  public class BrowsableObjectService : IBrowsableObjectService
  {
    public IEnumerable<IBrowsableObject> GetBrowsableObjects()
    {
      // For now mock some data.
      yield return new BrowsableObject() { DisplayName = "My Games", FilePath = @"C:\User\Documents\Prisma\mygames.pgn" };
      yield return new BrowsableObject() { DisplayName = "Internet Games", FilePath = @"C:\User\Documents\Prisma\internetgames.pgn" };
      yield return new BrowsableObject() { DisplayName = "White Reportoire", FilePath = @"C:\User\Documents\Prisma\whitereportoire.pgn" };
      yield return new BrowsableObject() { DisplayName = "Black Reportoire", FilePath = @"C:\User\Documents\Prisma\blackreportoire.pgn" };
    }
  }
}
