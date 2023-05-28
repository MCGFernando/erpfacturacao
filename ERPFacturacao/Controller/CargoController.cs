﻿using ERPFacturacao.Data;
using ERPFacturacao.Model;
using ERPFacturacao.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Controller
{
    public class CargoController
    {
        private readonly FormCargo frmCargo;
        private readonly CargoService _service;
        private readonly EFContext _context;

        public CargoController(FormCargo frmCargo)
        {
            this.frmCargo = frmCargo;
            _context = new EFContext();
            _service = new CargoService(_context);
            frmCargo.Gravar += Gravar;
            frmCargo.Novo += Novo;
            frmCargo.Editar += Editar;
            frmCargo.Listar += Listar;
        }

        private void Listar(object? sender, EventArgs e)
        {
            var lstCargo = _service.findAll();
            if (lstCargo.Count <= 0)
            {
                MessageBox.Show("Nok");
                return;
            }
            this.frmCargo.tblCargo.DataSource= lstCargo;
        }

        private void Editar(object? sender, EventArgs e)
        {
            if (this.frmCargo.tblCargo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor selecione a coluna que deseja editar", "", MessageBoxButtons.OK);
                return;
            }
            DataGridViewRow selectedRow = this.frmCargo.tblCargo.SelectedRows[0];
            int auxNumber;
            bool tryParse = int.TryParse(selectedRow.Cells[0].Value.ToString(), out auxNumber);

            if (!tryParse)
            {
                MessageBox.Show("Não foi possível converter o ID do cliente", "", MessageBoxButtons.OK);
                return;
            }
            int idCargo = auxNumber;
            var cargo = _service.findById(idCargo);
            this.frmCargo.IDTextBox = cargo.Id.ToString();
            this.frmCargo.SiglaTextBox = cargo.Sigla;
            this.frmCargo.CargoTextBox = cargo._Cargo;
        }

        private void Novo(object? sender, EventArgs e)
        {
            this.frmCargo.SiglaTextBox = "";
            this.frmCargo.CargoTextBox = "";
            this.frmCargo.IDTextBox = "";
        }

        private void Gravar(object? sender, EventArgs e)
        {
            var cargo = new Cargo()
            {
                Sigla = this.frmCargo.SiglaTextBox,
                _Cargo = this.frmCargo.CargoTextBox,
                DataRegisto = DateTime.Now,
            };
            _service.insert(cargo);
            MessageBox.Show("OK");
        }
    }
}
