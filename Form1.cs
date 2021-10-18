namespace FormsAndControls
{
    public partial class Form1 : Form
    {
        TweedeForm childForm = new TweedeForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox tbEvenProberen = new TextBox();
            this.Controls.Add(tbEvenProberen);
            tbEvenProberen.Width = 200;
            tbEvenProberen.Text = "Dit is een textbox";
            Button btProberen = new Button() { Top = 150, BackColor = Color.Blue, Text = "EvenProberen", Height = 40, Width = 150 };
            Controls.Add(btProberen);
            btProberen.Click += BtProberen_Click;

            this.IsMdiContainer = true;

            //childForm.Show();
            childForm.MdiParent = this;
            childForm.ControlBox = false;
            //            childForm.Show();
            //            Controls.Add(childF.orm);// Gaat niet!!!
        }

        private void BtProberen_Click(object? sender, EventArgs e)
        {
            //((Button)sender).BackColor = Color.Red;
            //TweedeForm childForm = new TweedeForm();   
            //childForm.MdiParent = this;
            childForm.Visible = !childForm.Visible;
        }
    }
}