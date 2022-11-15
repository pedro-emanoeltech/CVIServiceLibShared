using System;

namespace CVIServiceLibShared.App.Response
{
    public class CargoResponse : BaseResponse
    {
        public Guid? HistoricoProfissionalId { get; set; }
        public string? NomeCargo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? DescricaoCargo { get; set; }
    }
}
