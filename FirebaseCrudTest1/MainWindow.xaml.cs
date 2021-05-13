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
using FirebaseCrudTest1.HelperClasses;
using FirebaseCrudTest1.Models;
using FirebaseCrudTest1.Util;
using FirebaseCrudTest1.Util.studentManagment;
using FireSharp.Config;
using FireSharp.Interfaces;

using FireSharp.Response;

namespace FirebaseCrudTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        signup sign;

        public ContentControl con = new ContentControl();

        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "knSrEdjr4LxYi84J6N7vMCuV5iNbLv35wqyuZ9B1",
            BasePath= "https://school-management-system-1eec4.firebaseio.com/"
        };
        IFirebaseClient client;

        public MainWindow()
        {
            sign = new signup(this);
           
        InitializeComponent();
            

        }
        protected override void OnSourceInitialized(EventArgs e)
        {
            IconHelper.RemoveIcon(this);
        }

        private void Sign_up(object sender, RoutedEventArgs e)
        {
            con.Content = Content;

            Content = sign.Content;
            
           
        }

        private async void Login(object sender, RoutedEventArgs e)
        {
            if (ConnectionUtil.CheckConnection())
            {
                client = new FireSharp.FirebaseClient(config);
                FirebaseResponse firebaseResponse = await client.GetAsync("Admin/" + Username.Text);
                Admin admin = firebaseResponse.ResultAs<Admin>();
                if (admin != null)
                {
                    if (Encrypt.GetShaData(password.Password).Equals(admin.Password))
                    {
                        this.Hide();
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.Show();
                    }
                    else
                    {
                        Error.Visibility = Visibility.Visible;
                        Error.Text = "Incorrect password";
                    }
                }

            }
            else
            {
                Error.Visibility = Visibility.Visible;
                Error.Text = "Connection error";
               /* this.Hide();
                Form1 win = new Form1();
                win.Show()*/;
                /*this.Hide();

                AdminWindow admin = new AdminWindow();
                admin.Show();*/


                

              
               
            }

        }
    }
}
