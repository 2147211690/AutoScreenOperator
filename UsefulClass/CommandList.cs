using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoScreenOperator.CPanels;

namespace AutoScreenOperator.UsefulClass
{
    public class CommandList: IList<Command>
    {
        public CommandList(Command c) { command = c; }
        private readonly Command command;
        private List<Command> list = new();
        public Command this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Count => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();
        public void Add(Command item)
        {
            list.Add(item);
            command.panel.Parent = item.panel;
            item.parent = command;
            command.Review();
        }
        public void Clear()
        {
            for(int i = 0; i < list.Count; i++) { RemoveAt(i); }
            command.Review();
        }

        public bool Contains(Command item)=>list.Contains(item);   
        public void CopyTo(Command[] array, int arrayIndex)=>list.CopyTo(array, arrayIndex);
        public IEnumerator<Command> GetEnumerator()=>list.GetEnumerator();
        public int IndexOf(Command item) => list.IndexOf(item);
        public void Insert(int index, Command item) 
        {
            list.Insert(index, item);
            item.parent = command;
            item.panel.Parent = command.panel;
        }
        public bool Remove(Command item)
        {
            int index = list.IndexOf(item);
            if (index == -1) return false;
            RemoveAt(index);
            return true;

        }
        public void RemoveAt(int index)
        {
            Command c = list[index];
            c.panel.Parent = null;
            c.parent = null;
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
