using System;
using System.Collections.Generic;
using System.Text;
using Todo.Business.Abstract;
using Todo.DataAccess.Abstract;
using Todo.DataAccess.Models;

namespace Todo.Business.Concrete
{
    public class CompanyManager:ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetList();
        }

        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        public void Update(Company company)
        {
            _companyDal.Update(company);
        }

        public void Delete(int companyId)
        {
            _companyDal.Delete(new Company {CompanyId = companyId});
        }

        public Company GetById(int companyId)
        {
            return _companyDal.Get(p => p.CompanyId == companyId);
        }
    }
}
