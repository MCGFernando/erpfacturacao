using ERPFacturacao.Data;
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
            _frmMunicipio.Gravar += Gravar;
            _frmMunicipio.Novo += Novo;
            _frmMunicipio.Editar += Editar;
            _frmMunicipio.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
