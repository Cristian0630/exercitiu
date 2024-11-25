namespace exercitiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai apasatz");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 10) button1.Left += e.X;
            if (e.X < button1.Width - 10) button1.Left -= button1.Width - e.X;
            if (e.Y < 10) button1.Top += e.Y;
            if(e.Y<button1.Height)
        }
    }
}
