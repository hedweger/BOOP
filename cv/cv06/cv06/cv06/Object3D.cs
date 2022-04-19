using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    abstract class Object3D : GrObject
    {
        public abstract double CountSurface();
        public abstract double CountVolume();
    }
}
