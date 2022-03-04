using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class 草药处方模板BLL
    {
        public bool 草药处方录入(Model.草药处方模板 caoyao)
        {
            return new 草药处方模板DAL().草药处方录入(caoyao);
        }
        public Model.草药处方模板 草药处方查询(Model.草药处方模板 caoyao)
        {
            return new 草药处方模板DAL().草药处方查询(caoyao);
        }
    }
}
