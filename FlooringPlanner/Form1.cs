namespace FlooringPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 1;
            trackBar1.Value = 76;//93;

            trackBar2.Minimum = 0;
            trackBar2.Maximum = 100;
            trackBar2.TickFrequency = 1;
            trackBar2.Value = 72;//21;
            reverseCheckBox2.Checked = true;

            trackBar3.Minimum = 0;
            trackBar3.Maximum = 100;
            trackBar3.TickFrequency = 1;
            trackBar3.Value = 52;//65;

            trackBar_ValueChanged(null, null);
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            var lengthFraction1 = ((float)trackBar1.Value) / 100.0f;
            var lengthFraction2 = ((float)trackBar2.Value) / 100.0f;
            var lengthFraction3 = ((float)trackBar3.Value) / 100.0f;

            this.boardLayoutControl1.SetStartingLengths(lengthFraction1, lengthFraction2, lengthFraction3);

            label1.Text = string.Format("{0:0.00}", lengthFraction1);
            label2.Text = string.Format("{0:0.00}", lengthFraction2);
            label3.Text = string.Format("{0:0.00}", lengthFraction3);
        }

        private void reverseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.boardLayoutControl1.SetReverse(reverseCheckBox1.Checked, reverseCheckBox2.Checked, reverseCheckBox3.Checked);
        }
    }
}