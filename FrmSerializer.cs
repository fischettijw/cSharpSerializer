using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace cSharpSerializer
{
    public partial class FrmSerializer : Form
    {
        static List<Sport> sportList = new List<Sport>();

        public FrmSerializer()
        {
            InitializeComponent();
        }

        private void FrmSerializer_Load(object sender, EventArgs e)
        {

            if (!Sport.Contains("Football")) { sportList.Add(new Sport("Football", true, 'M')); }
            if (!Sport.Contains("Soccer")) { sportList.Add(new Sport("Soccer", true, 'B')); }
            if (!Sport.Contains("Tennis")) { sportList.Add(new Sport("Tennis", true, 'B')); }
            if (!Sport.Contains("Baseball")) { sportList.Add(new Sport("Baseball", true, 'M')); }
            if (!Sport.Contains("Swimming")) { sportList.Add(new Sport("Swimming", false, 'B')); }
            if (!Sport.Contains("Softball")) { sportList.Add(new Sport("Softball", true, 'F')); }
            if (!Sport.Contains("Bowling")) { sportList.Add(new Sport("Bowling", false, 'B')); }


   
        }
    }
}
