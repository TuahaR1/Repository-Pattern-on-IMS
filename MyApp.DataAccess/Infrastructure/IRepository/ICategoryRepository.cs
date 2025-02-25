﻿using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccess.Infrastructure.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);
    }
}
