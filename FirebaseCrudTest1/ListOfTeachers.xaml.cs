using FirebaseCrudTest1.Models;
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

namespace FirebaseCrudTest1
{
    /// <summary>
    /// Interaction logic for ListOfTeachers.xaml
    /// </summary>
    public partial class ListOfTeachers : UserControl
    {
        public ListOfTeachers()
        {
            InitializeComponent();
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher() {
                FirstName="abebe",
                LastName="kebede",
                ProfilePic="Assets/school3.png",
                

            });
            teachers.Add(new Teacher()
            {
                FirstName = "abebe",
                LastName = "kebede",
                ProfilePic = "Assets/school.png",


            });
            teachers.Add(new Teacher()
            {
                FirstName = "yonatan",
                LastName = "kebede",
                ProfilePic = "Assets/school1.png",


            });
            teachers.Add(new Teacher()
            {
                FirstName = "biruk",
                LastName = "kebede",
                ProfilePic = "Assets/school4.png",


            });
            TeacherListBox.ItemsSource = teachers;
        }
    }
}
