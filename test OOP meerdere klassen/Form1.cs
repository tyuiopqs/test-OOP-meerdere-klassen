namespace test_OOP_meerdere_klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstFactuur.Items.Add($"FactNr: {txtFactuurID.Text} - {txtNaamKlant.Text}");
        }

        private void btnFactuurlijn_Click(object sender, EventArgs e)
        {
            //lstFactuurlijn.Items.Add($"{txtAantal.Text}x {txtProduct.Text} (Prijs = {Convert.ToDouble(txtPrijs.Text)} euro/eenheid)");




        }

        private void lstFactuur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFactuurtotaal.Text = $"Factuurtotaal: ";
        }
    }
}
