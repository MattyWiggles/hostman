using HostmanUI.ViewModels;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HostmanUI
{
    /// <summary>
    /// Interaction logic for ProfileEditWindow.xaml
    /// </summary>
    [ImplementPropertyChanged]
    public partial class ProfileEditWindow : Window
    {
        public ProfileEditWindow(int ProfileID)
        {
            InitializeComponent();

            PEditViewModel = new ProfileEditWinControllerViewModel(ProfileID);
        }

        public ProfileEditWinControllerViewModel PEditViewModel { get; private set; }
    }
}
