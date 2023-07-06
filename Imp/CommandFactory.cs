using AutoScreenOperator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScreenOperator.Imp
{

    public class CommandFactory : Interface.IFactory
    {
        public CommandFactory()
        {
            getFuncs = new Func<Command>[] { GetClickCommand, GetDragToCommand, GetMoveToCommand, GetMultipleClickCommand, GetRepeatCommand, GetSleepCommand ,GetChangeStateCommand};
        }
        public Control defalutControl { get; set; }
        private Func<Command>[] getFuncs;
        public Command GetClickCommand() => Get<ClickCommand>();
        public Command GetDragToCommand() => Get<DragToCommand>();
        public Command GetMoveToCommand() => Get<MoveToCommand>();
        public Command GetMultipleClickCommand() => Get<MultipleClickCommand>();
        public Command GetRepeatCommand() => Get<RepeatCommand>();
        public Command GetSleepCommand() => Get<SleepCommand>();
        public Command GetChangeStateCommand() => Get<ChangeStateCommand>();
        public Command GetCommand(CommandType t) => getFuncs[(int)t - 1].Invoke();
        public void SetFactoryList(ListBox c) { c.Items.AddRange(IFactory.commandString);c.SelectedIndex = 0; }
        private Command Get<T>() where T : Command, new()
        {
            T c = new T();
            return c;
        }
        
    }

}
