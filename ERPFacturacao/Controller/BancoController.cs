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
    public class BancoController
    {
        private readonly FormBanco _frmBanco;
        private readonly BancoService _service;
        private readonly EFContext _context;

        public BancoController(FormBanco frmBanco)
        {
            this._frmBanco = frmBanco;
            _context = new EFContext();
            _service = new BancoService(_context);
            this._frmBanco.Gravar += Gravar;
            this._frmBanco.Novo += Novo;
            this._frmBanco.Editar += Editar;
            this._frmBanco.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            this._frmBanco.BancoDataGrid.DataSource = _service.findAll();   
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
            var banco = new Banco()
            {
                Sigla =this._frmBanco.SiglaTextBox,
                _Banco =this._frmBanco.BancoTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(banco);
            MessageBox.Show("Ok");
        }
    }
}
