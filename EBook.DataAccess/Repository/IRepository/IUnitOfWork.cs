using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        void Save();
    }
}
