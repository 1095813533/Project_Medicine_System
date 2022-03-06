using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class 检查单BLL
    {
        public void 生成检查单(Model.检查单 jianchadan)  //生成检查单
        {
            new 检查单DAL().生成检查单(jianchadan);
        }
        public Model.检查单 检查单查询(Model.检查单 jianchadan) // 检查单查询
        {
            return new 检查单DAL().检查单查询(jianchadan);
        }
        public void 更新检查单(Model.检查单 jianchadan) // 检查单查询
        {
            new 检查单DAL().更新检查单(jianchadan);
        }
        public Model.检查单 检查单查询2(Model.检查单 jianchadan) // 检查单查询2，通过病案号查询
        {
            return new 检查单DAL().检查单查询2(jianchadan);
        }
    }
}
