using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Controller
{
    public class ProvinciaController
    {
        private readonly FormProvincia _frmProvincia;
        private readonly ProvinciaService _service;
        private readonly EFContext _context;

        public ProvinciaController(FormProvincia frmProvincia)
        {
            this._frmProvincia = frmProvincia;
            _context = new EFContext();
            _service = new ProvinciaService(_context);
            _frmProvincia.Gravar += Gravar;
            _frmProvincia.Novo += Novo;
            _frmProvincia.Editar += Editar;
            _frmProvincia.Listar += Listar;
            this._frmProvincia.PaisComboBox.DataSource= _context.Pais.ToList();
            this._frmProvincia.PaisComboBox.DisplayMember = "_Pais";
            this._frmProvincia.PaisComboBox.ValueMember = "Id";
        }

        private void Listar(object? sender, EventArgs e)
        {
            this._frmProvincia.ProvinciaAdvancedDataGridView.DataSource = _service.findAll();
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
            var pais = (Pais)this._frmProvincia.PaisComboBox.SelectedItem;
            var provincia = new Provincia()
            {
                PaisId = pais.Id,
                Pais = pais,
                _Provincia = this._frmProvincia.ProvinciaTextBox,
                CodigoProvincia = this._frmProvincia.CodigoProvinciaTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(provincia);
            MessageBox.Show("OK");
        }
    }
}
