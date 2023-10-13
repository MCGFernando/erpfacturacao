using ERPFacturacao.Controller.impl;
using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Controller
{
    public class TipoDocumentoController
    {
        private readonly FormTipoDocumento frmTipoDocumento;
        private readonly TipoDocumentoService _service;
        private readonly EFContext _context;

        public TipoDocumentoController(FormTipoDocumento frmTipoDocumento)
        {
            this.frmTipoDocumento = frmTipoDocumento;
            _context = new EFContext();
            _service = new TipoDocumentoService(_context);
            frmTipoDocumento.Gravar += Gravar;
            frmTipoDocumento.Novo += Novo;
            frmTipoDocumento.Editar += Editar;
            frmTipoDocumento.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            var lstTipoDocumento = _service.findAll();
            if (lstTipoDocumento.Count <= 0)
            {
                MessageBox.Show("Nok");
                return;
            }
            this.frmTipoDocumento.tblTipoDocumento.DataSource= lstTipoDocumento;
        }

        private void Editar(object? sender, EventArgs e)
        {
            if (this.frmTipoDocumento.tblTipoDocumento.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor selecione a coluna que deseja editar", "", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow selectedRow = this.frmTipoDocumento.tblTipoDocumento.SelectedRows[0];
            
            bool tryParse = int.TryParse(selectedRow.Cells[0].Value.ToString(), out int auxNumber);

            if (!tryParse)
            {
                MessageBox.Show("Não foi possível converter o ID do cliente", "", MessageBoxButtons.OK);
                return;
            }
            int idTipoDocumento = auxNumber;
            var tipoDocumento = _service.findById(idTipoDocumento);
            this.frmTipoDocumento.IDTextBox = tipoDocumento.Id.ToString();
            this.frmTipoDocumento.CodigoTipoDocumentoTextBox = tipoDocumento.Codigo;
            this.frmTipoDocumento.DescricaoTextBox = tipoDocumento.Descricao;
        }

        private void Novo(object? sender, EventArgs e)
        {
            this.frmTipoDocumento.CodigoTipoDocumentoTextBox = "";
            this.frmTipoDocumento.DescricaoTextBox = "";
            this.frmTipoDocumento.IDTextBox = "";
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var tipoDocumento = SetTipodocumentoFromForm();

            if (tipoDocumento == null)
            {
                return;
            }
            



            if (tipoDocumento.Id == 0 || tipoDocumento.Id == null)
            {
                _service.insert(tipoDocumento);
                Novo(sender, e);
                MessageBox.Show("Inserido com sucesso");
            }
            else 
            {
                _service.update(tipoDocumento);
                Novo(sender, e);
                MessageBox.Show("actualizado com sucesso");
            }
            
            
        }

        private TipoDocumento SetTipodocumentoFromForm()
        {
            var tipoDocumento = new TipoDocumento();
            if (int.TryParse(this.frmTipoDocumento.IDTextBox, out int tipoDocumentoId))
            {
                tipoDocumento.Id = tipoDocumentoId;
            }

            tipoDocumento.Codigo = this.frmTipoDocumento.CodigoTipoDocumentoTextBox;
            tipoDocumento.Descricao = this.frmTipoDocumento.DescricaoTextBox;


            var validationContext = new ValidationContext(tipoDocumento, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(tipoDocumento, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                    tipoDocumento = null;             
                }
            }
            return tipoDocumento;
        }
    }
}
