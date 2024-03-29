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
            EFContext ef = new EFContext();
            PaisService s = new PaisService(ef);
            comboBox1.DataSource = s.findAll();
            comboBox1.DisplayMember = "_Pais";
            comboBox1.ValueMember = "Id";
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

        private void button2_Click(object sender, EventArgs e)
        {
            EFContext ef = new EFContext();
            SectorService service = new SectorService(ef);
            advancedDataGridView1.DataSource = service.findAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pais = (Pais)comboBox1.SelectedItem;
            MessageBox.Show(pais.Id.ToString());
        }
    }
}