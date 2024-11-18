namespace SkyrimTrader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add 10 textboxes to PanelMain going down
            Label lbl = new Label();
            lbl.Text = "Text de mon cul" + PanelMain.Controls.Count.ToString();
            lbl.Location = new Point(10, 10 + (PanelMain.Controls.Count * 30));

            PanelMain.Controls.Add(lbl);
        }
    }
}
