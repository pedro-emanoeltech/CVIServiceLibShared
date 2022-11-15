using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Response
{
    public  class VagaResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? EstadoId { get; set; }
        public Guid? ContatoId { get; set; }

        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? Requisitos { get; set; }
        public string? Beneficio { get; set; }
        public ModalidadeTrabalho? ModalidadeTrabalho { get; set; }
        public string? Url { get; set; }

        public ContatoResponse? Contato { get; set; }
        public CidadeResponse? Cidade { get; set; }
        public EstadoResponse? Estado { get; set; }


        //relacionamento
        public PerfilResponse? Perfil { get; set; }
    }
}
