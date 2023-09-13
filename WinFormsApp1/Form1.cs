namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random r;
        int count;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            count = 0;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, 713);
            p.Y = r.Next(12, 415);
            button1.Location = p;
            count++;
            this.label1.Text = "PKT" + count.ToString();
            timer1.Stop();
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height- 50;
            Point p = new Point();
            p.X = r.Next(12, 713);
            p.Y = r.Next(12, 415);
            button1.Location = p;
            count = 0; 
            this.label1.Text = "PKT" + count.ToString();
            
        
           
        }

       


    }
}