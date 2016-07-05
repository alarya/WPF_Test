using System.Windows;

namespace WPFTestApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //---------Test the radio button----------------//
            //Window radioButtonTest = new RadioButtonTest();
            //radioButtonTest.Show();

            //---------Test Expander control---------------//
            //Window expanderTest = new ExpanderTest();
            //expanderTest.Show();

            //---------Test Expander control---------------//
            //Window textInputTest = new TextInputTest();
            //textInputTest.Show();

            //---------Test Expander control---------------//
            //Window listBoxTest = new ListBoxTest();
            //listBoxTest.Show();

            //---------Test Menus and Commands---------------//
            Window menusAndCommandsTest = new MenusAndCommandsTest();
            menusAndCommandsTest.Show();

        }
    }
}
