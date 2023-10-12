using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Model
{
    [Serializable]
    [Table("productos_servicos")]
    public class Artigo
    {
        public int Id { get; set; }
        public string CodigoArtigo { get; set; }//*
        public string Descricao { get; set; }//*
        public string CodigoBarras { get; set; }//*



        public bool MovimentaStock { get; set; }//*
        public bool Devolucao { get; set; }//*
        public bool Activo { get; set; }//*
        public int Garantia { get; set; }//*
        public double Desconto { get; set; }//*
        public double PrecoCompra { get; set; }//*
        public double CustoCompra { get; set; }//*
        public double PrecoVenda { get; set; }//*
        public double Peso { get; set; }
        public string Largura { get; set; }
        public string Altura { get; set; }
        public string Comprimento { get; set; }
        public string Observacao { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }//*
        public TipoIVA TipoIVA { get; set; }//*
        public TipoArtigo TipoArtigo { get; set; }//*
        public Modelo Modelo { get; set; }
        /*public Unidade Unidade { get; set; }
        public Unidade UnidadeCompra { get; set; }
        public Unidade UnidadeVenda { get; set; }
        public Unidade UnidadeEntrada { get; set; }
        public Unidade UnidadeSaida { get; set; }*/

        [Column("data_registo")]
        public DateTime DataRegisto { get; set; }
        [Column("data_actualizacao")]
        public DateTime? DataActualizacao { get; set; }
        [Column("data_anulacao")]
        public DateTime? DataAnulacao { get; set; }

    }
}
