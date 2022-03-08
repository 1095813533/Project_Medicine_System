using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class 西药处方模板BLL
    {
        public bool 西药处方录入(Model.西药处方模板 xiyao)
        {
            return new 西药处方模板DAL().西药处方录入(xiyao);
        }
        public Model.西药处方模板 西药处方查询(Model.西药处方模板 xiyao)
        {
            return new 西药处方模板DAL().西药处方查询(xiyao);
        }
    }
}
