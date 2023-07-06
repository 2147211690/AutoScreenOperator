using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Markup;
using AutoScreenOperator.CPanels;
using AutoScreenOperator.Interface;
using AutoScreenOperator.UsefulClass;
using WindowImp;

namespace AutoScreenOperator
{
    public abstract class Command
    {
        public static IMouseOperator mouseImp;
        public Command parent { get => _parent; 
            set 
            {
                _parent?.Remove(this);
                _parent = value;
                if (_parent != null) { _parent.panel.AddChild(panel); }
                else panel.Parent = null;
            }
        }
        protected Command _parent;
        virtual public CommandPanel panel { get; set; }
        virtual public Vector2 size { get => panel.Size.ToVector2(); set => panel.Size = value.ToSize(); }
        virtual public Vector2 pos { get => panel.Location.ToVector2(); set => panel.Location = value.ToPoint(); }
        virtual public int childCount { get=>0; }
        virtual public bool canHaveChildren => false;

        //基本方法
        virtual public Command GetChild(int index) { return null; }
        virtual public int FindChild(Command c) { return -1; }
        virtual public void AddChild(Command c) { }
        virtual public void AddChild(Command c, int index) { }
        virtual public void InsertParent(Command c,int offset = 1) { parent?.AddChild(c, parent.FindChild(this) + offset); }
        virtual public void RemoveChild(Command c) { }
        virtual public void RemoveChild(int index) { }
        virtual protected void Remove(Command c) { }//仅提供删除手段
        virtual public void Delete() { parent = null; ReviewAll(); }
        virtual public void Execute() { }
        virtual public void SetValue() { }
        virtual public void Review() { }
        public void ReviewAll() { if (parent != null) parent.ReviewAll(); else Review(); }
        
    }

    public class DragToCommand : Command
    {
        public DragToCommand() { panel = new DragToCPanel(this);}
        public MButtons mButton { get; set; }
        public Vector2 aimPos { get => mMoveToCommand.aimPos; set => mMoveToCommand.aimPos = value; }
        public float time { get => mMoveToCommand.time; set => mMoveToCommand.time = value; }
        private MoveToCommand mMoveToCommand = new MoveToCommand();
        public override void Execute()
        {
            mouseImp.ChangeButton(mButton, MState.Down);
            mMoveToCommand.Execute();
            mouseImp.ChangeButton(mButton, MState.Up);
        }
    }
    public class MoveToCommand : Command
    {
        public MoveToCommand() { panel = new MoveToCPanel(this);}
        public Vector2 aimPos { get; set; }
        public float time { get; set; }
        public override void Execute()
        {
            Vector2 begin = mouseImp.mousePos;
            foreach (var a in Tool.GetTimer(time))
            {
                Vector2 nPos = begin.Lerp(aimPos, (float)a.normalTime);
                mouseImp.MoveTo(nPos);
            }
        }
    }
    public class ClickCommand : Command
    {
        public ClickCommand() { panel = new ClickCPanel(this); }
        public MButtons mButton { get; set; }
        public override void Execute()
        {
            mouseImp.Click(mButton);
        }
    }
    public class MultipleClickCommand : Command
    {
        public MultipleClickCommand() { panel = new MultipleClickCPanel(this); }
        public MButtons mButton { get; set; }
        public int count { get => _count; set { _count = value;OnResetValue(); } }
        private int _count = 10;
        public float time { get => _time; set { _time = value;OnResetValue(); } }
        private float _time = 1;

        private TimeSpan oneTime;
        public override void Execute()
        {
            DateTime beginTime = DateTime.Now;
            int c = 0;
            while (true)
            {
                if (c >= count) break;
                if (DateTime.Now - beginTime >= c * oneTime)
                {
                    mouseImp.Click(mButton);
                    c++;
                }
            }
        }
        private void OnResetValue()
        {
            oneTime = TimeSpan.FromSeconds(time / count);
        }
    }
    public class RepeatCommand : Command
    {
        public RepeatCommand(){ panel = new RepeatCPanel(this); commands = new(); }
        private List<Command> commands;
        public int repeatCount { get; set; }
        public override int childCount { get => commands.Count;}
        public override bool canHaveChildren => true;
        public override void AddChild(Command c) 
        { 
            commands.Add(c);
            c.parent = this;
            ReviewAll();
        }
        public override void AddChild(Command c, int index)
        {
            commands.Insert(index,c);
            c.parent = this;
            ReviewAll();
        }
        public override void RemoveChild(Command c) { c.parent = null; ReviewAll();}
        public override void RemoveChild(int index) { commands[index].parent = null; ReviewAll(); }
        protected override void Remove(Command c) { commands.Remove(c); ReviewAll(); }
        public override int FindChild(Command c) => commands.IndexOf(c);
        public override void Review()
        {
            float pY = 0;
            foreach(var a in commands)
            {
                a.Review();
                a.pos = new Vector2(0, pY);
                pY += a.size.Y;
            }
            panel.Review();
        }
        public override void Execute()
        {
            for (int i = 0; i < repeatCount; i++)
            {
                foreach (var a in commands)
                {
                    a.Execute();
                }
            }
        }
    }
    public class SleepCommand : Command
    {
        public SleepCommand() { panel = new SleepCPanel(this); }
        public float sleepTime { get; set; }
        public override void Execute()
        {
            Thread.Sleep((int)sleepTime*1000);
        }
    }
    public class ChangeStateCommand : Command
    {
        public ChangeStateCommand() { panel = new ChangeStateCPanel(this); }
        public MButtons mButton;
        public MState mState;
        public override void Execute()
        {
            mouseImp.ChangeButton(mButton, mState);
        }
    }
}
