using CVIServiceLibShared.App.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVIServiceLibShared.App.Request
{
    public class ObjetivoRequest :BaseRequest
    {

        public Guid? PerfilId { get; set; }
        public string? AreaInteresse { get; set; }

        public double? PretensaoSalarial { get; set; }

        public string? ResumoProfissional { get; set; }

       
    }
}
