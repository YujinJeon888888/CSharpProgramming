namespace _23강_이미지리스트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics, 0, 0, 0);
            imageList1.Draw(e.Graphics, 70, 0, 1);
        }
    }
}