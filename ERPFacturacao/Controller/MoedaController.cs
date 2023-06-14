using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using System.Collections.Generic;

namespace ERPFacturacao.Controller
{
    internal class MoedaController
    {
        private readonly FormMoeda frmMoeda;
        private readonly MoedaService _service;
        private readonly EFContext _context;


        public MoedaController(FormMoeda frmMoeda)
        {
            this.frmMoeda = frmMoeda;
            _context = new EFContext();
            _service = new MoedaService(_context);
            this.frmMoeda.Gravar += Gravar;
            this.frmMoeda.Novo += Novo;
            this.frmMoeda.Editar += Editar;
            this.frmMoeda.Listar += Listar;

            this.frmMoeda.PaisComboBox.DataSource = _context.Pais.ToList();
            this.frmMoeda.PaisComboBox.DisplayMember = "_Pais";
            this.frmMoeda.PaisComboBox.ValueMember = "Id";
        }

        private void Listar(object? sender, EventArgs e)
        {
            this.frmMoeda.MoedaDataGrid.DataSource = _service.findAll();
        }

        private void Editar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Novo(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var pais = (Pais)this.frmMoeda.PaisComboBox.SelectedItem;
            var moeda = new Moeda()
            {
                Nome = this.frmMoeda.MoedaTextBox,
                Simbolo = this.frmMoeda.SimboloTextBox,
                PaisId = pais.Id,
                Pais = pais,
                DataRegisto = DateTime.Now,
            };
            _service.insert(moeda);
            MessageBox.Show("OK");
        }
    }
}