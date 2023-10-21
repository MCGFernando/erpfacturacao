using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Controller
{
    public class ContaContabilController
    {
        private readonly FormContaContabil formContaContabil;
        private readonly ContaContabilService _service;
        private readonly EFContext _context;

        public ContaContabilController(FormContaContabil formContaContabil)
        {
            MessageBox.Show("Cheguei");
            this.formContaContabil = formContaContabil;
            _context = new EFContext();
            _service = new ContaContabilService(_context);
            formContaContabil.Gravar += Gravar;
            formContaContabil.Novo += Novo;
            formContaContabil.Editar += Editar;
            formContaContabil.Listar += Listar;
            formContaContabil.ClasseContabilChanged += ClasseContabilChanged;
            formContaContabil.ContaContabilAgregadoraChanged += ContaContabilAgregadoraChanged;
        }

        private void ContaContabilAgregadoraChanged(object? sender, EventArgs e)
        {
            //MessageBox.Show(this.formContaContabil.ContaContabilAgregadoraComboBox.SelectedValue.ToString());
            if (int.TryParse(this.formContaContabil.ContaContabilAgregadoraComboBox.SelectedValue.ToString(), out int classeContabilId))
            {
                var contaContabilAgregadora = _context.ContaContabilAgregadora.FirstOrDefault(c => c.Id == classeContabilId);
                //this.formContaContabil.CodigoTextBox = contaContabilAgregadora.Codigo;
                if (contaContabilAgregadora != null)
                {
                    MessageBox.Show(contaContabilAgregadora.ToString());
                    this.formContaContabil.CodigoCantaPaiTextBox = contaContabilAgregadora.Codigo + ".";
                }
                
            }
        }

        private void ClasseContabilChanged(object? sender, EventArgs e)
        {
            //MessageBox.Show(this.formContaContabil.ClasseContabilComboBox.SelectedValue.ToString());
            if (int.TryParse(this.formContaContabil.ClasseContabilComboBox.SelectedValue.ToString(), out int classeContabilId))
            {
                var contaContabilAgregadora = _context.ContaContabilAgregadora.Where(c => c.ClasseContabilId == classeContabilId).ToList();
                this.formContaContabil.ContaContabilAgregadoraComboBox.DataSource = contaContabilAgregadora;
                this.formContaContabil.ContaContabilAgregadoraComboBox.DisplayMember = "Descricao";
                this.formContaContabil.ContaContabilAgregadoraComboBox.ValueMember = "ID";   
            }
        }

        private void Listar(object? sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei");
            var lstContaContabil = _service.findAll();
            if (lstContaContabil.Count <= 0)
            {
                MessageBox.Show("Nok");
                return;
            }
            this.formContaContabil.tblContaContabil.DataSource = lstContaContabil;
        }

        private void Editar(object? sender, EventArgs e)
        {
            if (this.formContaContabil.tblContaContabil.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor selecione a coluna que deseja editar", "", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow selectedRow = this.formContaContabil.tblContaContabil.SelectedRows[0];

            bool tryParse = int.TryParse(selectedRow.Cells[0].Value.ToString(), out int auxNumber);

            if (!tryParse)
            {
                MessageBox.Show("Não foi possível converter o ID do cliente", "", MessageBoxButtons.OK);
                return;
            }
            int idContaContabil = auxNumber;
            var contaContabil = _service.findById(idContaContabil);
            this.formContaContabil.IDTextBox = contaContabil.Id.ToString();
            this.formContaContabil.SequenciaTextBox= contaContabil.Sequencia.ToString();
            this.formContaContabil.CodigoCantaPaiTextBox = contaContabil.Codigo;
            this.formContaContabil.DescricaoTextBox = contaContabil.Descricao;
        }

        private void Novo(object? sender, EventArgs e)
        {
            this.formContaContabil.CodigoCantaPaiTextBox = "";
            this.formContaContabil.SequenciaTextBox = "";
            this.formContaContabil.DescricaoTextBox = "";
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var contaContabil = SetContaContabilFromForm();

            if (contaContabil == null)
            {
                return;
            }




            if (contaContabil.Id == 0 || contaContabil.Id == null)
            {
                _service.insert(contaContabil);
                Novo(sender, e);
                MessageBox.Show("Inserido com sucesso");
            }
            else
            {
                _service.update(contaContabil);
                Novo(sender, e);
                MessageBox.Show("actualizado com sucesso");
            }
        }

        private ContaContabil SetContaContabilFromForm()
        {
            var ContaContabil = new ContaContabil();
            if (int.TryParse(this.formContaContabil.IDTextBox, out int utilizadorId))
            {
                ContaContabil.Id = utilizadorId;
            }

            ContaContabil.ContaContabilAgregadoraId = int.Parse(this.formContaContabil.ContaContabilAgregadoraComboBox.SelectedValue.ToString());
            ContaContabil.Codigo = this.formContaContabil.CodigoCantaPaiTextBox;
            ContaContabil.Sequencia = long.Parse( this.formContaContabil.SequenciaTextBox);
            ContaContabil.Descricao = this.formContaContabil.DescricaoTextBox;


            var validationContext = new ValidationContext(ContaContabil, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(ContaContabil, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                    ContaContabil = null;
                }
            }
            return ContaContabil;
        }
    }
}
