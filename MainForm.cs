#define demo
#undef demo

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Divelements.SandRibbon;
using System.IO;
using System.Threading;

using AForge.Imaging;
using AForge;
using AForge.Imaging.Filters;

using Atalasoft.Twain;
using System.Drawing.Printing;

using Microsoft.Win32;
using System.Globalization;

namespace shapes
{
    public partial class MainForm : RibbonForm
    {
        SplashForm splash = null;
        String[] args;


        //dongol key
        //[System.Runtime.InteropServices.DllImport("Rockey4ND.dll")]
        //static extern ushort Rockey(ushort function, out ushort handle, out uint lp1, out uint lp2,
        //    out ushort p1, out ushort p2, out ushort p3, out ushort p4, ref byte buffer);

        const ushort RY_FIND = 1;
        const ushort RY_FIND_NEXT = 2;
        const ushort RY_OPEN = 3;
        const ushort RY_CLOSE = 4;
        const ushort RY_READ = 5;
        const ushort RY_WRITE = 6;
        const ushort RY_RANDOM = 7;
        const ushort RY_SEED = 8;
        const ushort RY_WRITE_USERID = 9;
        const ushort RY_READ_USERID = 10;
        const ushort RY_SET_MOUDLE = 11;
        const ushort RY_CHECK_MOUDLE = 12;
        const ushort RY_WRITE_ARITHMETIC = 13;
        const ushort RY_CALCULATE1 = 14;
        const ushort RY_CALCULATE2 = 15;
        const ushort RY_CALCULATE3 = 16;
        const ushort RY_DECREASE = 17;

        ushort[] m_Handle = new ushort[32];
        int m_HandleNum = 0;
        uint rokeyid = 0;

        string[] rint = { "77bff3c9",    "33d7", "fafa", "a0ec", "322a",
"cbb0d432",    "57ff", "0698", "f6b6", "7e56",
"263e47f5",    "a84b", "5377", "15d9", "4b6d",
"4838724e",    "6199", "ec0e", "c88f", "1e46",
"729e21c1",    "deed", "b862", "4cd6", "8d11",
"3e9d1630",    "df2b", "d6d2", "4402", "e189",
"d5a53409",    "4092", "235d", "677f", "3a60",
"fa1b8b65",    "bf5f", "c6f6", "38c4", "03f8",
"842afefb",    "9a79", "ca02", "607a", "f5f2",
"1cfb558f",    "44cf", "2a18", "4438", "47b2",
"73971105",    "4226" ,"9612" ,"7ec0" ,"1b54",
"61d962f4"    ,"35d8" ,"c3cd" ,"a829" ,"f30f",
"93fd666a",    "545a", "6561", "cc19", "6bab",
"b0d866bb",    "0d55", "d46a", "24f8", "0bf5",
"3c1d2be7",    "3ec7", "523b", "0d5d", "2dff",
"d9d51da8",    "de88", "9f71", "d9f7", "9ad8",
"87e40f2a",    "e84d", "8ae6" ,"4882" ,"0944",
"dfedec86" ,   "05e9", "681e", "791a", "e5a8",
"2fa1162e",    "1921", "d27c", "52e6", "e0c1",
"6e5f25bd",    "4162", "4929", "56cc", "de40",
"25bb686d",    "9f55", "dd9b", "4a67", "7620",
"6ed8eb3d",    "8ec8", "feb6", "d2be", "3dab",
"dc1afeea",    "6969", "f835", "43df", "3e25",
"b359cc66",   "0762", "ae56" ,"3cde", "efd2",
"9cf4c7df",    "19be", "65c3", "66c6", "d98b",
"d4cee4a1" ,   "d1ff", "5290", "3dd7", "beb5",
"43656e01",    "0612", "4a20", "1e27", "4a2e",
"e741387b",    "627a", "05aa", "50ee", "8d8c",
"80ec1c9b",    "61fc", "c303", "2c70", "2306",
"615fbef4",    "1ec4", "f8f9", "c726", "a5e1",
"5676666a",    "0212", "9ede", "8409", "5854",
"9d15de84",    "e8ea", "f192", "40a0", "3f05",
"513dc79d",    "656e", "c58b", "5130", "fb97",
"be713573",    "ad70", "a644", "e8c1", "b8b8",
"bc7645cd",    "1eb2", "d9c6", "b452", "ad4d",
"a93134dc",    "a656", "d5e7", "ccd7", "ca37",
"88790004",    "ef7a", "00d4", "0aca", "9911",
"8ed84c54",    "9a34", "8fed", "5759", "a868",
"836182d3",    "d24c", "3fdf", "6da1", "1715",
"ae896ecd",    "7d1d", "f8bc", "2565", "190e",
"ff15f09e",    "f7a7", "9f8d", "e9cd", "5beb",
"88c334d4",    "1fbb", "7aa2", "ca52", "5f63",
"0c468c7e",    "b925", "802d", "9fd1", "cdc4",
"94bac31f",    "198f", "c26e", "c078", "a721",
"a2221f85",    "4e6b", "5d18", "5e46", "ff81",
"e975eb3d",    "31b4", "44bc", "96fb", "8666",
"2cda7bdb",    "8f1b", "a8a8", "76bb", "f2fa",
"d507e5d1",    "d113", "b21d", "7f43", "d27c",
"603f1bdf",    "ea46", "4d2d", "139f", "940e",
"ffa12766",    "1b25", "9a5e", "304c", "9749",
"a53ffe94",    "de8e", "bd57", "bf1b", "fee4",
"e6876b39",    "e545", "ec24", "8f19", "279c",
"5e9683dd",    "9138", "8f04", "6367", "526c",
"8eacf1c6",    "3a83", "9313", "78db", "2240",
"f627277d",    "5a62", "28d7", "812f", "e2d7",
"df17d82e",    "d472", "d1cc", "ee15", "4d25",
"d668b151",    "deed", "cc47", "2542", "7e1f",
"7a2e47a1",    "0aed", "c084", "324c", "d61e",
"27f3ee02",    "a4d4", "4bb7", "171a", "8daf",
"2c24a428",    "585a", "4f73", "55f1", "bc3c",
"54ee1d27",    "da7a", "d957", "f9fd", "355b",
"c1803e55",    "83a9", "66e0", "2632", "034d",
"d0ade1f7",    "06be", "108c", "2e31", "145c",
"dad0a1b5",    "515d", "cdf1", "dfff", "e280",
"60822723",    "8a92", "853a", "e0c0", "8945",
"782ab8b7",    "95b7", "5e09", "3f43", "fe7f",
"9a1453dd",    "a72d", "c8c4", "be46", "3af3",
"ee0652a8",    "68ac", "0bf6", "a44a", "9512",
"ee508a82",    "8202", "e58f", "09ad", "33da",
"4961ed07",    "3a42", "d95a", "761a", "2548",
"9cfcb77b",    "2098", "5676", "0060", "3419",
"54324f26",    "82cc", "c67c", "f212", "09ef",
"30f85ffb",    "2d05", "84fc", "abef", "ba77",
"07a17236",    "8799", "18c3", "ea90", "a383",
"f309a6be",    "69c7", "1284", "6a11", "2341",
"2c2cf8fb",    "2d65", "8896", "70cc", "3b71",
"19ed4230",    "06fe", "c898", "ee24", "0fd5",
"2c0e783a",    "3afa", "2184", "aa2c", "325c",
"6b19989e",    "0b94", "9c96", "08ca", "179d",
"963217cd",    "765c", "0d85", "9bba", "b471",
"eb0b181d",    "5393", "0799", "fb61", "3450",
"e55bb838",    "14d4", "1b9d", "c4a7", "daa4",
"89578d43",    "130d", "3f6e", "b0d5", "588a",
"a2aed3d4",    "343a", "4829", "f797", "be01",
"205b63df",    "7c5e", "09ef", "d57b", "8570",
"b476b1bb",    "db53", "c927", "42f8", "73bb",
"a3fc76ae",    "e7bb", "468a", "263c", "ccba",
"2e589371",    "7f67", "ad27", "48d0", "7b5b",
"0ca88752",    "86da", "21c3", "f039", "4c38",
"65626a96",    "49a1", "b44e", "ae0c", "8498",
"0ab01961",    "dc96", "8f33", "f561", "e45c",
"e3456c66",    "4543", "9028", "0e56", "8ffd",
"64c049c3",    "31e5", "16c0", "66ce", "4829",
"047a2c6f",    "d284", "4ecc", "7ef2", "dd8b",
"b4147882",    "5921", "20ca", "2e56", "9b42",
"3372b702",    "2ce6", "dc3f", "2656", "8d82",
"fd1e1c30",    "793f", "0984", "5ec6", "6d09",
"e719d6da",    "95f4", "0871", "37bf", "3d25",
"819b7a32",    "52b8", "efe5", "13b5", "6f1d",
"6ba7c863",    "cc3a", "3d65", "4e2c", "c002", };

        [System.Runtime.InteropServices.DllImport("Rockey4ND.dll")]
        static extern ushort Rockey(ushort function, out ushort handle, out uint lp1, out uint lp2,
            out ushort p1, out ushort p2, out ushort p3, out ushort p4, ref byte buffer);

        public MainForm(SplashForm spl, string[] arg)
        {
            splash = spl;
            args = arg;
            InitializeComponent();
        }

        String currentFile = String.Empty;

        List<ExamImage> examImagesList = new List<ExamImage>();

        public String CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        }




        private void print_btn_Click(object sender, EventArgs e)
        {
            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show(this, "لايوجد طابعة موصولة بجهاز الحاسب!", "خطأطباعة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            PrintForm frm = new PrintForm();
            frm.Headertxt = DateTime.Now.ToString();
            frm.ShowDialog(this);
        }

        private void exam_btn_Click(object sender, EventArgs e)
        {
            examdbForm frm = new examdbForm();
            frm.MdiParent = this;
            frm.Visible = true;
        }

        private void print_form_menu_Activate(object sender, EventArgs e)
        {
            print_form_btn_Activate(sender, e);
        }

        private void open_exam_menu_Activate(object sender, EventArgs e)
        {
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif




            if (getExamForm() != null)
            {
                MessageBox.Show(this, "هناك قاعدة بيانات قيد العمل قم باغلاقها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (ofdlg.ShowDialog(this) == DialogResult.OK)
            {
                if (File.Exists(ofdlg.FileName))
                {
                    currentFile = ofdlg.FileName;
                    examdbForm frm = new examdbForm();
                    frm.ApplicationText = ofdlg.FileName;
                    frm.MdiParent = this;
                    frm.Visible = true;
                    ExamImagesForm frm1 = new ExamImagesForm();
                    frm1.List = examImagesList;
                    frm1.MdiParent = this;
                    frm1.Visible = true;
                    savefiles(ofdlg.FileName);
                }
            }
        }

        private examdbForm getExamForm()
        {
            foreach (Form item in MdiChildren)
            {
                if (item is examdbForm)
                {
                    return item as examdbForm;
                }
            }
            return null;
        }

        private void open_btn_Activate(object sender, EventArgs e)
        {
            open_exam_menu_Activate(sender, e);
        }

        private void new_exam_menu_Activate(object sender, EventArgs e)
        {


#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif

            if (getExamForm() != null)
            {
                MessageBox.Show(this, "هناك قاعدة بيانات قيد العمل قم باغلاقها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (sfdlg.ShowDialog(this) == DialogResult.OK)
            {

                FileStream fs = File.Create(sfdlg.FileName);
                fs.Write(global::shapes.Properties.Resources.defaultdb, 0
                    , global::shapes.Properties.Resources.defaultdb.Length);
                fs.Close();
                currentFile = sfdlg.FileName;
                examdbForm frm = new examdbForm();
                frm.ApplicationText = sfdlg.FileName;
                frm.MdiParent = this;
                frm.Visible = true;
                ExamImagesForm frm1 = new ExamImagesForm();
                frm1.List = examImagesList;
                frm1.MdiParent = this;
                frm1.Visible = true;
                savefiles(sfdlg.FileName);
            }
        }

        private void new_btn_Activate(object sender, EventArgs e)
        {
            new_exam_menu_Activate(sender, e);
        }

        private void v_form_btn_Activate(object sender, EventArgs e)
        {

#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif


            PrintForm frm = new PrintForm();

            examdbForm efrm = getExamForm();
            if (efrm != null)
            {
                try
                {
                    String s = efrm.examdb.exam[0][3].ToString();
                    String d = ((DateTime)efrm.examdb.exam[0][2]).ToString("d-M-yyyy");
                    frm.Headertxt = string.Format("{0} بتاريخ {1} م", s, d);
                }
                catch { }
            }


            frm.MdiParent = this;
            frm.Visible = true;

        }

        private void scan_select_btn_Activate(object sender, EventArgs e)
        {
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif
            if (scanner.SystemHasTwain && scanner.Devices.Count > 0)
            {
                Device d = scanner.ShowSelectSource();
                if (d == null)
                {
                    d = scanner.Devices.Default;
                }
            }

        }

        private void scan_btn1_Activate(object sender, EventArgs e)
        {

#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif


            this.Cursor = Cursors.WaitCursor;
            if (getExamForm() == null)
            {
                MessageBox.Show(this, "لاتوجد قاعدة بيانات فعالة حاليا", "قاعدة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (scanner.Devices.Count == 0)
            {
                MessageBox.Show(this, "لايوجد ماسح ضوئي متصل حاليا بجهاز الحاسب.", "ماسح ضوئي", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (scanner.Devices.Default == null)
            {
                scanner.ShowSelectSource();
            }


            try
            {
                scanner.Acquire();
            }
            catch { }
            this.Cursor = Cursors.Default;

        }

        private void scanner_ImageAcquired(object sender, AcquireEventArgs e)
        {

            Thread th = new Thread(new ParameterizedThreadStart(analysisImage));
            th.Start(e);
            //goExamPage(e);
        }

        void analysisImage(Object e)
        {
            AcquireEventArgs ee = e as AcquireEventArgs;
            ExamImage examimg = new ExamImage(ee.Image);
            examimg.fillAnswer();
            examimg.Mark = getmark(examimg.Answerarr);
            addImage(examimg);
        }

        delegate void goPage(Object e);

        void addImage(Object e)
        {
            if (this.InvokeRequired)
            {
                goPage go = new goPage(addImage);
                this.BeginInvoke(go, new object[] { e });
                return;
            }
            ExamImage img = e as ExamImage;
            if (img.StuNumber < 0)
            {
                examImagesList.Add(img);
            }
            else
            {
                if (!examImagesList.Contains(img))
                {
                    examImagesList.Add(img);
                }
            }
            foreach (Form item in this.MdiChildren)
            {
                if (item is ExamImagesForm)
                {
                    (item as ExamImagesForm).List = examImagesList;
                }
            }
            stat_l.Text = examImagesList.Count.ToString();
        }

        int getmark(int[] arr)
        {
            Int64 m4q = 1;
            examdbForm frm = getExamForm();
            if (frm == null)
            {
                return 0;
            }
            m4q = (Int64)frm.examdb.exam[0][5];
            if (m4q <= 0)
            {
                MessageBox.Show(this, "هناط خطا العلامة يجب أن تكون أكبر من الصفر", "خطأ العلامة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            examdb.qDataTable qt = frm.examdb.q;
            int mark = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 1 && arr[i] <= 5)
                {
                    Int64 a = (Int64)qt[i][1];
                    if (arr[i] == a && a != 0)
                    {
                        mark++;
                    }
                }
            }

            return (int)(mark * m4q);
        }

        private void scanner_AcquireFinished(object sender, EventArgs e)
        {

        }

        private void close_btn_Activate(object sender, EventArgs e)
        {
            if (getExamForm() == null)
            {
                return;
            }
            if (MessageBox.Show(this, "هل تريد إغلاق قاعدة البيانات الحالية؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (Form item in MdiChildren)
                    {
                        //item.Dispose();
                        item.Hide();
                        item.Close();
                    }
                    examImagesList.Clear();
                }
                catch { }
            }


        }

        private void res_window_btn_Activate(object sender, EventArgs e)
        {
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif

            if (getExamForm() != null)
            {
                ExamImagesForm frm = null;
                foreach (Form item in MdiChildren)
                {
                    if (item is ExamImagesForm)
                    {
                        frm = item as ExamImagesForm;
                        break;
                    }
                }
                if (frm == null)
                {
                    frm = new ExamImagesForm();
                    frm.List = examImagesList;
                    frm.MdiParent = this;
                    frm.Visible = true;
                }
                else
                {
                    frm.Close();
                    frm.Dispose();
                }
            }
        }

        private void todb_btn_Activate(object sender, EventArgs e)
        {
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif

            examdbForm frm = getExamForm();
            if (frm != null)
            {
                frm.studentBindingSource.EndEdit();
                foreach (ExamImage item in examImagesList)
                {
                    if (item.StuNumber < 0)
                    {
                        continue;
                    }
                    frm.studentBindingSource.Filter = String.Format("stu_num = {0}", item.StuNumber);
                    if (frm.studentBindingSource.Count > 0)
                    {
                        (frm.studentBindingSource[0] as DataRowView)[2] = item.Mark;
                    }
                    else
                    {
                        DataRowView rw = frm.studentBindingSource.AddNew() as DataRowView;

                        rw[0] = (Int64)item.StuNumber;
                        rw[2] = (Int64)item.Mark;
                        rw[1] = "";
                        rw.EndEdit();
                    }
                }

                frm.studentBindingSource.EndEdit();
                frm.studentTableAdapter.Update(frm.examdb.student);
                frm.studentBindingSource.RemoveFilter();

            }
        }


        private void print_exam_btn_Activate(object sender, EventArgs e)
        {
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif


            if (getExamForm() == null)
            {
                return;
            }
            StudentPrintForm frm = new StudentPrintForm();
            frm.ShowDialog(this);
        }

        private void print_form_btn_Activate(object sender, EventArgs e)
        {

#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif

            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show(this, "لايوجد طابعة موصولة بجهاز الحاسب!", "خطأطباعة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            ExamPrintPage doc = new ExamPrintPage();
            //doc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            examdbForm efrm = getExamForm();
            if (efrm != null)
            {
                try
                {
                    String s = efrm.examdb.exam[0][3].ToString();
                    String d = ((DateTime)efrm.examdb.exam[0][2]).ToString("d-M-yyyy");
                    doc.Headertxt = string.Format("{0} بتاريخ {1} م", s, d);
                }
                catch { }
            }

            //ppdlg.Document = doc;
            //ppdlg.ShowDialog(this);



            if (printdlg.ShowDialog(this) == DialogResult.OK)
            {
                // int count = int.Parse(input.input.Text);
                doc.PrinterSettings = printdlg.PrinterSettings;
                //doc.PrinterSettings.PaperSizes
                doc.DocumentName = "Exam";
                doc.Print();
            }





        }


        //printdlg.Document = doc;
        //printdlg.ShowDialog(this);



        private void a_print_form_btn_Activate(object sender, EventArgs e)
        {
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];

            #endregion

            #region check rokey
            Random mainrand = new Random((int)DateTime.Now.ToBinary());
            int chose = mainrand.Next(0, 10);

            switch (chose)
            {
                case 5: uint uid;
                    ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret != 0)
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                        this.Close();
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                        if (uid != iid)
                        {
                            MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    break;
                case 1: p1 = 0;
                    ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);

                    if (ret == 0)
                    {
                        if (p2 <= 0)
                        {
                            MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 2: Random rand = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand.Next(256);
                    p2 = (ushort)rand.Next(256);
                    p3 = (ushort)rand.Next(256);
                    p4 = (ushort)rand.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p11 = p1;
                    ushort p22 = p2;
                    ushort p33 = p3;
                    ushort p44 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p11, ref p22, ref p33, ref p44);
                        if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                case 3: p1 = 0;
                    p2 = 12;
                    ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                        if (ss != null && ss.Equals("Exam Program"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }

                    break;
                case 4: Random rand2 = new Random((int)DateTime.Now.ToBinary());
                    int index = rand2.Next(0, 99);
                    lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
                    ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
                    ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
                    ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
                    ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
                    ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
                       out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                        {
                            MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
                default: Random rand55 = new Random((int)DateTime.Now.ToBinary());

                    p1 = (ushort)rand55.Next(256);
                    p2 = (ushort)rand55.Next(256);
                    p3 = (ushort)rand55.Next(256);
                    p4 = (ushort)rand55.Next(256);
                    lp1 = 0;
                    lp2 = 0;
                    ushort p111 = p1;
                    ushort p222 = p2;
                    ushort p333 = p3;
                    ushort p444 = p4;
                    ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                        out p1, out p2, out p3, out p4, ref buffer[0]);
                    if (ret == 0)
                    {
                        calc(ref p111, ref p222, ref p333, ref p444);
                        if (!((p1 == p111) && (p2 == p222) && (p3 == p333) && (p4 == p444)))
                        {
                            MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                        this.Close();
                        Application.Exit();
                        return;
                    }
                    break;
            }



            #endregion
#endif

            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show(this, "لايوجد طابعة موصولة بجهاز الحاسب!", "خطأطباعة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            ExamPrintPage doc = new ExamPrintPage();
            examdbForm efrm = getExamForm();
            if (efrm != null)
            {
                try
                {
                    String s = efrm.examdb.exam[0][3].ToString();
                    String d = ((DateTime)efrm.examdb.exam[0][2]).ToString("d-M-yyyy");
                    doc.Headertxt = string.Format("{0} بتاريخ {1} م", s, d);
                }
                catch { }
            }
            else
            {
                return;
            }

            //ppdlg.Document = doc;
            //ppdlg.ShowDialog(this);



            PrinterSettings ps = new PrinterSettings();
            // MessageBox.Show(efrm.examdb.exam[0][4].GetType().ToString());
            ps.Copies = (short)((Int64)efrm.examdb.exam[0][4]);
            doc.PrinterSettings = ps;
            doc.DocumentName = "Exam";
            doc.Print();
            //printdlg.Document = doc;
            //printdlg.ShowDialog(this);

        }

        private void scaner_menu_Activate(object sender, EventArgs e)
        {
            scan_select_btn_Activate(sender, e);
        }

        private void option_menu_Activate(object sender, EventArgs e)
        {
            SettingForm frm = new SettingForm();
            frm.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {



            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
            if (key != null)
            {
                Object theme = key.GetValue("theme");
                if (theme == null)
                {
                    key.SetValue("theme", 0);
                }
                int color = int.Parse(key.GetValue("theme").ToString());
                switch (color)
                {
                    case 0: ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.System;

                        break;
                    case 1: ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.LunaBlue;
                        break;
                    case 2: ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Silver;
                        break;
                    case 3: ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Vista;
                        break;
                    default: ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.System;
                        break;
                }


                String[] s = docs(key);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s.Length > 0)
                    {
                        applicationMenu1.RecentDocuments.Add(s[i]);
                    }
                }

                key.Close();
            }


            if (args.Length > 0)
            {
                if (getExamForm() != null)
                {
                    MessageBox.Show(this, "هناك قاعدة بيانات قيد العمل قم باغلاقها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                if (File.Exists(args[0]))
                {
                    currentFile = args[0];
                    examdbForm frm = new examdbForm();
                    frm.ApplicationText = args[0];
                    frm.MdiParent = this;
                    frm.Visible = true;
                    ExamImagesForm frm1 = new ExamImagesForm();
                    frm1.List = examImagesList;
                    frm1.MdiParent = this;
                    frm1.Visible = true;
                    savefiles(ofdlg.FileName);
                }
                else
                {
                    MessageBox.Show(this, String.Format("الملف {0} غير موجود", args[0]), "خطأ ملف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
#if demo
            DateTime t = new DateTime(2011, 12, 1);
            DateTime t1 = DateTime.Now;
            if (t.CompareTo(t1) <= 0)
            {
                MessageBox.Show(this, "نسخة تجريبة اتصل على 0954633564...", "نسخة تجريبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
#else
            #region init rokey
            ushort ret;
            ushort p1, p2, p3, p4;
            uint lp1, lp2;
            byte[] buffer = new byte[1024];
            String s1 = "a965";
            string s2 = "659a";
            p1 = ushort.Parse(s1, NumberStyles.HexNumber);
            p2 = ushort.Parse(s2, NumberStyles.HexNumber);
            p3 = 0;
            p4 = 0;

            ret = Rockey(RY_FIND, out m_Handle[0], out lp1, out lp2, out p1, out p2, out p3, out p4, ref buffer[0]);
            if (ret != 0)
            {
                MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                this.Close();
                Application.Exit();
                return;
            }
            else
            {
                rokeyid = lp1;
            }
            ret = Rockey(RY_OPEN, out m_Handle[0], out rokeyid, out lp2, out p1, out p2, out p3, out p4, ref buffer[0]);
            if (ret != 0)
            {
                MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                this.Close();
                Application.Exit();
                return;
            }
            #endregion


            #region check rokey
            uint uid;
            ret = Rockey(RY_READ_USERID, out m_Handle[0], out uid, out lp2,
                out p1, out p2, out p3, out p4, ref buffer[0]);
            if (ret != 0)
            {
                MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");

                this.Close();
                Application.Exit();
                return;
            }
            else
            {
                uint iid = uint.Parse("13822913", NumberStyles.HexNumber);
                if (uid != iid)
                {
                    MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                    this.Close();
                    Application.Exit();
                    return;
                }
            }
            p1 = 0;
            ret = Rockey(RY_CHECK_MOUDLE, out m_Handle[0], out lp1, out lp2,
                out p1, out p2, out p3, out p4, ref buffer[0]);

            if (ret == 0)
            {
                if (p2 <= 0)
                {
                    MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                    this.Close();
                    Application.Exit();
                    return;
                }
            }
            else
            {
                MessageBox.Show("جهاز الحماية لايحمل الموديل المناسب");
                this.Close();
                Application.Exit();
                return;
            }
            Random rand = new Random((int)DateTime.Now.ToBinary());

            p1 = (ushort)rand.Next(256);
            p2 = (ushort)rand.Next(256);
            p3 = (ushort)rand.Next(256);
            p4 = (ushort)rand.Next(256);
            lp1 = 0;
            lp2 = 0;
            ushort p11 = p1;
            ushort p22 = p2;
            ushort p33 = p3;
            ushort p44 = p4;
            ret = Rockey(RY_CALCULATE1, out m_Handle[0], out lp1, out lp2,
                out p1, out p2, out p3, out p4, ref buffer[0]);
            if (ret == 0)
            {
                calc(ref p11, ref p22, ref p33, ref p44);
                if (!((p1 == p11) && (p2 == p22) && (p3 == p33) && (p4 == p44)))
                {
                    MessageBox.Show("خطأء حسابي في دارة الحماية سيتم إغلاق البرنامج");
                    this.Close();
                    Application.Exit();
                    return;
                }
            }
            else
            {
                MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                this.Close();
                Application.Exit();
                return;
            }
            p1 = 0;
            p2 = 12;
            ret = Rockey(RY_READ, out m_Handle[0], out lp1, out lp2,
                out p1, out p2, out p3, out p4, ref buffer[0]);
            if (ret == 0)
            {
                String ss = Encoding.ASCII.GetString(buffer, 0, 12);
                if (ss != null && ss.Equals("Exam Program"))
                {

                }
                else
                {
                    MessageBox.Show("خطأ أثناء القراءة من جهاز الحماية الرجاء التأكد منه.");
                    this.Close();
                    Application.Exit();
                    return;
                }
            }
            else
            {
                MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                this.Close();
                Application.Exit();
                return;
            }
            Random rand2 = new Random((int)DateTime.Now.ToBinary());
            int index = rand2.Next(0, 99);
            lp2 = uint.Parse(rint[index * 5], NumberStyles.HexNumber);
            ushort x1 = ushort.Parse(rint[(index * 5) + 1], NumberStyles.HexNumber);
            ushort x2 = ushort.Parse(rint[(index * 5) + 2], NumberStyles.HexNumber);
            ushort x3 = ushort.Parse(rint[(index * 5) + 3], NumberStyles.HexNumber);
            ushort x4 = ushort.Parse(rint[(index * 5) + 4], NumberStyles.HexNumber);
            ret = Rockey(RY_SEED, out m_Handle[0], out lp1, out lp2,
               out p1, out p2, out p3, out p4, ref buffer[0]);
            if (ret == 0)
            {
                if (!((p1 == x1) && (p2 == x2) && (p3 == x3) && (p4 == x4)))
                {
                    MessageBox.Show("خطأ أثناء التحقق من كود جهاز الحماية.");
                    this.Close();
                    Application.Exit();
                    return;
                }
            }
            else
            {
                MessageBox.Show("لايوجد جهاز الحماية, الرجاء وصل الجهاز ثم تشغيل البرنامج.");
                this.Close();
                Application.Exit();
                return;
            }




            #endregion
#endif
            if (splash != null)
            {
                splash.Dispose();
            }
        }

        void calc(ref ushort a, ref ushort b, ref ushort c, ref ushort d)
        {
            a = (ushort)(b | c);
            b = (ushort)(c | d);
            c = (ushort)(d & a);
            d = (ushort)(a & b);
            a = (ushort)(b * d);
            b = (ushort)(a + c);
            c = (ushort)(b - a);
            d = (ushort)(b * c);

        }

        internal void loaddocs()
        {
            applicationMenu1.RecentDocuments.Clear();
            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
            String[] s = docs(key);
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length > 0)
                {
                    applicationMenu1.RecentDocuments.Add(s[i]);
                }
            }

            key.Close();
        }

        String[] docs(RegistryKey key)
        {
            String[] st = new String[6];
            for (int i = 0; i < 6; i++)
            {
                object f1 = key.GetValue("f" + i);
                if (f1 == null)
                {
                    key.SetValue("f" + i, string.Empty);
                }
                string fl1 = key.GetValue("f" + i).ToString();

                st[i] = fl1;
            }
            return st;

        }

        private void about_menu_Activate(object sender, EventArgs e)
        {
            SplashForm frm = new SplashForm();
            frm.linkl.Visible = true;
            frm.ShowDialog(this);
        }

        private void applicationMenu1_ShowOptions(object sender, EventArgs e)
        {
            SettingForm frm = new SettingForm();
            frm.ShowDialog(this);
        }

        void savefiles(String file)
        {
            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
            String[] s = docs(key);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(file))
                {
                    return;
                }
            }

            for (int i = 4; i >= 0; i--)
            {
                s[i + 1] = s[i];
            }
            s[0] = file;
            key.SetValue("f0", s[0]);
            key.SetValue("f1", s[1]);
            key.SetValue("f2", s[2]);
            key.SetValue("f3", s[3]);
            key.SetValue("f4", s[4]);
            key.SetValue("f5", s[5]);
            key.Close();
            loaddocs();
        }

        private void applicationMenu1_LoadDocument(object sender, DocumentInformationEventArgs e)
        {
            if (getExamForm() != null)
            {
                MessageBox.Show(this, "هناك قاعدة بيانات قيد العمل قم باغلاقها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (File.Exists(e.Document.Path))
            {
                currentFile = e.Document.Path;
                examdbForm frm = new examdbForm();
                frm.ApplicationText = e.Document.Path;
                frm.MdiParent = this;
                frm.Visible = true;
                ExamImagesForm frm1 = new ExamImagesForm();
                frm1.List = examImagesList;
                frm1.MdiParent = this;
                frm1.Visible = true;
                //savefiles(ofdlg.FileName);
            }
            else
            {
                MessageBox.Show(this, String.Format("الملف {0} غير موجود", e.Document.Path), "خطأ ملف", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
#if ! demo
            if (m_Handle[0] != 0)
            {
                ushort p1, p2, p3, p4;
                uint lp1, lp2;
                byte[] buffer = new byte[1024];
                Rockey(RY_CLOSE, out m_Handle[0], out lp1, out lp2, out p1, out p2, out p3, out p4, ref buffer[0]);
            }
#endif

        }
    }
}
