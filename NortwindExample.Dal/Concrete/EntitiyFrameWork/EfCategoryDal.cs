using NortwindExample.Dal.Abstract;
using NortwindExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.Dal.Concrete.EntitiyFrameWork
{
    public class EfCategoryDal : ICategoryDal
    {
        ExampleContext _context = new ExampleContext();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
