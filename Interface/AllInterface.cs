using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoScreenOperator.Imp;
using AutoScreenOperator.UsefulClass;

namespace AutoScreenOperator.Interface
{
    public interface IFactory
    {
        public Command GetMoveToCommand();
        public Command GetClickCommand();
        public Command GetDragToCommand();
        public Command GetMultipleClickCommand();
        public Command GetRepeatCommand();
        public Command GetSleepCommand();
        public Command GetChangeStateCommand();
        public Command GetCommand(CommandType t);
        public void SetFactoryList(ListBox c) { }
        public static string[] commandString = { "无", "点击", "拖动", "移动", "连点", "重复", "等待", "改变状态" };
    }
    public enum CommandType
    {
        None,
        Click,
        DragTo,
        MoveTo,
        MultipleClick,
        Repeat,
        Sleep,
        ChangeState
    }
    public interface ICommandContainer
    {
       public CommandList commands { get; }
    }
}
