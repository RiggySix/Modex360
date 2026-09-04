using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Modex360.PackageEditors.Batman_Arkham_City
{
    public partial class BatmanArkhamCity : EditorControl
    {
        //public static readonly string FID = "57520802";
        public BatmanArkhamCity()
        {
            InitializeComponent();
            TitleID = FormID.BatmanArkhamCity;
        }

        private ArkhamSave ark;
        public override bool Entry()
        {
            if (!OpenStfsFile(0))
                return false;

            ark = new ArkhamSave(IO);

            return true;
        }

        public override void Save()
        {
            ark.Save();
        }
    }
}
