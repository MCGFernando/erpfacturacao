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
    public class TipoContactoController
    {
        private FormTipoContacto _frmTipoContacto;
        private readonly TipoContactoService _service;
        private readonly EFContext _context;
        public TipoContactoController(FormTipoContacto frmTipoContacto)
        {
            this._frmTipoContacto = frmTipoContacto;
            _context = new EFContext();
            _service = new TipoContactoService(_context);
            this._frmTipoContacto.Gravar += Gravar;
            this._frmTipoContacto.Novo += Novo;
            this._frmTipoContacto.Editar += Editar;
            this._frmTipoContacto.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            this._frmTipoContacto.TipoContactoDataGrid.DataSource = _service.findAll();
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
            var tipoContacto = new TipoContacto()
            {
                _TipoContacto = this._frmTipoContacto.TipoContactoTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(tipoContacto);
            MessageBox.Show("OK");
        }
    }
}
