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
    public class TipoEnderecoController
    {
        private FormTipoEndereco _frmTipoEndereco;
        private readonly TipoEnderecoService _service;
        private readonly EFContext _context;

        public TipoEnderecoController(FormTipoEndereco frmTipoEndereco)
        {
            this._frmTipoEndereco = frmTipoEndereco;
            _context = new EFContext();
            _service = new TipoEnderecoService(_context);
            this._frmTipoEndereco.Gravar += Gravar;
            this._frmTipoEndereco.Novo += Novo;
            this._frmTipoEndereco.Editar += Editar;
            this._frmTipoEndereco.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            this._frmTipoEndereco.TipoEnderecoDataGrid.DataSource = _service.findAll();
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
            var tipoEndereco = new TipoEndereco()
            {
                _TipoEndereco = this._frmTipoEndereco.TipoEnderecoTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(tipoEndereco);
            MessageBox.Show("ok");
        }
    }
}
