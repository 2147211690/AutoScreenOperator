using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoScreenOperator
{
    public interface IMouseOperator
    {
        public Vector2 mousePos { get; set; }
        public void MoveTo(Vector2 pos);
        public void Click(MButtons button = MButtons.Left);
        public void ChangeButton(MButtons button, MState i);
    }
    [Flags]
    public enum MButtons
    {
        None,
        Left,
        Right,
        Middle,
        XButton1,
        XButton2,
    }
    public enum MState
    {
        None,
        Down,
        Up
    }
    public static class CPanelResource
    {
        public static string[] mButtonString = { "无", "左键", "右键", "中键", "XButton1", "XButton2" };
        public static void SetMButtonComboBox(ComboBox b) { b.Items.AddRange(mButtonString); b.SelectedIndex = 0; }
        public static string[] mStateString = { "无", "按下", "抬起" };
        public static void SetMStateComboBox(ComboBox b) { b.Items.AddRange(mStateString); b.SelectedIndex = 0; }

    }
}
   

    
