using ERPFacturacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Controller.impl
{
    internal interface IController<T>
    {
        protected void Listar(object? sender, EventArgs e);
        protected void Editar(object? sender, EventArgs e);
        protected void Novo(object? sender, EventArgs e);
        protected void Gravar(object? sender, EventArgs e);
        protected T SetCargoFromForm();
    }
}
