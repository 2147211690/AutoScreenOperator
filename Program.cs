using AutoScreenOperator.Imp;
using AutoScreenOperator.Interface;
using AutoScreenOperator.OtherForm;
namespace AutoScreenOperator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static CommandSelectForm selectForm;
        public static IFactory commandF = new CommandFactory();
        public static PointSelectForm pointSelector = new();
        public static CommandType SelectType(object sender)
        {
            if(sender is Control c)
            {
                selectForm.Location = Control.MousePosition;
                selectForm.ShowDialog();
                return (CommandType)selectForm.selectedIndex;
            }
            return 0;
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            selectForm = new CommandSelectForm();
            pointSelector.Visible = false;
            Application.Run(new MainForm());
        }
    }
}