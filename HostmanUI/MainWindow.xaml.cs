using HostmanUI.ViewModels;
using PropertyChanged;
using System.Windows;
using System.Windows.Input;

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

        private void CloseButtonClicked(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void TitleBarLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
