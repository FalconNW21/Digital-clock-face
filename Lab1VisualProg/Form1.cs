namespace Lab1VisualProg
{
    public partial class Form1 : Form
    {
        int cx = 250, cy = 250, hand = 180;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 5;            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();

            int h = trackBar1.Value;

            int[] handCoord = new int[2];

            Graphics g = pictureBox1.CreateGraphics();

            handCoord = hnCoord(h % 100, -hand - 1);
            g.DrawLine(new Pen(Color.White, 150f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            handCoord = hnCoord( h%100 , -hand);
            g.DrawLine(new Pen(Color.Gray, 4f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private int[] hnCoord(double val, int hlen)
        {
            int[] coord = new int[2];
            val = val*3.6;
            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        
    }
}