using Prism.Events;
using Prisma.Infrastructure.Browser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisma.Infrastructure.Browser.Events
{
  public class BrowsableObjectSelectedEvent : PubSubEvent<IBrowsableObject>
  {
  }
}
