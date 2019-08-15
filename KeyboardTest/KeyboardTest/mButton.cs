using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTest
{
    class mButton
    {
        public int btnX;
        public int btnY;
        public int btnW;
        public int btnH;

        public mButton(int X,int Y,int W,int H)
        {
            btnX = X;
            btnY = Y;
            btnW = W;
            btnH = H;
        }
        public mButton(mButtonItem mbi)
        {
            btnX = mbi.X;
            btnY = mbi.Y;
            btnW = mbi.W;
            btnH = mbi.H;
        }
    }

}
