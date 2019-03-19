﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Base
{
    public interface IRepository<T>
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
