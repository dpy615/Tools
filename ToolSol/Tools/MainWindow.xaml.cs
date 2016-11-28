using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tools {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e) {

            Thumb control = (Thumb)sender;
            var cavs = control.DataContext as Control;

            double left = Canvas.GetLeft(cavs);
            double top = Canvas.GetTop(cavs);

            Canvas.SetLeft(cavs, left + e.HorizontalChange);
            Canvas.SetTop(cavs, top + e.VerticalChange);
        }
    }
}
