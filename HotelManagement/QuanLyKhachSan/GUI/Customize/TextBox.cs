using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        public TextBox()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            return textBox1.Text;
        }

        public void AcceptReturn()
        {
            
        }

        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public int BorderSize { get => borderSize; set => borderSize = value; }
        public bool UnderlinedStyle { get => underlinedStyle; set => underlinedStyle = value; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox_Load(object sender, EventArgs e)
        {

        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            // do nothing
        }

        private void textbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               //
            }
        }
    }
}
