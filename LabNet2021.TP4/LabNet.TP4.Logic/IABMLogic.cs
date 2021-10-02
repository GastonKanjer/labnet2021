using LabNet.TP4.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP4.Logic
{
    public interface IABMLogic<T, S>
    {
        List<T> GetAll();
        void Add(T obj);
        void Delete(int id);
        void Update(T obj);

        T GetOne(S obj);
    }
}
