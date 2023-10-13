using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using ERPFacturacao.Service.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Controller
{
    public class TipoIVAController
    {
        private readonly FormTipoIVA frmTipoIVA;
        private readonly TipoIVAService _service;
        private readonly EFContext _context;

        public TipoIVAController(FormTipoIVA frmTipoIVA)
        {
            this.frmTipoIVA = frmTipoIVA;
            _context = new EFContext();
            _service = new TipoIVAService(_context);
            frmTipoIVA.Gravar += Gravar;
            frmTipoIVA.Novo += Novo;
            frmTipoIVA.Editar += Editar;
            frmTipoIVA.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            var lstTipoIVA = _service.findAll();
            if (lstTipoIVA.Count <= 0)
            {
                MessageBox.Show("Nok");
                return;
            }
            this.frmTipoIVA.tblTipoIVA.DataSource = lstTipoIVA;
        }

        private void Editar(object? sender, EventArgs e)
        {
            if (this.frmTipoIVA.tblTipoIVA.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor selecione a coluna que deseja editar", "", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow selectedRow = this.frmTipoIVA.tblTipoIVA.SelectedRows[0];

            bool tryParse = int.TryParse(selectedRow.Cells[0].Value.ToString(), out int auxNumber);

            if (!tryParse)
            {
                MessageBox.Show("Não foi possível converter o ID do cliente", "", MessageBoxButtons.OK);
                return;
            }
            int idTipoIVA = auxNumber;
            var tipoIVA = _service.findById(idTipoIVA);
            this.frmTipoIVA.IdTextBox = tipoIVA.Id.ToString();
            this.frmTipoIVA.TipoIVATextBox = tipoIVA._TipoIVA.ToString();
            this.frmTipoIVA.DescricaoTextBox = tipoIVA.Descricao.ToString();
            this.frmTipoIVA.TaxaTextBox = tipoIVA.Taxa.ToString();
        }

        private void Novo(object? sender, EventArgs e)
        {
            this.frmTipoIVA.IdTextBox = "";
            this.frmTipoIVA.TipoIVATextBox = "";
            this.frmTipoIVA.DescricaoTextBox = "";
            this.frmTipoIVA.TaxaTextBox = "";
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var tipoIVA = SetTipoIVAFromForm();

            if (tipoIVA == null)
            {
                return;
            }




            if (tipoIVA.Id == 0 || tipoIVA.Id == null)
            {
                _service.insert(tipoIVA);
                Novo(sender, e);
                MessageBox.Show("Inserido com sucesso");
            }
            else
            {
                _service.update(tipoIVA);
                Novo(sender, e);
                MessageBox.Show("actualizado com sucesso");
            }
        }

        private TipoIVA SetTipoIVAFromForm()
        {
            var tipoIVA = new TipoIVA();
            if (int.TryParse(this.frmTipoIVA.IdTextBox, out int tipoIVAId))
            {
                tipoIVA.Id = tipoIVAId;
            }

            tipoIVA._TipoIVA = this.frmTipoIVA.TipoIVATextBox;
            tipoIVA.Descricao = this.frmTipoIVA.DescricaoTextBox;
            tipoIVA.Taxa = this.frmTipoIVA.TaxaTextBox != null ? double.Parse(this.frmTipoIVA.TaxaTextBox) : 0.0;


            var validationContext = new ValidationContext(tipoIVA, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(tipoIVA, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                    tipoIVA = null;
                }
            }
            return tipoIVA;
        }
    }
}
