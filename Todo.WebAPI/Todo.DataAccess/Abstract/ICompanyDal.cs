using System;
using System.Collections.Generic;
using System.Text;
using Todo.Core.DataAccess;
using Todo.DataAccess.Models;

namespace Todo.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
    }
}
