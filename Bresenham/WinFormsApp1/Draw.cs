using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal  class Draw
    {
        int WidthOffset, HeightOffset;
        int Width,Height;
        public Bitmap Board { get; private set; }
        public Draw(int width,int height)
        {
            Board = new Bitmap(width,height);
            Width = width;
            Height = height;
            WidthOffset = width/2;
            HeightOffset = height/2;
        }

        private void BresenhamLine(int x1, int y1, int x2, int y2)
        {
            int x = x1, y = y1;
            int dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1);
            int dt = 2 * (dy - dx), ds = 2 * dy, d = 2 * dy - dx;

            int sy = (y1 > y2 ? -1 : 1);
            int sx = (x1 > x2 ? -1 : 1);

            if (x1 == x2)
            {
                for (y = y1; y != y2; y += sy)
                {

                    SetPixelSafe(x1, y, Color.Red);
                }
                return;
            }

            SetPixelSafe(x, y, Color.Red);
            //if dx>dy
            for (x += sx; x != x2; x += sx)
            {
                if (d > 0) 
                {
                    d += dt;
                    y += sy;
                }
                else
                    d += ds;
                SetPixelSafe(x, y, Color.Red);

            }

        }
        private void SetPixelSafe(int x, int y, Color color)
        {
            x += WidthOffset;
            y = HeightOffset - y;
            if (x >= 0 && x < Board.Width && y >= 0 && y < Board.Height)
            {
                Board.SetPixel(x, y, color);
            }
        }
        private void BresenhamCircle(int r , int h=0 ,int k=0)
        {
            int x, y= r;
            int d = 3 - (2 * r);

            for(x=0;x<=y;x++)
            {
                SetPixelSafe(x + h, y + k, Color.Red);
                SetPixelSafe(-x + h, y + k, Color.Red);
                SetPixelSafe(x + h, -y + k, Color.Red);
                SetPixelSafe(-x + h, -y + k, Color.Red);

                SetPixelSafe(y + h, x + k, Color.Red);
                SetPixelSafe(-y + h, x + k, Color.Red);
                SetPixelSafe(y + h, -x + k, Color.Red);
                SetPixelSafe(-y + h, -x + k, Color.Red);

                if (d < 0)
                    d += 4 * x + 6;
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
            }
        }
        private void CircleTrigonometricMethod(int r, int h = 0, int k = 0)
        {
            int x, y;
            float xf, yf, theta;
            for (theta = 0; theta <= 45; theta += 0.01f)
            {
                double rad = theta * Math.PI / 180.0;

                xf = (float)(r * Math.Cos(rad));
                yf = (float)(r * Math.Sin(rad));

                x = (int)Math.Floor(xf + 0.5f);
                y = (int)Math.Floor(yf + 0.5f);

                SetPixelSafe(x + h, y + k, Color.Red);
                SetPixelSafe(-x + h, y + k, Color.Red);
                SetPixelSafe(x + h, -y + k, Color.Red);
                SetPixelSafe(-x + h, -y + k, Color.Red);

                SetPixelSafe(y + h, x + k, Color.Red);
                SetPixelSafe(-y + h, x + k, Color.Red);
                SetPixelSafe(y + h, -x + k, Color.Red);
                SetPixelSafe(-y + h, -x + k, Color.Red);

            }
        }
       
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            BresenhamLine(x1, y1, x2, y2);
        }
        public void DrawCircle(int r, int h = 0, int k = 0)
        {
            BresenhamCircle(r, h, k);
            //CircleTrigonometricMethod(r, h, k);
        }
        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            BresenhamLine(x1, y2, x2, y2);
            BresenhamLine(x1, y1, x2, y1);
            BresenhamLine(x1, y1, x1, y2);
            BresenhamLine(x2, y1, x2, y2);
        }
        public void ClearBoard()
        {
            Board.Dispose();
            Board = new Bitmap(Width, Height);
        }
    }
}
