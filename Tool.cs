using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoScreenOperator
{
    internal static class Tool
    {
        static public IEnumerable<TimerDate> GetTimer(float time)
        {
            if (time == 0) { yield return new TimerDate(1, TimeSpan.FromSeconds(time), DateTime.Now);yield break; }
            DateTime endTime = DateTime.Now + TimeSpan.FromSeconds(time);
            DateTime nowTime = DateTime.Now;
            DateTime lastTime = DateTime.Now;
            while (endTime >= (nowTime = DateTime.Now)) {
                yield return new TimerDate(1-(endTime - nowTime).TotalSeconds / time, nowTime - lastTime, lastTime);
                lastTime = nowTime;
            }
        }
        static public Vector2 Lerp(this Vector2 pos1, Vector2 pos2,float v)
        {
            return (1 - v) * pos1 + pos2 * v;
        }
        static public Point ToPoint(this Vector2 pos)
        {
            return new Point((int)Math.Round(pos.X), (int)Math.Round(pos.Y));
        }
        static public Point ToPoint(this Size pos)
        {
            return new Point(pos.Width,pos.Height);
        }
        static public Size ToSize(this Vector2 pos)
        {
            return new Size((int)Math.Round(pos.X),(int)Math.Round(pos.Y));
        }
        static public Size ToSize(this Point pos)
        { 
            return new Size(pos.X, pos.Y);
        }
        static public Vector2 ToVector2(this String str)
        {
            string[] ss = str.Split(',');
            return new Vector2(float.Parse(ss[0]), float.Parse(ss[1]));
        }
        static public Vector2 ToVector2(this Point p)
        {
            return new Vector2(p.X, p.Y);
        }
        static public Vector2 ToVector2(this Size p)
        {
            return new Vector2(p.Width, p.Height);
        }
    }
    internal struct TimerDate
    {
        public TimerDate(double normal,TimeSpan delta,DateTime last) { normalTime = normal;deltaTime = delta;lastTime = last; }    
        public double normalTime;
        public TimeSpan deltaTime;
        public DateTime lastTime;
    }
   
}
