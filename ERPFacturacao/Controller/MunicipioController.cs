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
    public class MunicipioController
    {
        private readonly FormMunicipio _frmMunicipio;
        private readonly MunicipioService _service;
        private readonly EFContext _context;

        public MunicipioController(FormMunicipio frmMunicipio)
        {
            this._frmMunicipio = frmMunicipio;
            _context = new EFContext();
            _service = new MunicipioService(_context);
            this._frmMunicipio.PaisComboBox.DataSource = _context.Pais.ToList();
            this._frmMunicipio.PaisComboBox.DisplayMember = "_Pais";
            this._frmMunicipio.PaisComboBox.ValueMember = "Id";
            this._frmMunicipio.ProvinciaComboBox.DataSource = _context.Provincia.ToList();
            this._frmMunicipio.ProvinciaComboBox.DisplayMember = "_Provincia";
            this._frmMunicipio.ProvinciaComboBox.ValueMember = "Id";
            _frmMunicipio.Gravar += Gravar;
            _frmMunicipio.Novo += Novo;
            _frmMunicipio.Editar += Editar;
            _frmMunicipio.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            this._frmMunicipio.MunicipioAdvancedDataGridView.DataSource = 
                _service.findAll();
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
            var pais = (Pais)this._frmMunicipio.PaisComboBox.SelectedItem;
            var provincia = (Provincia)this._frmMunicipio.ProvinciaComboBox.SelectedItem;
            var municipio = new Municipio()
            {
                ProvinciaId = provincia.Id,
                Provincia = provincia,
                CodigoMunicipio = this._frmMunicipio.CodigoMunicipioTextBox,
                _Municipio = this._frmMunicipio.MunicipioTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(municipio);
            MessageBox.Show("Ok");
        }
    }
}
