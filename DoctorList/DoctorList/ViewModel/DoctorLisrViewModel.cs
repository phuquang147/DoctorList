using DoctorList.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorList.Model;
using DoctorList;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Prism.Commands;

namespace DoctorList.ViewModel
{
    class DoctorLisrViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public int CheckedCount;
        public List<Doctor> doctors = new List<Doctor>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public List<Doctor> Doctors
        {
            get { return doctors; }
            set { doctors = value; OnPropertyChanged("Doctors"); }
        }

        //private readonly DelegateCommand<CheckBox> AllCheckedCommand;
        public ICommand AllCheckedCommand { get; set; }
        public ICommand SingleCheckedCommand { get; set; }
        

        public DoctorLisrViewModel()
        {
            doctors.Add(new Doctor() { ID = 1, Name = "Quang 2k4", Age = 17, Phone = "02323432", Mail = "1@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2004, 1, 1)).ToString("dd/mm/yyyy") });
            doctors.Add(new Doctor() { ID = 2, Name = "Quang 2k2", Age = 19, Phone = "02323432", Mail = "2@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            doctors.Add(new Doctor() { ID = 3, Name = "Lộc wibu", Age = 7, Phone = "02323432", Mail = "3@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            doctors.Add(new Doctor() { ID = 4, Name = "Nghĩa tay to", Age = 39, Phone = "02323432", Mail = "3@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            doctors.Add(new Doctor() { ID = 5, Name = "Tuấn khỉ", Age = 39, Phone = "02323432", Mail = "3@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            CheckedCount = 0;

            AllCheckedCommand = new RelayCommand<CheckBox>((p) => { return p == null ? false : true; }, (p) =>
            {
                MessageBox.Show("test");
                bool allcheckbox = (p.IsChecked == true);
                for (int i = 0; i < doctors.Count; i++)
                    doctors[i].IsChecked = true;
            });



            //SingleCheckedCommand = new RelayCommand<CheckBox[]>((p) => { return p == null ? false : true; }, (p) => {
            //        p[0].IsChecked = null;
            //        CheckBox c = (CheckBox)p[1];
            //        if (c.IsChecked == true)
            //            CheckedCount++;
            //        else
            //            CheckedCount--;
            //        if (CheckedCount == doctors.Count)
            //            p[0].IsChecked = true;
            //        else
            //            if (CheckedCount == 0)
            //            p[0].IsChecked = false;
            //    });


        }
    }
}
