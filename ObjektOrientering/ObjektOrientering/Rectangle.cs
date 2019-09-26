using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrientering
{
    class Rectangle
    {
        public int height = 10;
        public int width = 20;

        public int Omkrets(int width, int height)
        {
            return (width + height) * 2;
        }
        public int Area(int width, int height)
        {
            return width * height;
        }
    }
}
