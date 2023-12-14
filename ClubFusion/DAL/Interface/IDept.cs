using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDept<ReturnType, IReturnType, ParamIdType, ParamObjType>
    {
        List<ReturnType> GetAll();
        IReturnType Insert(ParamObjType obj);
        IReturnType Update(ParamObjType obj);
        IReturnType Delete(ParamObjType obj);
    }
}
