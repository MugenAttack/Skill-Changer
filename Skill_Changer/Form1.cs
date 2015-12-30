using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Msgfile;

namespace Skill_Changer
{
    struct CharName
    {
        public int ID;
        public string Name;

        public CharName(int i, string n)
        {
            ID = i;
            Name = n;
        }
    }

    struct skill
    {
        public string Name;
        public short ID;
    }

    struct Char_Data
    {
        public short[] SuperIDs;
        public short[] UltimateIDs;
        public short EvasiveID;
    }

    public partial class Form1 : Form
    {
        skill[] Supers;
        skill[] Ultimates;
        skill[] Evasives;
        Char_Data[] Chars;
        msg mText = new msg();
        bool Lock = false;
        int CharCount = 0;
        int CharAddress = 0;
        string FileName;
        CharName[] clist = new CharName[] {
            new CharName(0, "Goku"),
            new CharName(1, "Bardock"),
            new CharName(2, "Goku SSJ4"),
            new CharName(3, "Goku SSJGod"),
            new CharName(4, "Goku GT"),
            new CharName(5, "Goten"),
            new CharName(6, "Gohan kid"),
            new CharName(7, "Gohan Teen"),
            new CharName(8, "Gohan Adult"),
            new CharName(9, "Piccolo"),
            new CharName(10, "Krillin"),
            new CharName(11, "Yamcha"),
            new CharName(12, "Tien"),
            new CharName(13, "Raditz"),
            new CharName(14, "Saibaman"),
            new CharName(15, "Nappa"),
            new CharName(16, "Vegeta"),
            new CharName(17, "Vegeta SSJ4"),
            new CharName(18, "Guldo"),
            new CharName(19, "Burter"),
            new CharName(20, "Recoome"),
            new CharName(21, "Jeice"),
            new CharName(22, "Ginyu"),
            new CharName(23, "Frieza 1st Form"),
            new CharName(24, "Frieza Final"),
            new CharName(25, "Frieza Full Power"),
            new CharName(26, "Trunks Future"),
            new CharName(27, "Trunks Kid"),
            new CharName(28, "Android 17"),
            new CharName(29, "Super 17"),
            new CharName(30, "Android 18"),
            new CharName(31, "Cell Perfect"),
            new CharName(32, "Cell Full Power"),
            new CharName(33, "Cell Jr."),
            new CharName(34, "Videl"),
            new CharName(35, "Majin Buu"),
            new CharName(36, "Super Buu"),
            new CharName(37, "Kid Buu"),
            new CharName(38, "Gotenks"),
            new CharName(39, "Vegito"),
            new CharName(40, "Broly"),
            new CharName(41, "Beerus"),
            new CharName(42, "Pan"),
            new CharName(48, "Eis Shenron"),
            new CharName(49, "Nuova Shenron"),
            new CharName(50, "Omega Shenron"),
            new CharName(51, "Gogeta SSJ4"),
            new CharName(52, "Hercule"),
            new CharName(53, "Demigra"),
            new CharName(59, "Nabana"),
            new CharName(60, "Raspberry"),
            new CharName(61, "Gohan 4 years old"),
            new CharName(62, "Mira"),
            new CharName(63, "Towa"),
            new CharName(65, "Whis"),
            new CharName(67, "Jaco"),
            new CharName(73, "Villinous Hercule"),
            new CharName(80, "Goku SSGSS"),
            new CharName(81, "Vegeta SSGSS"),
            new CharName(82, "Golden Frieza"),
            new CharName(100, "Human Male"),
            new CharName(101, "Human Female"),
            new CharName(102, "Saiyan Male"),
            new CharName(103, "Saiyan Female"),
            new CharName(104, "Namekian"),
            new CharName(105, "Frieza Race"),
            new CharName(106, "Majin Male"),
            new CharName(107, "Majin Female")
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public string FindCharName(int id)
        {
            for (int n = 0; n < clist.Length; n++)
            {
                if (clist[n].ID == id)
                    return clist[n].Name;
            }

            return "Unknown Character";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "Xenoverse Skill File (*.cus)|*.cus";
            browseFile.Title = "Browse for Skill File";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;

            FileName = browseFile.FileName;

            FolderBrowserDialog browseFolder = new FolderBrowserDialog();
            browseFolder.Description = "Find Msg Folder";
            if (browseFolder.ShowDialog() == DialogResult.Cancel)
                return;

            
            using (BinaryReader CUS = new BinaryReader(File.Open(browseFile.FileName, FileMode.Open)))
            {
                CUS.BaseStream.Seek(8, SeekOrigin.Begin);
                CharCount = CUS.ReadInt32();
                CharAddress = CUS.ReadInt32();

                int SuperCount = CUS.ReadInt32();
                int UltimateCount = CUS.ReadInt32();
                int EvasiveCount = CUS.ReadInt32();

                CUS.BaseStream.Seek(8, SeekOrigin.Current);

                int SupAddress = CUS.ReadInt32();
                int UltAddress = CUS.ReadInt32();
                int EvaAddress = CUS.ReadInt32();


                int cID;
                int ccID;

                Chars = new Char_Data[CharCount];
                for (int i = 0; i < CharCount; i++)
                {
                    CUS.BaseStream.Seek(CharAddress + (i * 32), SeekOrigin.Begin);
                    cID = CUS.ReadInt32();
                    ccID = CUS.ReadInt32();
                    LstChar.Items.Add(FindCharName(cID) + " " + "Costume " + ccID.ToString());

                    Chars[i].SuperIDs = new short[4];
                    Chars[i].UltimateIDs = new short[2];

                    Chars[i].SuperIDs[0] = CUS.ReadInt16();
                    Chars[i].SuperIDs[1] = CUS.ReadInt16();
                    Chars[i].SuperIDs[2] = CUS.ReadInt16();
                    Chars[i].SuperIDs[3] = CUS.ReadInt16();
                    Chars[i].UltimateIDs[0] = CUS.ReadInt16();
                    Chars[i].UltimateIDs[1] = CUS.ReadInt16();
                    Chars[i].EvasiveID = CUS.ReadInt16();
                }

                Supers = new skill[SuperCount];
                mText = msgStream.Load(browseFolder.SelectedPath + "/proper_noun_skill_spa_name_en.msg");
                for (int i = 0; i < SuperCount; i++)
                {
                    CUS.BaseStream.Seek(SupAddress + (i * 48) + 8, SeekOrigin.Begin);
                    Supers[i].ID = CUS.ReadInt16();
                    Supers[i].Name = findName("spe_skill_" + CUS.ReadInt16().ToString("000"));
                }

                Ultimates = new skill[UltimateCount];
                mText = msgStream.Load(browseFolder.SelectedPath + "/proper_noun_skill_ult_name_en.msg");
                for (int i = 0; i < UltimateCount; i++)
                {
                    CUS.BaseStream.Seek(UltAddress + (i * 48) + 8, SeekOrigin.Begin);
                    Ultimates[i].ID = CUS.ReadInt16();
                    Ultimates[i].Name = findName("ult_" + CUS.ReadInt16().ToString("000"));
                }

                Evasives = new skill[EvasiveCount];
                mText = msgStream.Load(browseFolder.SelectedPath + "/proper_noun_skill_esc_name_en.msg");
                for (int i = 0; i < EvasiveCount; i++)
                {
                    CUS.BaseStream.Seek(EvaAddress + (i * 48) + 8, SeekOrigin.Begin);
                    Evasives[i].ID = CUS.ReadInt16();
                    Evasives[i].Name = findName("avoid_skill_" + CUS.ReadInt16().ToString("000"));
                }

            }

            for (int i = 0; i < Supers.Length; i++)
            {
                SupLst1.Items.Add(Supers[i].Name);
                SupLst2.Items.Add(Supers[i].Name);
                SupLst3.Items.Add(Supers[i].Name);
                SupLst4.Items.Add(Supers[i].Name);
            }

            for (int i = 0; i < Ultimates.Length; i++)
            {
                UltLst1.Items.Add(Ultimates[i].Name);
                UltLst2.Items.Add(Ultimates[i].Name);
            }

            for (int i = 0; i < Evasives.Length; i++)
            {
                EvaLst.Items.Add(Evasives[i].Name); 
            }

        }

        private void LstChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lock = true;
            SupLst1.SelectedIndex = FindSuper(Chars[LstChar.SelectedIndex].SuperIDs[0]);
            SupLst2.SelectedIndex = FindSuper(Chars[LstChar.SelectedIndex].SuperIDs[1]);
            SupLst3.SelectedIndex = FindSuper(Chars[LstChar.SelectedIndex].SuperIDs[2]);
            SupLst4.SelectedIndex = FindSuper(Chars[LstChar.SelectedIndex].SuperIDs[3]);

            UltLst1.SelectedIndex = FindUltimate(Chars[LstChar.SelectedIndex].UltimateIDs[0]);
            UltLst2.SelectedIndex = FindUltimate(Chars[LstChar.SelectedIndex].UltimateIDs[1]);

            EvaLst.SelectedIndex = FindEvasive(Chars[LstChar.SelectedIndex].EvasiveID);
            Lock = false;
        }

        private int FindSuper(short id)
        {
            for (int i = 0; i < Supers.Length; i++)
            {
                if (Supers[i].ID == id)
                    return i;
            }
            return -1;
        }

        private int FindUltimate(short id)
        {
            for (int i = 0; i < Ultimates.Length; i++)
            {
                if (Ultimates[i].ID == id)
                    return i;
            }
            return -1;
        }

        private int FindEvasive(short id)
        {
            for (int i = 0; i < Evasives.Length; i++)
            {
                if (Evasives[i].ID == id)
                    return i;
            }
            return -1;
        }

        private string findName(string text_ID)
        {
            for (int i = 0; i < mText.data.Length; i++)
            {
                if (mText.data[i].NameID == text_ID)
                    return mText.data[i].Lines[0];
            }


            return "Unknown Skill";
        }

        private void SupLst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].SuperIDs[0] = Supers[SupLst1.SelectedIndex].ID;
        }

        private void SupLst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].SuperIDs[1] = Supers[SupLst2.SelectedIndex].ID;
        }

        private void SupLst3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].SuperIDs[2] = Supers[SupLst3.SelectedIndex].ID;
        }

        private void SupLst4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].SuperIDs[3] = Supers[SupLst4.SelectedIndex].ID;
        }

        private void UltLst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].UltimateIDs[0] = Ultimates[UltLst1.SelectedIndex].ID;
        }

        private void UltLst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].UltimateIDs[1] = Ultimates[UltLst2.SelectedIndex].ID;
        }

        private void EvaLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Lock)
                Chars[LstChar.SelectedIndex].EvasiveID = Evasives[EvaLst.SelectedIndex].ID;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BinaryWriter CUS = new BinaryWriter(File.Open(FileName, FileMode.Open)))
            {
                CUS.BaseStream.Seek(CharAddress, SeekOrigin.Begin);
                for (int i = 0; i < CharCount; i++)
                {
                    CUS.BaseStream.Seek(CharAddress + (i * 32) + 8, SeekOrigin.Begin);
                    CUS.Write(Chars[i].SuperIDs[0]);
                    CUS.Write(Chars[i].SuperIDs[1]);
                    CUS.Write(Chars[i].SuperIDs[2]);
                    CUS.Write(Chars[i].SuperIDs[3]);
                    CUS.Write(Chars[i].UltimateIDs[0]);
                    CUS.Write(Chars[i].UltimateIDs[1]);
                    CUS.Write(Chars[i].EvasiveID);
                }
            }
        }
    }
}
