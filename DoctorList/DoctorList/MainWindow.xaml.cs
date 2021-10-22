using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Windows.Controls;

namespace DoctorList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<Doctor> items = new List<Doctor>();
        public bool isSelected = true;
        public int CheckedCount;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; OnPropertyChanged("IsSelected"); }
        }

        private string dataValue;

        public string DataValue
        {
            get { return dataValue; }
            set { dataValue = value; OnPropertyChanged("DataValue"); }
        }

        public MainWindow()
        {
            InitializeComponent();
            IsSelected = true;
            DataValue = "Phu Quang";
            this.DataContext = this;
            items.Add(new Doctor() { ID = 1, Name = "Quang 2k4", Age = 17, Phone = "02323432", Mail = "1@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2004, 1, 1)).ToString("dd/mm/yyyy") });
            items.Add(new Doctor() { ID = 2, Name = "Quang 2k2", Age = 19, Phone = "02323432", Mail = "2@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            items.Add(new Doctor() { ID = 3, Name = "Lộc wibu", Age = 7, Phone = "02323432", Mail = "3@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            items.Add(new Doctor() { ID = 4, Name = "Nghĩa tay to", Age = 39, Phone = "02323432", Mail = "3@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            items.Add(new Doctor() { ID = 5, Name = "Tuấn khỉ", Age = 39, Phone = "02323432", Mail = "3@kteam.com", Sex = SexType.Nam, Birthday = (new DateTime(2002, 1, 1)).ToString("dd/mm/yyyy") });
            datagrid.ItemsSource = items;
            CheckedCount = 0;
        }
        public enum SexType { Nam, Nữ }
        public class Doctor
        {
            public bool IsChecked { get; set; }

            public int ID { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }

            public string Phone { get; set; }

            public string Mail { get; set; }

            public SexType Sex { get; set; }

            public string Birthday { get; set; }
        }

        private void AllSelect_Checked(object sender, RoutedEventArgs e)
        {
            bool allcheckbox = (AllSelect.IsChecked == true);

        }

        private void SingleCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.IsChecked == true)
                CheckedCount++;
            else
                CheckedCount--;
            if (CheckedCount == items.Count)
                AllSelect.IsChecked = true;
            else
                AllSelect.IsChecked = false;
        }
    }
}
