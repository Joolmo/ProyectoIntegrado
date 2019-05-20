using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public partial class Tags : UserControl
    {

        private List<string> tag;
        private List<Control> controls= new List<Control>();

        public List<string> Tag { get { return tag; } }

        public Tags()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Tags(List<string> t)
        {


        }

        public void AnyadirTag(string nomTag)
        {
            if(tlpMain.ColumnCount < 5)
            {
                ColumnStyle nuevacolumna = new ColumnStyle(SizeType.AutoSize);
                tlpMain.ColumnStyles.Add(nuevacolumna);


                Label con = new Label() { Text = nomTag };
                tlpMain.Controls.Add(con, tlpMain.ColumnCount - 1, 0);
                controls.Add(con);
                tlpMain.ColumnCount += 1;
            }
            
        }

        public void EliminarTag()
        {

            if(tlpMain.ColumnCount != 0)
            {
                tlpMain.Controls.Remove(controls.ElementAt(tlpMain.ColumnCount - 2));
                controls.RemoveAt(tlpMain.ColumnCount - 2);
                tlpMain.ColumnStyles.RemoveAt(tlpMain.ColumnCount - 1);

                tlpMain.ColumnCount -= 1;
            }
            
        }
    }

}
