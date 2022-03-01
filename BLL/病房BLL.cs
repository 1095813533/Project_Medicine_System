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
    public class 病房BLL
    {
        public DataTable 病房查询(Model.病房 bingfang)
        {
            return new 病房DAL().病房查询(bingfang);
        }
        public bool 病人住院(string choose, Model.病例 bingli, Model.病房 bingfang)
        {
            return new 病房DAL().病人住院(choose, bingli, bingfang);
        }
        public DataTable 加载病房(Model.病房 bingfang)
        {
            return new 病房DAL().加载病房(bingfang);
        }
        public bool 加载病床(string bingchuang, string bingfangbianhao)
        {
            return new 病房DAL().加载病床(bingchuang, bingfangbianhao);
        }
        public void 出院(string bingfangbinahao, string keshibianhao, string bingrenbianhao)
        {
            new 病房DAL().出院(bingfangbinahao,keshibianhao,bingrenbianhao);
        }

    }
}
