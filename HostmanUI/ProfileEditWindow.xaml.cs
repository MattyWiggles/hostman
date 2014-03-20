using HostLists.Entities;
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
        public ProfileEditWindow(Profile profile)
        {
            InitializeComponent();

            PEditViewModel = new ProfileEditViewModel(profile);
        }

        public ProfileEditViewModel PEditViewModel { get; private set; }
    }
}
