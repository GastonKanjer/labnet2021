using LabNet.TP5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP5.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContext context;

        public BaseLogic()
        {
            context = new NorthWindContext();
        }

    }
}