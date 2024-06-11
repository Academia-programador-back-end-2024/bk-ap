namespace AulaWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Aula de C#";

            //this.Size = new System.Drawing.Size(400, 400);
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            //Ele vai disparar esse metodo quando eu clickar no botão

            MessageBox.Show(txtMessageBox.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gpWelcome.Visible = true;
            }
            else
            {
                gpWelcome.Visible = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog(this);
        }
    }
}
