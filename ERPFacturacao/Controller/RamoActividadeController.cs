using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using System.Collections.Generic;

namespace ERPFacturacao.Controller
{
    internal class RamoActividadeController
    {
        private FormRamoActividade frmRamoActividade;
        private readonly EFContext _context;
        private readonly RamoActividadeService _service;

        public RamoActividadeController(FormRamoActividade frmRamoActividade)
        {
            this.frmRamoActividade = frmRamoActividade;
            _context = new EFContext();
            _service = new RamoActividadeService(_context);
            this.frmRamoActividade.Gravar += Gravar;
            this.frmRamoActividade.Novo += Novo;
            this.frmRamoActividade.Editar += Editar;
            this.frmRamoActividade.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
           this.frmRamoActividade.RamoActividadeDataGrid.DataSource = _service.findAll();
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
            var ramo = new RamoActividade()
            {
                Ramo = this.frmRamoActividade.RamoTextBox,
                Descricao = this.frmRamoActividade.DescricaoTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(ramo);
            MessageBox.Show("Ok");
        }
    }
}