using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The WindowBase class serves as the base class for windows in the Tutoring Company GUI application.
    /// It provides common functionality for window management, such as drag-and-drop, minimize, and close operations.
    /// </summary>
    abstract public class WindowBase : Window
    {
        /// <summary>
        /// Event handler for minimizing the window.
        /// </summary
        private void MinimizeWindow(object sender, RoutedEventArgs e) { WindowState = WindowState.Minimized; }
        /// <summary>
        /// Event handler for closing the window.
        /// </summary>
        private void CloseWindow(object sender, RoutedEventArgs e) { Close(); }
        /// <summary>
        /// Event handler for dragging the window.
        /// </summary>
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
        // protected abstract ContentControl abstractTitleContent { get; set; }
        /// <summary>
        /// Sets up the title bar of the window.
        /// </summary>
        /// <param name="abstractTitleGrid">The abstract title grid to be configured.</param>
        /// <param name="title">The title of the window.</param>
        public void TitleBar(ContentControl AbstractTitleGrid, string title)
        {
            if (AbstractTitleGrid.Content is Grid TitleGrid)
            {
                TitleGrid.MouseLeftButtonDown += DragWindow;

                if (TitleGrid.Children[0] is TextBlock textBlock) { textBlock.Text = title; }

                if (TitleGrid.Children[1] is StackPanel stackPanel)
                {
                    if (stackPanel.Children[0] is Button minimizeButton) { minimizeButton.Click += MinimizeWindow; }
                    if (stackPanel.Children[1] is Button closeButton) { closeButton.Click += CloseWindow; }
                }
            }
        }
    }
}
