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
    public class 药品BLL
    {
        public DataTable 加载药品()//加载药品
        {
            return new 药品DAL().加载药品();
        }
        public Model.药品 获取编号(Model.药品 yaopin) // 根据药品名获取药品信息
        {
            return new 药品DAL().获取编号(yaopin);
        }
        public Model.药品 药品查询(Model.药品 yaopin)
        {
            return new 药品DAL().药品查询(yaopin);
        }
        public bool 药品查重(Model.药品 yaopin)  // 查询药品是否出现过
        {
            return new 药品DAL().药品查重(yaopin);
        }
        public bool 修改药品(Model.药品 yaopin, int num)
        {
            return new 药品DAL().修改药品(yaopin, num);
        }
        public bool 新增药品(Model.药品 yaopin)
        {
            return new 药品DAL().新增药品(yaopin);
        }
        public Model.药品 药品编号查询药品信息(Model.药品 yaopin)
        {
            return new 药品DAL().药品编号查询药品信息(yaopin);
        }
        public bool isok(Model.药品 yaopin, int num)  // 查询药品的剩余量是否充足
        {
            return new 药品DAL().isok(yaopin, num);
        }
        public bool 发药(Model.药品 yaopin, int num)
        {
            return new 药品DAL().发药(yaopin, num);
        }
    }
}
