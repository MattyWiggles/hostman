using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HostLists.Entities;
using PropertyChanged;
using HostmanUI.Support;
using HostmanUI.Support.HostmanUI.Support;

namespace HostmanUI.ViewModels
{
    [ImplementPropertyChanged]
    public class MainWinViewModel
    {

        public MainWinViewModel()
        {
            EditSelectedProfileCommand = new RelayCommand(EditSelectedProfileExecuted, () => (SelectedProfile == null) ? false : true);
            AddNewProfileCommand = new RelayCommand(AddNewProfileExecuted);
        }

        public List<Profile> Profiles
        {
            get { return HostLists.HostLists.GetAllProfiles(); }
        }

        Profile _SelectedProfile;
        public Profile SelectedProfile 
        {
            get { return _SelectedProfile; } 
            set
            {
                _SelectedProfile = value;
                EditSelectedProfileCommand.Refresh();
            }
        }

        #region Commands

        public RelayCommand EditSelectedProfileCommand { get; private set; }

        ProfileEditWindow newProfileWindow;

        void EditSelectedProfileExecuted()
        {

            if (newProfileWindow != null)
                newProfileWindow.Close();

            newProfileWindow = new ProfileEditWindow(SelectedProfile);

            newProfileWindow.Show();

        }

        public RelayCommand AddNewProfileCommand { get; private set; }

        void AddNewProfileExecuted()
        {
            //Create the new profile and if success, open the profile in a new window to edit
            var newProfile = new Profile()
            {
                ProfileName = "Empty Profile",
                DateCreated = DateTime.Now,
            };

            if (HostLists.HostLists.AddNewProfile(newProfile))
            {
                if (newProfileWindow != null)
                    newProfileWindow.Close();

                newProfileWindow = new ProfileEditWindow(newProfile);
                newProfileWindow.Show();
            }

        }

        #endregion
    }
}
