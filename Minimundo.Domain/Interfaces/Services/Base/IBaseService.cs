﻿using System.Collections.Generic;

namespace Minimundo.Domain.Interfaces
{
    public interface IBaseService<T>
    {
        T Select(int id);

        T Select(string id);

        T Update(T obj);

        T Delete(int id);

        T Insert(T obj);

        ICollection<T> SelectAll();
    }
}