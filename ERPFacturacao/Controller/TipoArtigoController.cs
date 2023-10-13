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
    public class TipoArtigoController
    {
        private readonly FormTipoArtigo formTipoArtigo;
        private readonly TipoArtigoService _service;
        private readonly EFContext _context;

        public TipoArtigoController(FormTipoArtigo formTipoArtigo)
        {
            this.formTipoArtigo = formTipoArtigo;
            _context = new EFContext();
            _service = new TipoArtigoService(_context);
            formTipoArtigo.Gravar += Gravar;
            formTipoArtigo.Novo += Novo;
            formTipoArtigo.Editar += Editar;
            formTipoArtigo.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            var lstTipoArtigo = _service.findAll();
            if (lstTipoArtigo.Count <= 0)
            {
                MessageBox.Show("Nok");
                return;
            }
            this.formTipoArtigo.tblTipoArtigo.DataSource = lstTipoArtigo;
        }

        private void Editar(object? sender, EventArgs e)
        {
            if (this.formTipoArtigo.tblTipoArtigo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor selecione a coluna que deseja editar", "", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow selectedRow = this.formTipoArtigo.tblTipoArtigo.SelectedRows[0];

            bool tryParse = int.TryParse(selectedRow.Cells[0].Value.ToString(), out int auxNumber);

            if (!tryParse)
            {
                MessageBox.Show("Não foi possível converter o ID do cliente", "", MessageBoxButtons.OK);
                return;
            }
            int idTipoArtigo = auxNumber;
            var tipoArtigo = _service.findById(idTipoArtigo);
            this.formTipoArtigo.IdTextBox = tipoArtigo.Id.ToString();
            this.formTipoArtigo.TipoArtigoTextBox = tipoArtigo._TipoArtigo;
            this.formTipoArtigo.DescricaoTextBox = tipoArtigo.Descricao;
            //this.formTipoArtigo.TipoFiscalArtigoComboBox.DataSource = tipoArtigo.TipoFiscalProductoServico;
            this.formTipoArtigo.TipoFiscalArtigoComboBox.SelectedValue = tipoArtigo.TipoFiscalProductoServico.ToString();
        }

        private void Novo(object? sender, EventArgs e)
        {
            this.formTipoArtigo.IdTextBox = "";
            this.formTipoArtigo.TipoArtigoTextBox = "";
            this.formTipoArtigo.DescricaoTextBox = "";
            this.formTipoArtigo.TipoFiscalArtigoComboBox.SelectedIndex = 0;
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var tipoArtigo = SetTipoArtigoFromForm();

            if (tipoArtigo == null)
            {
                return;
            }




            if (tipoArtigo.Id == 0 || tipoArtigo.Id == null)
            {
                _service.insert(tipoArtigo);
                Novo(sender, e);
                MessageBox.Show("Inserido com sucesso");
            }
            else
            {
                _service.update(tipoArtigo);
                Novo(sender, e);
                MessageBox.Show("actualizado com sucesso");
            }
        }

        private TipoArtigo SetTipoArtigoFromForm()
        {
            var tipoArtigo = new TipoArtigo();
            if (int.TryParse(this.formTipoArtigo.IdTextBox, out int tipoArtigoId))
            {
                tipoArtigo.Id = tipoArtigoId;
            }

            tipoArtigo._TipoArtigo = this.formTipoArtigo.TipoArtigoTextBox;
            tipoArtigo.Descricao = this.formTipoArtigo.DescricaoTextBox;
            tipoArtigo.TipoFiscalProductoServico = (Model.Enum.TipoFiscalArtigo)this.formTipoArtigo.TipoFiscalArtigoComboBox.SelectedItem;


            var validationContext = new ValidationContext(tipoArtigo, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(tipoArtigo, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                    tipoArtigo = null;
                }
            }
            return tipoArtigo;
        }
    }
}
