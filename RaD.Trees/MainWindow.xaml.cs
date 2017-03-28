using RaD.Trees.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RaD.Trees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // set up some samle data
            PeopleViewModel data = new PeopleViewModel
            {
                Folks = new ObservableCollection<Models.Person>
                {
                    new Models.Person { FirstName = "Lester & Debra" },
                    new Models.Person
                    {
                        FirstName = "Roger",
                        Children = new List<Models.Person>
                        {
                            new Models.Person {
                                FirstName = "Alaina",
                                Children = new List<Models.Person>
                                {
                                    new Models.Person { FirstName = "Michelle"},
                                    new Models.Person { FirstName = "Erica" }
                                }
                            },
                            new Models.Person { FirstName = "Madison" },
                            new Models.Person { FirstName = "Marlie" },
                            new Models.Person { FirstName = "Morgan" }
                        }
                    }
                }
            };

            this.DataContext = data;
        }
    }
}
