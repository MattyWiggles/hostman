using System;
using System.Linq;

namespace HostLists.Entities
{
  public class Profile
  {
    public int RecordId { get; set; }
    public string ProfileName { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; }

  }
}
