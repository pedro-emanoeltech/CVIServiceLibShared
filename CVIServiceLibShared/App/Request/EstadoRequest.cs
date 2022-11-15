using CVIServiceLibShared.App.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVIServiceLibShared.App.Request
{
    public class EstadoRequest : BaseRequest
    {
        public Guid? PaisId { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }

    }
}
