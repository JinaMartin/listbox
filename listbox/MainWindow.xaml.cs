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

namespace listbox
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            using (StreamReader reader = new StreamReader("Seznam"))
            {
                var linecount = File.ReadLines("Seznam").Count();
                for (int i = 0; i < linecount; i++)
                {
                    string[] line = reader.ReadLine().Split(' ');
                    string jmeno = line[0] + " " + line[1];
                    string informace = "";
                    for (int j = 2; j < line.Length; j++)
                    {
                        informace += " " + line[j];
                    }

                    List.Items.Add(jmeno);
                    List.Items.Add(informace);
                }
            }
        }
    }
}
