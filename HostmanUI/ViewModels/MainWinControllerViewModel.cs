using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HostLists.Entities;
using PropertyChanged;

namespace HostmanUI.ViewModels
{
    [ImplementPropertyChanged]
    public class MainWinControllerViewModel
    {
        public List<Profile> Profiles
        {
            get { return HostLists.HostLists.GetAllProfiles(); }
        }


        public Profile SelectedProfile { get; set; }
    }
}
