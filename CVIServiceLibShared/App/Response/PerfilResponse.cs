using CVIServiceLibShared.Constants.Enums;
using System;
using System.Collections.Generic;

namespace CVIServiceLibShared.App.Response
{
    public class PerfilResponse : BaseResponse
    {
        public Guid ContaId { get; set; }
        public string? Nome { get; set; }
        public string? Bio { get; set; }
        public string? Apelido { get; set; }
        public Int64? CPF { get; set; }
        public Int64? CNPJ { get; set; }
        public int? Idade { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }
        public Genero? Genero { get; set; }

        public Guid? NacionalidadeId { get; set; }
        public Guid? SegmentoId { get; set; }
        //// Relacionamento

        public SegmentoResponse? Segmento { get; set; }
        public NacionalidadeResponse? Nacionalidade { get; set; }
        public EscolaridadeResponse? Escolaridade { get; set; }
        public EnderecoResponse? Endereco { get; set; }

        public IList<ContatoResponse>? Contato { get; set; }

        public ObjetivoResponse? Objetivo { get; set; }

        public IdiomaResponse? Idioma { get; set; }

        public IList<HistoricoProfissionalResponse>? HistoricoProfissional { get; set; }

        public IList<CursoFormacaoAcademicaResponse>? CursoFormacaoAcademica { get; set; }





    }
}
