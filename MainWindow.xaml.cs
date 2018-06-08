// Colin Jones
// May 27, 2018
// Take 3 Values and turn them into x-intercepts
// Gonna do extended now
// PLot the X-Values on a graph in the xaml


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
using System.Drawing;

namespace U5_Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double c;
        double root1;
        double root2;
        Ellipse e_root1 = new Ellipse();
        Ellipse e_root2 = new Ellipse();

        public MainWindow()
            //Setting Circles for X-Intercept graph
        {
            InitializeComponent();


            e_root1.Height = 10;
            e_root1.Width = 10;
            e_root1.Fill = Brushes.Green;

            e_root2.Height = 10;
            e_root2.Width = 10;
            e_root2.Fill = Brushes.Green;
        }
        // Taking  A B C Values and inputin them into equation
        public void Click_Calc(object Sender, RoutedEventArgs e)
        {
            canvas_Graph.Children.Remove(e_root1);
            canvas_Graph.Children.Remove(e_root2);
            canvas_Graph.Visibility = Visibility.Hidden;
            btn_Graph.Visibility = Visibility.Visible;
            double.TryParse(AValue.Text, out a);
            double.TryParse(BValue.Text, out b);
            double.TryParse(CValue.Text, out c);

            root1 = (-b - Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a); // math oof
            root2 = (-b + Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);

            output.Text = "Root 1 is " + root1.ToString() + " Root 2 is " + root2.ToString();


        }

        public void Click_Graph(object Sender, RoutedEventArgs e)
        {
            canvas_Graph.Visibility = Visibility.Visible;
            DrawZeros();
        }

        public void DrawZeros()
        {
            canvas_Graph.Visibility = Visibility.Visible;
            canvas_Graph.Children.Remove(e_root1);
            canvas_Graph.Children.Remove(e_root2);
            canvas_Graph.Children.Add(e_root1);
            canvas_Graph.Children.Add(e_root2);
            Canvas.SetTop(e_root1, 130);
            Canvas.SetTop(e_root2, 130);


            // Dont want to do a for loop, so set each x-Value to a x,y coordinate which is set on the graph

            if (root2 == 9)
            {
                Canvas.SetLeft(e_root2, 350);
            }
            else if (root2 == 8)
            {
                Canvas.SetLeft(e_root2, 330);
            }
            else if (root2 == 7)
            {
                Canvas.SetLeft(e_root2, 310);
            }
            else if (root2 == 6)
            {
                Canvas.SetLeft(e_root2, 290);
            }
            else if (root2 == 5)
            {
                Canvas.SetLeft(e_root2, 270);
            }
            else if (root2 == 4)
            {
                Canvas.SetLeft(e_root2, 250);
            }
            else if (root2 == 3)
            {
                Canvas.SetLeft(e_root2, 230);
            }
            else if (root2 == 2)
            {
                Canvas.SetLeft(e_root2, 210);
            }
            else if (root2 == 1)
            {
                Canvas.SetLeft(e_root2, 190);
            }
            else if (root2 == 0)
            {
                Canvas.SetLeft(e_root2, 175);
            }
            else if (root2 == -1)
            {
                Canvas.SetLeft(e_root2, 165);
            }
            else if (root2 == -2)
            {
                Canvas.SetLeft(e_root2, 145);
            }
            else if (root2 == -3)
            {
                Canvas.SetLeft(e_root2, 125);
            }
            else if (root2 == -4)
            {
                Canvas.SetLeft(e_root2, 105);
            }
            else if (root2 == -5)
            {
                Canvas.SetLeft(e_root2, 85);
            }
            else if (root2 == -6)
            {
                Canvas.SetLeft(e_root2, 65);
            }
            else if (root2 == -7)
            {
                Canvas.SetLeft(e_root2, 45);
            }
            else if (root2 == -8)
            {
                Canvas.SetLeft(e_root2, 25);
            }
            else if (root2 == -9)
            {
                Canvas.SetLeft(e_root2, 5);
            }
            else if (root2 < -9)
            {
                MessageBox.Show("Root is Smaller then -9");
            }

            else if (root2 > 9)
            {
                MessageBox.Show("Root is Larger then 9");
            }


            else
            {
                MessageBox.Show("Number is a decimal");
            }


                if (root1 == 9)
            {
                Canvas.SetLeft(e_root1, 350);
            }
            else if (root1 == 8)
            {
                Canvas.SetLeft(e_root1, 330);
            }
            else if (root1 == 7)
            {
                Canvas.SetLeft(e_root1, 310);
            }
            else if (root1 == 6)
            {
                Canvas.SetLeft(e_root1, 290);
            }
            else if (root1 == 5)
            {
                Canvas.SetLeft(e_root1, 270);
            }
            else if (root1 == 4)
            {
                Canvas.SetLeft(e_root1, 250);
            }
            else if (root1 == 3)
            {
                Canvas.SetLeft(e_root1, 230);
            }
            else if (root1 == 2)
            {
                Canvas.SetLeft(e_root1, 210);
            }
            else if (root1 == 1)
            {
                Canvas.SetLeft(e_root1, 190);
            }
            else if (root1 == 0)
            {
                Canvas.SetLeft(e_root1, 175);
            }
            else if (root1 == -1)
            {
                Canvas.SetLeft(e_root1, 162);
            }
            else if (root1 == -2)
            {
                Canvas.SetLeft(e_root1, 142);
            }
            else if (root1 == -3)
            {
                Canvas.SetLeft(e_root1, 122);
            }
            else if (root1 == -4)
            {
                Canvas.SetLeft(e_root1, 102);
            }
            else if (root1 == -5)
            {
                Canvas.SetLeft(e_root1, 82);
            }
            else if (root1 == -6)
            {
                Canvas.SetLeft(e_root1, 62);
            }
            else if (root1 == -7)
            {
                Canvas.SetLeft(e_root1, 42);
            }
            else if (root1 == -8)
            {
                Canvas.SetLeft(e_root1, 22);
            }
            else if (root1 == -9)
            {
                Canvas.SetLeft(e_root1, 2);
            }
            else if (root1 < -9)
            {
                MessageBox.Show("Root is Smaller then -9");
            }

            else if (root1 > 9)
            {
                MessageBox.Show("Root is Larger then 9");
            }

            else
            {
                MessageBox.Show("Number is a decimal");
            }




        }
    }
}