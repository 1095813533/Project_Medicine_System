using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Model;
namespace BLL
{
    public class 科室BLL
    {
        public DataTable 科室刷新(Model.科室 keshi )
        {
            return new 科室DAL().科室刷新(keshi);
        }
        public DataTable 加载科室()
        {
            return new 科室DAL().加载科室();
        }
        public Model.科室 keshi_Query1(Model.科室 keshi) // 根据科室名获取科室信息
        {
            return new 科室DAL().keshi_Query1(keshi);
        }
        public Model.科室 keshi_Query2(Model.科室 keshi) // 根据科室编号获取科室信息
        {
            return new 科室DAL().keshi_Query2(keshi);
        }
    }
}
