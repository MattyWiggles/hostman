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
    }

    private void ProfileListDoubleClicked(object sender, MouseButtonEventArgs e)
    {
        if (this.DataContext is MainWinViewModel)
        {
            var mainWindowVM = (MainWinViewModel)this.DataContext;

            if (mainWindowVM.EditSelectedProfileCommand.CanExecute(null))
            {
                mainWindowVM.EditSelectedProfileCommand.Execute(null);
            }

        }

    }
  }
}
