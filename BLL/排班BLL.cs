using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
namespace BLL
{
    public class 排班BLL
    {
        public DataTable 排班查询(Model.排班 paiban)
        {
            return new 排班DAL().排班查询(paiban);
        }
        public DataTable 加载排班(Model.排班 paiban)
        {
            return new 排班DAL().加载排班(paiban);
        }
    }
}
