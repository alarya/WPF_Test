using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace WPFTestApp1
{
    /// <summary>
    /// Interaction logic for CommandTest.xaml
    /// </summary>
    public partial class CommandTest : Window
    {
        public CommandTest()
        {
            InitializeComponent();

            CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy);

            this.CommandBindings.Add(copyCommand);

            copyCommand.Executed += new ExecutedRoutedEventHandler(copyCommand_Executed);

        }
        private void copyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy Executed");
        }
    }
}
