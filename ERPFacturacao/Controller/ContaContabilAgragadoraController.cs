using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPFacturacao.Controller
{
    internal class ContaContabilAgragadoraController
    {
        private FormContaContabilAgragadora formContaContabilAgragadora;
        private readonly ContaContabilAgregadoraService _service;
        private readonly EFContext _context;
        public ContaContabilAgragadoraController(FormContaContabilAgragadora formContaContabilAgragadora)
        {
            this.formContaContabilAgragadora = formContaContabilAgragadora;
            _context = new EFContext();
            _service = new ContaContabilAgregadoraService(_context);
            formContaContabilAgragadora.Gravar += Gravar;
            formContaContabilAgragadora.Novo += Novo;
            formContaContabilAgragadora.Editar += Editar;
            formContaContabilAgragadora.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            var lstContaContabilAgragadora = _service.findAll();
            if (lstContaContabilAgragadora.Count <= 0)
            {
                MessageBox.Show("Nok");
                return;
            }
            this.formContaContabilAgragadora.tblContaContabilAgregadora.DataSource = lstContaContabilAgragadora;
        }

        private void Editar(object? sender, EventArgs e)
        {
            if (this.formContaContabilAgragadora.tblContaContabilAgregadora.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor selecione a coluna que deseja editar", "", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow selectedRow = this.formContaContabilAgragadora.tblContaContabilAgregadora.SelectedRows[0];

            bool tryParse = int.TryParse(selectedRow.Cells[0].Value.ToString(), out int auxNumber);

            if (!tryParse)
            {
                MessageBox.Show("Não foi possível converter o ID do cliente", "", MessageBoxButtons.OK);
                return;
            }
            int idContaCotabilAgregadora = auxNumber;
            var contaCotabilAgregadora = _service.findById(idContaCotabilAgregadora);
            this.formContaContabilAgragadora.IDTextBox = contaCotabilAgregadora.Id.ToString();
            this.formContaContabilAgragadora.CodigoTextBox = contaCotabilAgregadora.Codigo;
            this.formContaContabilAgragadora.DescricaoTextBox = contaCotabilAgregadora.Descricao;
            this.formContaContabilAgragadora.ClasseContabilComboBox.SelectedValue = contaCotabilAgregadora.ClasseContabil.ToString();
        }

        private void Novo(object? sender, EventArgs e)
        {
            this.formContaContabilAgragadora.IDTextBox = "";
            this.formContaContabilAgragadora.CodigoTextBox = "";
            this.formContaContabilAgragadora.DescricaoTextBox = "";
            this.formContaContabilAgragadora.ClasseContabilComboBox.SelectedIndex = 0;
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var contaContabilAgregadora = SetContaContabilAgregadoraFromForm();

            if (contaContabilAgregadora == null)
            {
                return;
            }

            if (contaContabilAgregadora.Id == 0 || contaContabilAgregadora.Id == null)
            {
                _service.insert(contaContabilAgregadora);
                Novo(sender, e);
                MessageBox.Show("Inserido com sucesso");
            }
            else
            {
                _service.update(contaContabilAgregadora);
                Novo(sender, e);
                MessageBox.Show("actualizado com sucesso");
            }
        }

        private ContaContabilAgregadora SetContaContabilAgregadoraFromForm()
        {
            var contaContabilAgregadora = new ContaContabilAgregadora();
            if (int.TryParse(this.formContaContabilAgragadora.IDTextBox, out int contaContabilAgregadoraId))
            {
                contaContabilAgregadora.Id = contaContabilAgregadoraId;
            }

            contaContabilAgregadora.Codigo = this.formContaContabilAgragadora.CodigoTextBox;
            contaContabilAgregadora.Descricao = this.formContaContabilAgragadora.DescricaoTextBox;
            contaContabilAgregadora.ClasseContabilId = int.Parse(this.formContaContabilAgragadora.ClasseContabilComboBox.SelectedValue.ToString());


            var validationContext = new ValidationContext(contaContabilAgregadora, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(contaContabilAgregadora, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                    contaContabilAgregadora = null;
                }
            }
            return contaContabilAgregadora;
        }
    }
}