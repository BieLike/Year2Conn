using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year2Conn
{
    public partial class Cv2 : Form
    {

        Bitmap picO, picC;
        public Cv2()
        {
            InitializeComponent();
            picO = (Bitmap)picb.Image;
            //picO = new Bitmap(picb.Image);

        }


        private void Cv2_Load(object sender, EventArgs e)
        {

        }
    }
}
