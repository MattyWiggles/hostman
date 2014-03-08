using System;
using System.Linq;

namespace HostLists.Entities
{
  public class HostEntry
  {
    public int RecordId { get; set; }
    public string IpAddress { get; set; }
    public string DomainName { get; set; }
    public int ProfileId { get; set; }
    public bool IsActive { get; set; }

  }
}
