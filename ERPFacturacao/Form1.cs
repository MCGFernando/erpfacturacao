using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;

namespace ERPFacturacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                var sector = new Sector()
                {
                    Sigla = textBox1.Text,
                    _Sector = textBox2.Text,
                    UtilizadorId = 2,
                    DataRegisto = DateTime.Now
                };
                EFContext ef = new EFContext();
                SectorService service = new SectorService(ef);
                service.insert(sector);
                MessageBox.Show("OK");

                dataGridView1.DataSource= service.findAll();
            /*}
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
        }
    }
}