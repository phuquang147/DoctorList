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
using DoctorList.ViewModel;


namespace DoctorList
{
    public partial class DoctorListUC : UserControl
    {
        public DoctorListUC()
        {
            InitializeComponent();
        }

        //private void AllSelect_Checked(object sender, RoutedEventArgs e)
        //{
        //    bool allcheckbox = (AllSelect.IsChecked == true);
        //    for (int i = 0; i < doctors.Count; i++)
        //        doctors[i].IsChecked = allcheckbox;
        //}

        //private void SingleCheckbox_Checked(object sender, RoutedEventArgs e)
        //{
        //    AllSelect.IsChecked = null;
        //    CheckBox c = (CheckBox)sender;
        //    if (c.IsChecked == true)
        //        CheckedCount++;
        //    else
        //        CheckedCount--;
        //    if (CheckedCount == doctors.Count)
        //        AllSelect.IsChecked = true;
        //    else
        //        if (CheckedCount == 0)
        //        AllSelect.IsChecked = false;
        //}
    }
}
