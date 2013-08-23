using System;
using System.Collections.Generic;
using System.Text;

using AForge.Imaging;


namespace shapes
{
    class MixFiltering:IBlobsFilter
    {
        #region IBlobsFilter Members
        AnswerFilter af = new AnswerFilter();
        SyncRectangleFilter sf = new SyncRectangleFilter();
        public bool Check(Blob blob)
        {
            return af.Check(blob) || sf.Check(blob);
        }

        #endregion
    }
}
