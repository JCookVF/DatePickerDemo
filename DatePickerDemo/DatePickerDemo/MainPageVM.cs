using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DatePickerDemo
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if(value != _date)
                {
                    _date = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date"));
                }
            }
        }

        private DateTime _minDate;
        public DateTime MinDate
        {
            get { return _minDate; }
            set
            {
                if(value != _minDate)
                {
                    _minDate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MinDate"));
                }
            }
        }

        private DateTime _maxDate;
        public DateTime MaxDate
        {
            get { return _maxDate; }
            set
            {
                if (value != _maxDate)
                {
                    _maxDate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaxDate"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageVM()
        {
            MinDate = new DateTime(2020, 01, 01);
            MaxDate = new DateTime(2020, 06, 30);
        }
    }
}
