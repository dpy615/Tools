using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Tools {
    public class MoveThumb : Thumb {

        public MoveThumb() {
            this.DragDelta += new DragDeltaEventHandler(this.MoveThump_DragDelta);
        }

        public void MoveThump_DragDelta(object sender, DragDeltaEventArgs e) {
            Control designerItem = this.DataContext as Control;

            if (designerItem != null) {
                double left = Canvas.GetLeft(designerItem);
                double top = Canvas.GetTop(designerItem);

                Canvas.SetLeft(designerItem, left + e.HorizontalChange);
                Canvas.SetTop(designerItem, top + e.VerticalChange);
            }

        }
    }
}
