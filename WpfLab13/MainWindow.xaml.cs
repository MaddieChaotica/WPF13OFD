using Microsoft.Win32;
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

namespace WpfLab13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Loadfile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files  (*.txt)|*.txt| rtf files (*.rtf)|*.rtf";
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            string filetext = System.IO.File.ReadAllText(filename);
            RequestBox.Text = filetext;
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files  (*.txt)|*.txt| rtf files (*.rtf)|*.rtf";
            saveFileDialog.ShowDialog();
            string filename = saveFileDialog.FileName;
            string filetext = RequestBox.Text;
            System.IO.File.WriteAllText(filename, filetext);
            MessageBox.Show("File saved");
            
        }
    }
}
