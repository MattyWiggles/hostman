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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PropertyChanged;
using HostmanUI.ViewModels;

namespace HostmanUI
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  [ImplementPropertyChanged]
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      MWViewModel = new MainWinViewModel();
    }

    public MainWinViewModel MWViewModel { get; private set; }

    private void ProfileList_DoubleClicked(object sender, MouseButtonEventArgs e)
    {
        if (MWViewModel.EditSelectedProfileCommand.CanExecute(null))
            MWViewModel.EditSelectedProfileCommand.Execute(null);
    }

  }
}
