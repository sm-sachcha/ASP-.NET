using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDeleteRepository<ReturnType, IReturnType, ParamIdTyype, ParamObjType>
    {
        List<ReturnType> GetAll();
        IReturnType Delete(ParamObjType id);
    }
}
