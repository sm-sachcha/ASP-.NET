using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepository<ReturnType, IReturnType, ParamIdType, ParamObjType>
    {
        List<ReturnType> GetAll();
        ReturnType GetById(ParamIdType id);
        IReturnType Insert(ParamObjType obj);
        IReturnType Update(ParamObjType obj);
        IReturnType Delete(ParamObjType obj);
    }
}
