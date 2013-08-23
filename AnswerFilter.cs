using System;
using System.Collections.Generic;
using System.Text;

using AForge.Imaging;

namespace shapes
{
    class AnswerFilter:IBlobsFilter
    {
        #region IBlobsFilter Members

        double fullness = 0.5;

        double areamin = 190;
        double areamax = 360;

        int ribmax = 35;
        int ribmin = 12;



        public bool Check(Blob blob)
        {
            if (blob.Area >areamin && blob.Area<areamax && blob.Fullness > fullness &&
               blob.Rectangle.Width > ribmin && blob.Rectangle.Width < ribmax
                && blob.Rectangle.Height > ribmin && blob.Rectangle.Height < ribmax
                )
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
