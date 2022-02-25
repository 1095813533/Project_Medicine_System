using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BLL
{
    public static class static_var
    {
        public static 员工 yuangong = new 员工();
        public static 诊疗卡 zhenliaoka = new 诊疗卡();
        public static 挂号单 guahaodan = new 挂号单();
        public static 检查单 jianchadan = new 检查单();
        public static 草药处方模板 caoyao = new 草药处方模板();
        public static 西药处方模板 xiyao = new 西药处方模板();
    }
}
