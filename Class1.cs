using System;
using System.Collections.Generic;
using System.Text;

namespace publicAndpribate
{

    class Vector3
    {
        private float x;
        private float y;
        private float z;

        public void SetX(float temp)
        {
            if (temp <= 0)
            {
                return;
            }
            x = temp;
        }
        public void SetY(float temp)
        {
            if (temp <= 0)
            {
                return;
            }
            y = temp;
        }
        public void SetZ(float temp)
        {
            if (temp <= 0)
            {
                return;
            }
            z = temp;
        }
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

}
