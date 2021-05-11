using Base.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.InterFace
{
    public interface IAccount
    {
        //取得所有帳號
        IQueryable<Account> Accounts { get; }
    }
}
