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
using System.IO;
using System.Globalization;
using Winforms = System.Windows.Forms;
using System.Threading;
namespace Task_5._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InputManager input;
        public MainWindow()
        {
            InitializeComponent();
            input = new InputManager();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Observer.getInstance();
            Observer.SourcePath = input.SelectedPath;
            Observer.SwitchWatcher(Combobox1.SelectedIndex);
            Textbox1.Text = input.ShowStatus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Combobox1.SelectedIndex == 1)
            {
                var backup = new BackupMaster();
                input.UserInput = Textbox1.Text;
                input.InputTime=input.SetTime(input.UserInput);
                Textbox1.Text = input.ShowStatus();
                backup.SourcePath = input.SelectedPath + @"\Logs";
                backup.TargetPath = input.SelectedPath;
                backup.CopyBackupFilesAccToSelector(backup.SourcePath, backup.TargetPath, backup.DefineSelectorOnInput(backup.SourcePath, input.InputTime));
            }

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) { }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var dialog = new Winforms.FolderBrowserDialog())
            {
                Winforms.DialogResult result = dialog.ShowDialog();

                if (result == Winforms.DialogResult.OK)
                {
                    input.SelectedPath = dialog.SelectedPath;
                }
            }
        }
    }
}
