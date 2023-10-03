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
        void Listar(object? sender, EventArgs e);
        void Editar(object? sender, EventArgs e);
        void Novo(object? sender, EventArgs e);
        void Gravar(object? sender, EventArgs e);
        T SetCargoFromForm();
    }
}
