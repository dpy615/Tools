using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tools.Controls {
    /// <summary>
    /// TxtMerger.xaml 的交互逻辑
    /// </summary>
    public partial class TxtMerger : UserControl {
        public TxtMerger() {
            InitializeComponent();
        }

        private void ThisDraged(object sender, DragEventArgs e) {
            Control designerItem = this.DataContext as Control;

            if (designerItem != null) {
                double left = Canvas.GetLeft(designerItem);
                double top = Canvas.GetTop(designerItem);

                Canvas.SetLeft(designerItem, left + e.GetPosition(designerItem).X);
                Canvas.SetTop(designerItem, top + e.GetPosition(designerItem).Y);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
