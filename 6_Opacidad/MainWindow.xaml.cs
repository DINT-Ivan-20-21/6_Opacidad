using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _6_Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void entrar_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 1f;
        }

        private void salir_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 0.5f;
        }
    }
}
