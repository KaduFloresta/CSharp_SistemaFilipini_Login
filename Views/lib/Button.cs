using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class Button : System.Windows.Forms.Button
    {

        public Button()
        {
            this.Size = new Size(120, 40);
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }
    }
}