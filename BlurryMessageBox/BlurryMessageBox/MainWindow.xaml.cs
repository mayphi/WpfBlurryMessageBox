using System.Windows;

namespace BlurryMessageBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "MyMessageBoxText", "MyCaption", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
        }
    }
}
