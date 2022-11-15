using System;

namespace CVIServiceLibShared.App.Request
{
    public class CargoRequest : BaseRequest
    {
        public Guid? HistoricoProfissional_Id{ get; set; }
        public string? NomeCargo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? DescricaoCargo { get; set; }

    }
}
