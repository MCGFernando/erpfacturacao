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
                    this.formContaContabil.CodigoTextBox = contaContabilAgregadora.Codigo + ".";
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
