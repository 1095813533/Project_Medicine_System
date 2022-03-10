using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;
namespace BLL
{
    public class 诊疗卡BLL
    {
        public bool 诊疗卡查重(Model.诊疗卡 zhenliaoka)
        {
            return new 诊疗卡DAL().诊疗卡查重(zhenliaoka);
        }
        public bool 诊疗卡注册(Model.诊疗卡 zhenliaoka)
        {
            return new 诊疗卡DAL().诊疗卡注册(zhenliaoka);
        }
        public Model.诊疗卡 诊疗卡查询(Model.诊疗卡 zhenliaoka)
        {
            return new 诊疗卡DAL().诊疗卡查询(zhenliaoka);
        }
        public void 诊疗卡退卡(Model.诊疗卡 zhenliaoka)  // 诊疗卡退卡
        {
            new 诊疗卡DAL().诊疗卡退卡(zhenliaoka);
        }
        public void 诊疗卡换卡(Model.诊疗卡 zhenliaoka, string new_card)  // 诊疗卡换卡
        {
            new 诊疗卡DAL().诊疗卡换卡(zhenliaoka,new_card);
        }
    }
}
