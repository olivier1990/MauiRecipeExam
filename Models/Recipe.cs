using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo.Models
{
    public class Recipe : INotifyPropertyChanged
    {
        int _id;
        public int Id
        {
            get => _id;
            set
            {
                if (_id == value)
                    return;

                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }


        string _recipename;

        public string RecipeName
        {
            get => _recipename;
            set
            {
                if (_recipename == value)
                    return;

                _recipename = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RecipeName)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}