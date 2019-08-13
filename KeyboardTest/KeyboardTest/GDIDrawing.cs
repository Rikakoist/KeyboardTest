using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KeyboardTest
{
    class KeyboardDrawing
    {
        //总绘制方法
        internal static void Draw(int ButtonValue, PictureBox TargetPictureBox)
        {
            
            TargetPictureBox.Refresh();
        }



        //清空图片框
        internal static void ClearPictureBox(PictureBox TargetPictureBox)
        {
            Graphics g = Graphics.FromImage(TargetPictureBox.BackgroundImage);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //白色底色清空
            //Brush ClearBrush = new SolidBrush(Color.White);
            //Rectangle Clear = new Rectangle(0, 0, TargetPictureBox.Width, TargetPictureBox.Height);
            //g.FillRectangle(ClearBrush, Clear);
            //float Width = TargetPictureBox.Width;
            //float Height = TargetPictureBox.Height;

            TargetPictureBox.Refresh();
        }
    }
}
