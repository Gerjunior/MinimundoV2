﻿using Minimundo.Domain.Interfaces;
using Minimundo.Infra.Data.Repository;
using System.Collections.Generic;

namespace Minimundo.Service.Service
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly BaseRepository<T> _repository;

        public BaseService()
        {
            _repository = new BaseRepository<T>();
        }

        public T Delete(int id)
        {
            return _repository.Delete(id);
        }

        public T Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public T Select(int id)
        {
            return _repository.Select(id);
        }

        public T Select(string id)
        {
            return _repository.Select(id);
        }

        public ICollection<T> SelectAll()
        {
            return _repository.SelectAll();
        }

        public T Update(T obj)
        {
            return _repository.Update(obj);
        }
    }
}