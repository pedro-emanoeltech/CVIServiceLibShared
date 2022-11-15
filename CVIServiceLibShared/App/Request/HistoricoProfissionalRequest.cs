using System;

namespace CVIServiceLibShared.App.Request
{
    public class HistoricoProfissionalRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }

        public string? NomeEmpresa { get; set; }
        public PorteEmpresa? Porte { get; set; }

        public Guid? ContatoId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? SegmentoId { get; set; }

    }
}
