using System;
using System.Collections.Generic;
using System.Linq;
using HostLists.Entities;

namespace HostLists
{
  public class HostLists
  {
    public HostLists()
    {
      // CTOR
      // Lets check if the db exists here, and if it does not then we should create it and make sure we have empty tables ready to work with
    }

    public static List<Profile> GetAllProfiles()
    {
      // Mocked up for now
      return new List<Profile>{
        new Profile { RecordId = 1, ProfileName = "Profile 1", Description = "Test profile used during development", DateCreated = DateTime.Now },
        new Profile { RecordId = 2, ProfileName = "Profile 2", Description = "Test profile used during development", DateCreated = DateTime.Now },
        new Profile { RecordId = 3, ProfileName = "Profile 3", Description = "Test profile used during development", DateCreated = DateTime.Now },
        new Profile { RecordId = 4, ProfileName = "Profile 4", Description = "Test profile used during development", DateCreated = DateTime.Now }
      };
    }

    public static Profile GetSingleProfile(int profileId)
    {
      // Mocked up for now
      return new Profile { RecordId = profileId, ProfileName = "Profile " + profileId.ToString(), Description = "Test profile used during development", DateCreated = DateTime.Now };
    }

    public static List<HostEntry> GetHostListForProfileId(int profileId)
    {
      // Mocked up for now
      return new List<HostEntry>{
        new HostEntry { RecordId = 1, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true},
        new HostEntry { RecordId = 2, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true},
        new HostEntry { RecordId = 3, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true},
        new HostEntry { RecordId = 4, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true},
        new HostEntry { RecordId = 5, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true},
        new HostEntry { RecordId = 6, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true},
        new HostEntry { RecordId = 7, IpAddress = "1.2.3.4", DomainName = "some.other_site.com", ProfileId = profileId, IsActive = true}
      };
    }

    public static bool AddNewProfile(Profile newProfile)
    {
      // Return true for success, false for fail
      return true;
    }

    public static bool UpdateProfile(Profile newProfile)
    {
      // Return true for success, false for fail
      return true;
    }

    public static bool DeleteProfile(int profileId)
    {
      // Return true for success, false for fail
      // NOTE: 2 things need to happen here, we need to not only remove the profile from the db
      // but we also need to find and delete any entries in the hosts lists belonging to this profile too
      return true;
    }

    public static bool SaveHostList(List<HostEntry> hostList)
    {
      // Return true for success, false for fail
      return true;
    }

    public static bool UpdateHostEntry(HostEntry hostEntry)
    {
      // Return true for success, false for fail
      return true;
    }

  }
}
