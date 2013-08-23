using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using AForge.Imaging;
using AForge.Imaging.Filters;

namespace shapes
{
    class ExamImage : IEquatable<ExamImage>
    {
        //ازاحة نفس السطر
        static int rowOffset=10;
        //ازاحة الصفحة هامش
        static int pagemarg = 120;
        //ضلع المربع اللذي يحوي الدوائر
        static int reb = 25;
        //نصف قطر الدائرة
        static int radius = 11;

        Bitmap img;
        Bitmap orgimg;

        public Bitmap Orgimg
        {
            get { return orgimg; }
            set { orgimg = value; }
        }
        int stuNumber = -3;

        public int StuNumber
        {
            get { return stuNumber; }
            set { stuNumber = value; }
        }

        int mark;

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }


        int[] answerarr = new int[100];

        public int[] Answerarr
        {
            get { return answerarr; }
        }

        internal Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }
        Blob[] answers;
        Blob[] syncboxs;

        static object syob= new object();

        internal ExamImage(Bitmap im) {
            lock (syob)
            {
                orgimg = im;
                this.img =  AForge.Imaging.Image.Clone(im, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
            //img = im;
            Invert inv = new Invert();
            inv.ApplyInPlace(img);
            //BlobsFiltering bf = new BlobsFiltering(new MixFiltering());
            //bf.ApplyInPlace(img);
            BlobCounter bc = new BlobCounter();
            bc.BlobsFilter = new SyncRectangleFilter();
            bc.FilterBlobs = true;
            bc.CoupledSizeFiltering = true;
            bc.ProcessImage(img);
            syncboxs = bc.GetObjects(img, true);

            if (isFlip())
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                bc.ProcessImage(img);
                syncboxs = bc.GetObjects(img, true);
            }

            bc.BlobsFilter = new AnswerFilter();
            bc.ProcessImage(img);
            answers = bc.GetObjects(img, true);


            stuNumber = getNumber();

        }

        internal bool isvalid()
        {
            if (syncboxs.Length!=37)
            {
                return false;
            }
            if (syncboxs[0].CenterOfGravity.X-syncboxs[36].CenterOfGravity.X>8)
            {
                return false;
            }
            
            return true;
        }

         bool isFlip()
        {
            if (Math.Abs(syncboxs[3].CenterOfGravity.Y - syncboxs[2].CenterOfGravity.Y) > 60)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool atSameRow(Blob org, Blob blob)
        {
            int orgy = org.CenterOfGravity.Y;
            int bloby = blob.CenterOfGravity.Y;
            if (Math.Abs(orgy - bloby) < rowOffset)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal int getNumber()
        {
            if (!isvalid())
            {
                //إمامائلة أو عدد مربعات المزامنة غير صحيح
                return -1;
            }

            Blob[] r1 = blobAtRow(syncboxs[0], answers);
            Blob[] r2 = blobAtRow(syncboxs[1], answers);
            Blob[] r3 = blobAtRow(syncboxs[2], answers);
            if (r1.Length>1||r1.Length==0
                ||r2.Length>1||r2.Length==0
                ||r3.Length>1||r3.Length==0)
            {
                List<Blob> sy1 = new List<Blob>();
                for (int i = 0; i < syncboxs.Length; i++)
                {
                    sy1.Add(syncboxs[i]);
                }
                sy1.RemoveAt(0);
                sy1.RemoveAt(0);
                sy1.RemoveAt(0);
                syncboxs = sy1.ToArray();
                //أكثر من عنصر في نفس السطر في مصفوفة الرقم
                return -2;
            }

            double q1 = r1[0].CenterOfGravity.X - syncboxs[0].Rectangle.X - pagemarg - radius;
            int n1 = 10 - (int)(Math.Ceiling((double)(q1 / reb)));
            double q2 = r2[0].CenterOfGravity.X - syncboxs[1].Rectangle.X - pagemarg - radius;
            int n2 = 10 - (int)(Math.Ceiling((double)(q2 / reb)));
            double q3 = r3[0].CenterOfGravity.X - syncboxs[2].Rectangle.X - pagemarg - radius;
            int n3 = 10 - (int)(Math.Ceiling((double)(q3 / reb)));


            List<Blob> sy = new List<Blob>();
            for (int i = 0; i < syncboxs.Length; i++)
			{
                sy.Add(syncboxs[i]);   
            }
            sy.RemoveAt(0);
            sy.RemoveAt(0);
            sy.RemoveAt(0);
            syncboxs = sy.ToArray();

            List<Blob> ans = new List<Blob>();
            foreach (Blob item in answers)
            {
                ans.Add(item);
            }

            ans.Remove(r1[0]);
            ans.Remove(r2[0]);
            ans.Remove(r3[0]);

            answers = ans.ToArray();

            int num = (n3 * 100 )+ (n2 * 10 )+ n1;
            if (num >= 0 && num <= 999)
            {
                return num;
            }
            else {
                //الرقم غير منطقي
                return -3;
            }
          
        }



        Blob[] blobAtRow(Blob row,Blob[] blobs) {

            List<Blob> blo = new List<Blob>();
            foreach (Blob item in blobs)
            {
                if (atSameRow(row,item))
                {
                    blo.Add(item);
                }
            }

            return blo.ToArray();
          
        }


        internal void fillAnswer()
        {

            for (int i = 0; i < syncboxs.Length; i++)
            {
                Blob[] row = blobAtRow(syncboxs[i], answers);
                foreach (Blob item in row)
                {
                    double q = item.CenterOfGravity.X - syncboxs[i].Rectangle.X - pagemarg - radius;
                    if (q<150)
                    {
                        int n = 6 - (int)(Math.Ceiling((double)(q / reb)));
                        if (answerarr[i + 68] != 0)
                        {
                            answerarr[i + 68] = -1;
                        }
                        else {
                            answerarr[i + 68] = n;
                        }
                    }
                    else if (q < 350)
                    {
                        q -= 200;
                        int n = 6 - (int)(Math.Ceiling((double)(q / reb)));
                        if (answerarr[i + 34] != 0)
                        {
                            answerarr[i + 34] = -1;
                        }
                        else
                        {
                            answerarr[i + 34] = n;
                        }
                    }
                    else {
                        q -= 400;
                        int n = 6- (int)(Math.Ceiling((double)(q / reb)));
                        if (answerarr[i ] != 0)
                        {
                            answerarr[i ] = -1;
                        }
                        else
                        {
                            answerarr[i ] = n;
                        }
                    }
                }
                
            }
        
        }





        #region IEquatable<ExamImage> Members

        public bool Equals(ExamImage other)
        {
            return this.StuNumber == other.StuNumber;
        }

        #endregion

        public override string ToString()
        {
            return StuNumber.ToString()+":"+Mark.ToString();
        }
    }
}
