using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTest
{
    public class Buttons
    {
        public int Code;
        public string Data;
        public int Value;
        public bool Tested;
        public Coord Pos;

        public Buttons(int code, string data, int value, float posx, float posy)
        {
            this.Code = code;
            this.Data = data;
            this.Value = value;
            this.Pos = new Coord(posx,posy);
        }
    }

    public enum Direction
    {
        LeftRight = 0,
        UpDown = 1,
    }

    public class Coord
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Coord(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// 平移坐标，枚举指定方向。
        /// </summary>
        /// <param name="direction">方向枚举常数。左右为0，上下为1</param>
        /// <param name="offset">移动距离。左、上正，右、下负。</param>
        /// <returns>操作成功？</returns>
        public bool Shift(Direction direction,float offset)
        {
            switch ((uint)direction)
            {
                case 0:
                    {
                        X -= (X - offset < 0) ? 0 : offset;
                        return true;
                    }
                case 1:
                    {
                        Y -= (Y - offset < 0) ? 0 : offset;
                        return true;
                    }
                default:
                    {
                        throw new ArgumentException("移动方法错误");
                    }
            }
        }
    }
}
