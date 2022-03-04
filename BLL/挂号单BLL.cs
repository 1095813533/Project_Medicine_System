using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;
namespace BLL
{
    public class 挂号单BLL
    {
        public DataTable 加载挂号单()
        {
            return new 挂号单DAL().加载挂号单();
        }
        public DataTable 加载挂号单(Model.挂号单 guahaodan)
        {
            return new 挂号单DAL().加载挂号单(guahaodan);
        }
        public DataTable 加载发药挂号单()  //加载挂号页面
        {
            return new 挂号单DAL().加载发药挂号单();
        }
        public bool 挂号(Model.挂号单 guahaodan)
        {
            return new 挂号单DAL().挂号(guahaodan);
        }
        public string 排队号(Model.挂号单 guahaodan,string date1, string date2)
        {
            return new 挂号单DAL().排队号(guahaodan,date1,date2);
        }
        public string get_last() //  根据当天的排队的最后一个人得到最新的排队号
        {
            return new 挂号单DAL().get_last();
        }
        public bool 取消挂号(Model.挂号单 guahaodan)
        {
            return new 挂号单DAL().取消挂号(guahaodan);
        }
        public bool 取消挂号1(Model.挂号单 guahaodan)
        {
            return new 挂号单DAL().取消挂号1(guahaodan);
        }
        public DataTable 挂号查询(string date1, string date2)
        {
            return new 挂号单DAL().挂号查询(date1, date2);
        }
        public DataTable 工作量查询(Model.挂号单 guahaodan, string date1, string date2)
        {
            return new 挂号单DAL().工作量查询(guahaodan, date1, date2);
        }
        public bool 接诊病人(Model.挂号单 guahaodan)
        {
            return new 挂号单DAL().接诊病人(guahaodan);
        }
        public DataTable 医生工作站_门急诊工作量统计(Model.挂号单 guahaodan, string keshibianhao, string date1, string date2)
        {
            return new 挂号单DAL().医生工作站_门急诊工作量统计(guahaodan,keshibianhao,date1,date2);
        }
        public bool 结账(Model.挂号单 guahaodan) // 
        {
            return new 挂号单DAL().结账(guahaodan);
        }
        public DataTable 是否急诊(Model.挂号单 guahaodan)
        {
            return new 挂号单DAL().是否急诊(guahaodan);
        }
        public DataTable 收费汇总(Model.挂号单 guahaodan, string zhuangtai, string date1, string date2)  // 汇总_收费汇总
        {
            return new 挂号单DAL().收费汇总(guahaodan, zhuangtai, date1, date2);
        }
        public DataTable 挂号收费汇总(string date1, string date2)  // 汇总_挂号收费汇总
        {
            return new 挂号单DAL().挂号收费汇总(date1, date2);
        }
        public bool guahaodan_query(string binganhao)
        {
            return new 挂号单DAL().guahaodan_query(binganhao);
        }
    }

}
