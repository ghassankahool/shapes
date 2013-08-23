using System;
using System.Collections.Generic;
using System.Text;

using AForge.Imaging;

namespace shapes
{
    class SyncRectangleFilter : IBlobsFilter
    {
        #region IBlobsFilter Members

        double fullness=0.6;

        double areamax = 250;
        double areamin = 150;

        int widthmax=35;
        int heightmax=10;
        int widthmin = 24;
        int heightmin = 5;


        public bool Check(Blob blob)
        {
            if( blob.Area>areamin
                &&blob.Area<areamax
                && blob.Fullness>fullness
                &&blob.Rectangle.Width<widthmax
                &&blob.Rectangle.Width>widthmin
                &&blob.Rectangle.Height<heightmax
                &&blob.Rectangle.Height>heightmin){
                    return true;
            }
            return false;
        }

        #endregion
    }
}
