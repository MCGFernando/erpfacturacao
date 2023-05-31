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
    public class PaisController
    {
        private readonly FormPais _frmPais;
        private readonly PaisService _service;
        private readonly EFContext _context;

        public PaisController(FormPais frmPais)
        {
            this._frmPais = frmPais;
            _context = new EFContext();
            _service = new PaisService(_context);
            _frmPais.Gravar += Gravar;
            _frmPais.Novo += Novo;
            _frmPais.Editar += Editar;
            _frmPais.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            this._frmPais.PaisAdvancedDataGridView.DataSource = _service.findAll();
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
            var pais = new Pais()
            {
                _Pais = this._frmPais.PaisTextBox,
                CodigoPais = this._frmPais.CodigoPaisTextBox,
                Moeda = this._frmPais.MoedaTextBox,
                CodigoMoeda = this._frmPais.CodigoMoedaTextBox,
                CodigoTelefonia = this._frmPais.CodigoTelefoniaTextBox,
                DominioTopo = this._frmPais.DominioTopoTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(pais);
            MessageBox.Show("OK");
        }
    }
}
