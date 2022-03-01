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
    public class 病例BLL
    {
        public DataTable 诊断统计(Model.病例 bingli, string date1, string date2)
        {
            return new 病例DAL().诊断统计(bingli, date1, date2);
        }
        public DataTable 病例查询(Model.病例 bingli, string date1, string date2)
        {
            return new 病例DAL().病例查询(bingli, date1, date2);
        }
        public bool 确诊病人(Model.病例 bingli)
        {
            return new 病例DAL().确诊病人(bingli);
        }
        public Model.病例 病案号_查询模板编号(Model.病例 bingli)  // 根据病案号返回对应的模板编号
        {
            return new 病例DAL().病案号_查询模板编号(bingli);
        }
        public DataTable 加载病例()  // 加载病例表
        {
            return new 病例DAL().加载病例();
        }
    }
}
