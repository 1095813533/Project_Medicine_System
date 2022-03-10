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
    public class 员工BLL
    {
        public bool Login(Model.员工 yuangong)
        {
            return new 员工DAL().Login(yuangong);
        }
        public Model.员工 yuangong_Query1(Model.员工 yuangong) // 根据ID返回管理员信息
        {
            return new 员工DAL().yuangong_Query1(yuangong);
        }
        public Model.员工 yuangong_Query2(Model.员工 yuangong) // 根据科室和姓名获取员工编号
        {
            return new 员工DAL().yuangong_Query2(yuangong);
        }
        public bool 修改密码(Model.员工 yuangong)
        {
            return new 员工DAL().修改密码(yuangong);
        }
        public void yuangong_update(Model.员工 yuangong) // 
        {
            new 员工DAL().yuangong_update(yuangong);
        }
        public void yuangong_insert(Model.员工 yuangong)
        {
            new 员工DAL().yuangong_insert(yuangong);
        }
        public DataTable 科室员工(Model.员工 yuangong)
        {
            return new 员工DAL().科室员工(yuangong);
        }
    }
}
