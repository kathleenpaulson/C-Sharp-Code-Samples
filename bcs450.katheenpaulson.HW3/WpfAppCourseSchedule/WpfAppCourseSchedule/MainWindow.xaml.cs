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
using CourseScheduling;

namespace WpfAppCourseSchedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataLayer dataLayer = new DataLayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {

            Course c = new Course();

            //Pull data from text boxes and put in c

            c.Id = Convert.ToInt32(IdTextBox.Text);
            c.Designator = DesignatorTextBox.Text;
            c.Number = NumberTextBox.Text;
            c.Title = TitleTextBox.Text;
            c.Description = DescriptionTextBox.Text;
            c.Credits = Convert.ToInt32(CreditsTextBox.Text);

            dataLayer.AddCourse(c);
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataLayer.CourseAddedEvent += HandleCourseAdded;
        }

        public void HandleCourseAdded(Object sender, DataLayer.CourseAddedEventArgs evtArgs)
        {
            //show message box here passing in evt.courseAdded
            //MessageBox.Show(evtArgs.CourseAdded);
            Course c = evtArgs.CourseAdded;
            MessageBox.Show(c.ToString());
        }

        private void ReadDataFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            dataLayer.Initialize();
        }

        private void ShowCourseDataButton_Click(object sender, RoutedEventArgs e)
        {
            
                MessageBox.Show(dataLayer.Courses.ToString());
        }

        private void CourseScheduleWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dataLayer.CourseAddedEvent += HandleCourseAdded;

        }
    }
}
