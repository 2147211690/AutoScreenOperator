using AutoScreenOperator.OtherControl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoScreenOperator.CPanels
{
    public partial class CommandPanel : UserControl
    {
        public virtual Command command { get; }
        public CommandEdit commandEdit { get; set; }

        public CommandPanel this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void SetCommandValue() { }
        public virtual void AddChild(CommandPanel p) { }
        public virtual void RemoveChild(CommandPanel p) { }
        public virtual void Review() { }
        protected void SummonCommandEidt()
        {
            CommandEdit e = new(command);
            this.Controls.Add(e);
            e.Location = new(this.Size.Width-e.Size.Width,0);
            e.command = command;
            commandEdit = e;
        }
        
    }
}
