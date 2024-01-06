using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TutoringCompanyGUI {
    abstract public class WindowBase : Window {
        private void MinimizeWindow(object sender, RoutedEventArgs e) { WindowState = WindowState.Minimized; }
        private void CloseWindow(object sender, RoutedEventArgs e) { Close(); }
        private void DragWindow(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
        // protected abstract ContentControl abstractTitleContent { get; set; }
        public void TitleBar(ContentControl AbstractTitleGrid, string title) {
            if (AbstractTitleGrid.Content is Grid TitleGrid) {
                TitleGrid.MouseLeftButtonDown += DragWindow;

                if (TitleGrid.Children[0] is TextBlock textBlock) { textBlock.Text = title; }

                if (TitleGrid.Children[1] is StackPanel stackPanel) {
                    if (stackPanel.Children[0] is Button minimizeButton) { minimizeButton.Click += MinimizeWindow; }
                    if (stackPanel.Children[1] is Button closeButton) { closeButton.Click += CloseWindow; }
                }
            }
        }
    }
}
