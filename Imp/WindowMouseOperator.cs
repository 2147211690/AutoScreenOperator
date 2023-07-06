using AutoScreenOperator;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowImp;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AutoScreenOperator
{
    internal class WindowMouseOperator : IMouseOperator
    {
        private WindowInputImp imp = new();
        public Vector2 mousePos { get =>_mousePos; set { _mousePos = value; MoveTo(_mousePos); } }
        private Vector2 _mousePos = new Vector2(0,0);
        
        public void Click(MButtons button = MButtons.Left)
        {
            Input[] inputs = { GetMouseInput(0, 0, 0, GetMouseEvent(button)), GetMouseInput(0, 0, 0, GetMouseEvent(button,1)) };
            imp.Send(2, inputs, Marshal.SizeOf(typeof(Input)));
        }
        public void MoveTo(Vector2 pos)
        {
            Point p = imp.ToScreenPoint(pos);
            Input[] inputs = { GetMouseInput(p.X, p.Y, 0, MouseEventF.Absolute | MouseEventF.Move) };
            imp.Send(1, inputs, Marshal.SizeOf(typeof(Input)));
            _mousePos = pos;
        }
        public void ChangeButton(MButtons button, MState i)
        {
            int s = (int)i-1;
            if (s < 0) return;
            Input[] inputs = { GetMouseInput(0, 0, 0, GetMouseEvent(button, s)) };
            imp.Send(1, inputs, Marshal.SizeOf(typeof(Input)));
        }

        private Input GetMouseInput(int dx, int dy, uint mouseDate, MouseEventF dwFlags, uint time = 0)
        {
            return new Input
            {
                type = (int)InputType.Mouse,
                u = new InputUnion
                {
                    mi = new MouseInput
                    {
                        dx = dx,
                        dy = dy,
                        mouseData = mouseDate,
                        dwFlags = dwFlags,
                        time = time,
                        dwExtraInfo = imp.GetMessage()
                    }
                }
            };
        }
        private static MouseEventF[][] mouseButtonCastMap = {
            new MouseEventF[]{ 0, MouseEventF.LeftDown, MouseEventF.RightDown, MouseEventF.MiddleDown, MouseEventF.XDown, MouseEventF.XDown },
            new MouseEventF[]{ 0, MouseEventF.LeftUp, MouseEventF.RightUp, MouseEventF.MiddleUp, MouseEventF.XUp, MouseEventF.XUp }
        };
        private MouseEventF GetMouseEvent(MButtons buttons, int i = 0)
        {
            return mouseButtonCastMap[i][(int)buttons];
        }
    }
}
namespace WindowImp { 
    internal class WindowInputImp
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);
        public uint Send(uint nInputs, Input[] pInputs, int cbSize) => SendInput(nInputs,pInputs,cbSize);
        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();
        public IntPtr GetMessage() => GetMessageExtraInfo();
        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public Point ToScreenPoint(Vector2 vec)
        {

            Point screenPoint = vec.ToPoint();
            screenPoint.X = (int)(screenPoint.X * xPC);
            screenPoint.Y = (int)(screenPoint.Y * yPC);
            return screenPoint;
        }
        private double xPC, yPC;

        public WindowInputImp()
        {
            Input i = new Input
            {
                type = (int)InputType.Mouse,
                u = new InputUnion
                {
                    mi = new MouseInput
                    {
                        dx = 1000,
                        dy = 1000,
                        mouseData = 0,
                        dwFlags = MouseEventF.Absolute | MouseEventF.Move,
                        time = 0,
                        dwExtraInfo = GetMessage()
                    }
                }
            };
            Input[] inputs = { i };
            Send(1, inputs, Marshal.SizeOf(typeof(Input)));
            Point mP = Form.MousePosition;
            xPC = 1000 / mP.X;
            yPC = 1000 / mP.Y;
            i.u.mi.dx = 0;
            i.u.mi.dy = 0;
            inputs[0] = i;
            Send(1, inputs, Marshal.SizeOf(typeof(Input)));
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        public ushort wVk;
        public ushort wScan;
        public KeyEventF dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        public int dx;
        public int dy;
        public uint mouseData;
        public MouseEventF dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        public uint uMsg;
        public ushort wParamL;
        public ushort wParamH;
    }


    [StructLayout(LayoutKind.Explicit)]
    public struct InputUnion
    {
        [FieldOffset(0)] public MouseInput mi;
        [FieldOffset(0)] public KeyboardInput ki;
        [FieldOffset(0)] public HardwareInput hi;
    }
    public struct Input
    {
        public int type;
        public InputUnion u;
    }
    [Flags]
    public enum InputType
    {
        Mouse = 0,
        Keyboard = 1,
        Hardware = 2
    }
    [Flags]
    public enum KeyEventF
    {
        KeyDown = 0x0000,
        ExtendedKey = 0x0001,
        KeyUp = 0x0002,
        Unicode = 0x0004,
        Scancode = 0x0008
    }
    [Flags]
    public enum MouseEventF
    {
        Absolute = 0x8000,
        HWheel = 0x01000,
        Move = 0x0001,
        MoveNoCoalesce = 0x2000,
        LeftDown = 0x0002,
        LeftUp = 0x0004,
        RightDown = 0x0008,
        RightUp = 0x0010,
        MiddleDown = 0x0020,
        MiddleUp = 0x0040,
        VirtualDesk = 0x4000,
        Wheel = 0x0800,
        XDown = 0x0080,
        XUp = 0x0100
    }
}
