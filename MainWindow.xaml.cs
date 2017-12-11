using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Threading;

namespace LexicialAnalysis_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void run()
        {
            readCode();
            runProgram();
            showResult();
        }

        private void runProgram()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "\\LexicialAnalysis.exe";
            Process p = Process.Start(path);
            p.WaitForExit();
            if (p != null)
                p.Close();
        }

        void readCode()
        {
            byte[] file = System.Text.Encoding.Default.GetBytes(sourceCode.Text);
            FileStream fs = new FileStream("./data.txt", FileMode.Create);
            fs.Write(file, 0, file.Length);
            fs.Flush();
            fs.Close();
        }

        private void showResult()
        {
            StreamReader sr = new StreamReader("./result.txt", Encoding.Default);
            ObservableCollection<Data> datas = new ObservableCollection<Data>();
            while (true)
            {
                string name = sr.ReadLine();
                if (name == null)
                    break;
                string kind = sr.ReadLine();
                string value = sr.ReadLine();
                datas.Add(new Data(name, kind, value));
            }
            this.outputFile.ItemsSource = datas;

            sr.Close();
        }

        private void clickToRun(object sender, RoutedEventArgs e)
        {
            run();
        }

        class Data
        {
            string name, kind, value;

            public string Name { get => name; set => name = value; }
            public string Kind { get => kind; set => kind = value; }
            public string Value { get => value; set => this.value = value; }

            public Data(string name, string kind, string value)
            {
                Name = name;
                Kind = kind;
                Value = value;
            }
        }

        private void clickToOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "txt file|*.txt";
            flushSourceCode("");
            if (ofd.ShowDialog() == true)
            {
                StreamReader sr = File.OpenText(ofd.FileName);
                while (sr.EndOfStream != true)
                    sourceCode.Text += sr.ReadLine() + "\n";
                sr.Dispose();
            }


        }

        private void flushSourceCode(string text)
        {
            Action<String> updateAction = new Action<string>(UpdateTb);
            sourceCode.Dispatcher.BeginInvoke(updateAction, text);
        }

        private void UpdateTb(string text)
        {
            sourceCode.Text = text;
        }
    }
}