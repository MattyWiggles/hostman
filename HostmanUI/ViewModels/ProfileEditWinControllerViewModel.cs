using HostLists.Entities;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace HostmanUI.ViewModels
{
    [ImplementPropertyChanged]
    public class ProfileEditWinControllerViewModel
    {
        int _ProfileID;

        public ProfileEditWinControllerViewModel(int ProfileID)
        {
            this._ProfileID = ProfileID;
        }

        public List<HostEntry> ProfileHostList 
        { 
            get { return HostLists.HostLists.GetHostListForProfileId(_ProfileID); } 
        }
    }
}
