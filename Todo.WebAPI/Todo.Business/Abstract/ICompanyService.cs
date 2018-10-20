using System;
using System.Collections.Generic;
using System.Text;
using Todo.DataAccess.Models;

namespace Todo.Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        void Add(Company company);
        void Update(Company company);
        void Delete(int companyId);
        Company GetById(int companyId);
    }
}
