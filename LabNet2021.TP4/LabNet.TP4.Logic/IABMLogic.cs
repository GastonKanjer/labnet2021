using LabNet.TP4.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP4.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();

        void Add(T obj);
        void Delete(int id);
        void Update(T obj);
    }
}
