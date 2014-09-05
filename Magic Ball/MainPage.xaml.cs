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
using Microsoft.Phone.Tasks;

namespace Magic_Ball
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int temp1 = 0, temp2 = 0, temp3 = 0;
            



            int x, y, res = 0, p, q, m, result = 0, temp;

            if (date.Text.Trim().Length <= 0)
            {
                MessageBoxResult rus = MessageBox.Show("please enter date of birth", "error", MessageBoxButton.OK);
                if (MessageBoxResult.OK == rus)
                {
                    NavigationService.Navigate(new Uri("/mainpage.xaml", UriKind.Relative));
                }


            }
            else if (month.Text.Trim().Length <= 0)
            {
                MessageBoxResult rus = MessageBox.Show("please enter month", "error", MessageBoxButton.OK);
                if (MessageBoxResult.OK == rus)
                {
                    NavigationService.Navigate(new Uri("/mainpage.xaml", UriKind.Relative));
                }
            }
            else if (year.Text.Trim().Length <= 0)
            {
                MessageBoxResult rus = MessageBox.Show("please enter year", "error", MessageBoxButton.OK);
                if (MessageBoxResult.OK == rus)
                {
                    NavigationService.Navigate(new Uri("/mainpage.xaml", UriKind.Relative));
                }
            }

            else
            {



                int a = int.Parse(date.Text);
                int b = int.Parse(month.Text);
                int c = int.Parse(year.Text);

                
                if (c >= 1 && c <= 2014)
                {

                    while (a != 0)
                    {
                        x = a % 10;
                        a = a / 10;
                        temp1 = temp1 + x;
                    }
                    while (b != 0)
                    {
                        y = b % 10;
                        b = b / 10;
                        temp2 = temp2 + y;
                    }
                    while (c != 0)
                    {
                        temp = c % 10;
                        c = c / 10;
                        res = res + temp;
                    }
                    while (res != 0)
                    {
                        p = res % 10;
                        res = res / 10;
                        temp3 = temp3 + p;
                    }
                    q = temp1 + temp2 + temp3;
                    while (q != 0)
                    {
                        m = q % 10;
                        q = q / 10;
                        result = result + m;


                    }
                    if (result == 10)
                    {
                        result = 1;
                    }
                    int w=int.Parse(date.Text);
                    NavigationService.Navigate(new Uri("/Page1.xaml?result="+result+"&birth="+w, UriKind.Relative));


                }
                else
                {

                    MessageBox.Show("Please enter valid date of birth");
                    NavigationService.Navigate(new Uri("/mainpage.xaml", UriKind.Relative));
                    
                }

                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/aboutus.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplacereviewtask = new MarketplaceReviewTask();
            marketplacereviewtask.Show();
        }
    }
}