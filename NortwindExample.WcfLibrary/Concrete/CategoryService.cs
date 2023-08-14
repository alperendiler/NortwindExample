using NortwindExample.Bll.Concrete;
using NortwindExample.Dal.Concrete.EntitiyFrameWork;
using NortwindExample.Entities;
using NortwindExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.WcfLibrary.Concrete
{
    public class CategoryService : ICategoryService
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }
    }
}
