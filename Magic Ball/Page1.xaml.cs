using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Magic_Ball
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string life;
          
            if (NavigationContext.QueryString.TryGetValue("result" ,out life))
            {
                textblock1.Text = life;
                
            }
            string birthday;
            if (NavigationContext.QueryString.TryGetValue("birth", out birthday))
            {
                textblock2.Text = birthday;

            }

            
     
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textblock1.Text == "1")
            {
                NavigationService.Navigate(new Uri("/lifepath1.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "2")
            {
                NavigationService.Navigate(new Uri("/lifepath2.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "3")
            {
                NavigationService.Navigate(new Uri("/lifepath3.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "4")
            {
                NavigationService.Navigate(new Uri("/lifepath4.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "5")
            {
                NavigationService.Navigate(new Uri("/lifepath5.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "6")
            {
                NavigationService.Navigate(new Uri("/lifepath6.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "7")
            {
                NavigationService.Navigate(new Uri("/lifepath7.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "8")
            {
                NavigationService.Navigate(new Uri("/lifepath8.xaml", UriKind.Relative));
            }
            if (textblock1.Text == "9")
            {
                NavigationService.Navigate(new Uri("/lifepath9.xaml", UriKind.Relative));
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textblock2.Text == "1")
            {
                NavigationService.Navigate(new Uri("/birthday1.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "2")
            {
                NavigationService.Navigate(new Uri("/birthday2.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "3")
            {
                NavigationService.Navigate(new Uri("/birthday3.xaml", UriKind.Relative));
            } 
            if (textblock2.Text == "4")
            {
                NavigationService.Navigate(new Uri("/birthday4.xaml", UriKind.Relative));
            } 
            if (textblock2.Text == "5")
            {
                NavigationService.Navigate(new Uri("/birthday5.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "6")
            {
                NavigationService.Navigate(new Uri("/birthday6.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "7")
            {
                NavigationService.Navigate(new Uri("/birthday7.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "8")
            {
                NavigationService.Navigate(new Uri("/birthday8.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "9")
            {
                NavigationService.Navigate(new Uri("/birthday9.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "10")
            {
                NavigationService.Navigate(new Uri("/birthday10.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "11")
            {
                NavigationService.Navigate(new Uri("/birthdaY11.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "12")
            {
                NavigationService.Navigate(new Uri("/birthday12.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "13")
            {
                NavigationService.Navigate(new Uri("/birthday13.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "14")
            {
                NavigationService.Navigate(new Uri("/birthday14.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "15")
            {
                NavigationService.Navigate(new Uri("/birthday15.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "16")
            {
                NavigationService.Navigate(new Uri("/birthday16.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "17")
            {
                NavigationService.Navigate(new Uri("/birthday17.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "18")
            {
                NavigationService.Navigate(new Uri("/birthday18.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "19")
            {
                NavigationService.Navigate(new Uri("/birthday19.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "20")
            {
                NavigationService.Navigate(new Uri("/birthday20.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "21")
            {
                NavigationService.Navigate(new Uri("/birthday21.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "22")
            {
                NavigationService.Navigate(new Uri("/birthday22.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "23")
            {
                NavigationService.Navigate(new Uri("/birthday23.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "24")
            {
                NavigationService.Navigate(new Uri("/birthday24.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "25")
            {
                NavigationService.Navigate(new Uri("/birthday25.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "26")
            {
                NavigationService.Navigate(new Uri("/birthday26.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "27")
            {
                NavigationService.Navigate(new Uri("/birthday27.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "28")
            {
                NavigationService.Navigate(new Uri("/birthday7.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "29")
            {
                NavigationService.Navigate(new Uri("/birthday7.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "30")
            {
                NavigationService.Navigate(new Uri("/birthday7.xaml", UriKind.Relative));
            }
            if (textblock2.Text == "31")
            {
                NavigationService.Navigate(new Uri("/birthday7.xaml", UriKind.Relative));
            }
        }

       

        }
          
        }

        
        
    
