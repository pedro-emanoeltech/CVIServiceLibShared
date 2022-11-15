using CVIServiceLibShared.Constants.Enums;
using System;
using System.Collections.Generic;

namespace CVIServiceLibShared.App.Response
{
    public class PerfilResponse : BaseResponse
    {
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public TipoPerfil? TipoPerfil { get; set; }
        public Int64? CPF { get; set; }
        public Int64? CNPJ { get; set; }
        public int? Idade { get; set; }
        public EstadoCivil? EstadoCivil { get; set; }
        public Genero? Genero { get; set; }

        public Guid? NacionalidadeId { get; set; }
        public Guid? SegmentoId { get; set; }
        //// Relacionamento

        public Segmento? Segmento { get; set; }
        public Nacionalidade? Nacionalidade { get; set; }
        public Escolaridade? Escolaridade { get; set; }
        public Endereco? Endereco { get; set; }

        public IList<Contato>? Contato { get; set; }

        public Objetivo? Objetivo { get; set; }

        public Idioma? Idioma { get; set; }

        public IList<HistoricoProfissional>? HistoricoProfissional { get; set; }

        public IList<CursoFormacaoAcademica>? CursoFormacaoAcademica { get; set; }





    }
}
