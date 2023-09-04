using NovaTrakt.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace NovaTrakt.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private HomeViewModel hvm;
        public HomeView()
        {
            InitializeComponent();
        }

        private void homeView_Drop(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] dropped = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (hvm == null)
                    hvm = (HomeViewModel)DataContext;

                hvm.dropFiles(dropped);
            }
        }
    }
}
