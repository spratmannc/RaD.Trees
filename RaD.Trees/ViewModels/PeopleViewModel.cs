using RaD.Trees.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaD.Trees.ViewModels
{
    public class PeopleViewModel
    {
        public ObservableCollection<Person> Folks { get; set; }
    }
}
