using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using static Clock.SetTime;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            
            InitializeComponent();

            Model setTime = GetTime();

            Sec.DataContext = setTime;
            Min.DataContext = setTime;
            Hour.DataContext = setTime;
             
            SecAnime.To = setTime.SecondAngles + 360;
            MinAnime.To = setTime.MinuteAngles + 360;
            HourAnime.To = setTime.HourAngles + 360;
               
        }
    }
}
