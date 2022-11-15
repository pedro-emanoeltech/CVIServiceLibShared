using CVIServiceLibShared.Constants.Enums;
using System;

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

        public CargoResponse? Cargo { get; set; }
        public SegmentoResponse? Segmento { get; set; }
        public ContatoResponse? Contato { get; set; }
        public CidadeResponse? Cidade { get; set; }
    }
}
