using System;
using xia.DAL;

namespace xia.Services
{
    
    public class BaseService
    {
        protected readonly Context _Context;

        public BaseService(Context dbContext)
        {
            this._Context = dbContext;
        }
    }
}
