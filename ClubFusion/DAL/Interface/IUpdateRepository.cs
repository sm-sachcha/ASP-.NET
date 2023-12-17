using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
     public interface IUpdateRepository<IReturnType, ReturnType, ParamIdType, ParamObjType>
    {
        IReturnType Update(ParamObjType obj);
    }
}
