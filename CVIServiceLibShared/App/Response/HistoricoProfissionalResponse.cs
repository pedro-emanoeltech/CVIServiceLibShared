using CVIServiceLibShared.App.Response;
using CVIServiceLibShared.Constants.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CVIServiceLibShared.Constants.Enums.Classificacoes;

namespace CVIServiceLibShared.App.Response
{
    public class HistoricoProfissionalResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }

        public string? NomeEmpresa { get; set; }
        public PorteEmpresa? Porte { get; set; }

        public Guid? ContatoId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? SegmentoId { get; set; }

        public Cargo? Cargo { get; set; }
        public Segmento? Segmento { get; set; }
        public Contato? Contato { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
