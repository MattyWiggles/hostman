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
    public class MainWinViewModel
    {

        public MainWinViewModel()
        {
            _EditSelectedProfileCommand = new Command(e => EditSelectedProfileExecuted(), e => (SelectedProfile == null) ? false : true);
            _AddNewProfileCommand = new Command(e => AddNewProfileExecuted());
        }

        public List<Profile> Profiles
        {
            get { return HostLists.HostLists.GetAllProfiles(); }
        }

        public Profile SelectedProfile { get; set; }

        #region Commands

        Command _EditSelectedProfileCommand;
        public Command EditSelectedProfileCommand
        {
            get { return _EditSelectedProfileCommand; }
        }

        ProfileEditWindow newProfileWindow;

        void EditSelectedProfileExecuted()
        {

            if (newProfileWindow != null)
                newProfileWindow.Close();

            newProfileWindow = new ProfileEditWindow(SelectedProfile);

            newProfileWindow.Show();

        }

        Command _AddNewProfileCommand;
        public Command AddNewProfileCommand
        {
            get { return _AddNewProfileCommand; }
        }


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
