using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class GroupBox : System.Windows.Forms.GroupBox
    {
        public GroupBox()
        {
            this.ForeColor = Color.Black;          
            this.Size = new Size(365, 210); 
        }
    }
}