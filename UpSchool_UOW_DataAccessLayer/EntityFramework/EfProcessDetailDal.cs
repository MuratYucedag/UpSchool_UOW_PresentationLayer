using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UOW_DataAccessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Concrete;
using UpSchool_UOW_DataAccessLayer.Repository;
using UpSchool_UOW_EntityLayer.Concrete;

namespace UpSchool_UOW_DataAccessLayer.EntityFramework
{
    public class EfProcessDetailDal : GenericRepository<ProcessDetail>, IProcessDetailDal
    {
        public EfProcessDetailDal(Context context) : base(context)
        {

        }
    }
}
/*
repository
chainof
cqrs
mediatr
observer
template
uow

SignalR
 */