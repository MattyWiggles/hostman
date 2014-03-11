using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HostLists.Entities;
using PropertyChanged;
using HostmanUI.Support;

namespace HostmanUI.ViewModels
{
    [ImplementPropertyChanged]
    public class MainWinControllerViewModel
    {

        public MainWinControllerViewModel()
        {
            _EditSelectedProfile = new Command(c => EditSelectedProfileExecuted(), c => (SelectedProfile == null) ? false : true);
        }

        public List<Profile> Profiles
        {
            get { return HostLists.HostLists.GetAllProfiles(); }
        }

        public Profile SelectedProfile { get; set; }

        #region Commands

        Command _EditSelectedProfile;
        public Command EditSelectedProfile
        {
            get { return _EditSelectedProfile; }
        }

        ProfileEditWindow newProfileWindow;

        void EditSelectedProfileExecuted()
        {

            if (newProfileWindow != null)
                newProfileWindow.Close();

            newProfileWindow = new ProfileEditWindow(SelectedProfile.RecordId);

            newProfileWindow.Show();

        }

        #endregion
    }
}
