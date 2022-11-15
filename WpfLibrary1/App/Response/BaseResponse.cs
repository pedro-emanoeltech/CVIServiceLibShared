using System;

namespace CVIServiceLibShared.App.Response
{
    public abstract class BaseResponse
    {
        public Guid? Id { get; set; }

        public DateTime? DateCreate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
