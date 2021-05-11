using Base.EntityModel;
using Base.InterFace;
using Base.Model.DBContext;
using System.Linq;

namespace Base.Concrete
{
    public class EFAccount : IAccount
    {
        private readonly TestDbContext context = new TestDbContext();


        //取得所有帳號
        public IQueryable<Account> Accounts
        {
            get { return context.Account; }
        }

    }
}
