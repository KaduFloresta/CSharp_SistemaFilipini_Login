using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class TextBox : System.Windows.Forms.RichTextBox
    {
        public TextBox()
        {    
            this.Size = new Size(200, 20);
            this.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
            this.SelectionColor = System.Drawing.Color.Black;
        }

        public char PasswordChar { get; set; }
    }
}