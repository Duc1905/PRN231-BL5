﻿using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CategoryRepository : ICategoryRepository
{
    public List<Category> GetCategories() => CategoryDAO.GetCategories();

    //public Category GetCategoryById(int id) => CategoryDAO.GetCategoriesById(id);
}
