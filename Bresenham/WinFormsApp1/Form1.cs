using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Draw draw;

        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            draw = new Draw(pictureBox1.Width, pictureBox1.Height);

            btnRectangle.Enabled = false;
            btnLine.Enabled = false;
            btnCircle.Enabled = false;
            pictureBox1.Image = draw.Board;

        }
        void Valedate(object sender, KeyPressEventArgs e)
        {
            if(((TextBox)sender)==tbRadius && e.KeyChar == '-')
            {
                e.Handled = true;
                return; 
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;



            if (e.KeyChar == '-' &&( ((TextBox)sender).Text.Contains('-') || ((TextBox)sender).SelectionStart!=0))
                e.Handled = true;
        }
        bool AreAllTextBoxesFilled(Control Parent)
        {
            foreach (Control ctrl in Parent.Controls)
            {
                if (ctrl is TextBox box)
                {
                    if (box.Text.Length == 0)
                        return false;
                }
            }
            return true;
        }
        void EnableButton(object sender, EventArgs e)
        {
            bool enable = AreAllTextBoxesFilled(gbLines);
           
            btnLine.Enabled = enable;
            btnRectangle.Enabled = enable;
        }
        void EnableButtonCircle(object sender, EventArgs e)
        {
           
           btnCircle.Enabled = AreAllTextBoxesFilled(gbCircle);
        }


        private void btnRectangle_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(tbX1.Text);
            int y1 = int.Parse(tbY1.Text);
            int x2 = int.Parse(tbX2.Text);
            int y2 = int.Parse(tbY2.Text);
            draw.DrawRectangle(x1, y1, x2, y2);
            pictureBox1.Refresh();

        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(tbRadius.Text);
            int H = Convert.ToInt32(tbH.Text);
            int K = Convert.ToInt32(tbK.Text);

            draw.DrawCircle(r, H, K);
            pictureBox1.Refresh();
        }
        private void btn_Line(object sender, EventArgs e)
        {

            int x1 = int.Parse(tbX1.Text);
            int y1 = int.Parse(tbY1.Text);
            int x2 = int.Parse(tbX2.Text);
            int y2 = int.Parse(tbY2.Text);
            draw.DrawLine(x1, y1, x2, y2);
            pictureBox1.Refresh();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            draw.ClearBoard();
            pictureBox1.Image = draw.Board;
            
        }
        
    }
}   
    