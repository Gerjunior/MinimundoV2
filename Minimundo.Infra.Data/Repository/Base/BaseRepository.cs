﻿using Microsoft.EntityFrameworkCore;
using Minimundo.Domain.Interfaces;
using Minimundo.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Minimundo.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MinimundoContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository()
        {
            _context = new MinimundoContext(new DbContextOptions<MinimundoContext>());
            _dbSet = _context.Set<T>();
        }

        public T Delete(int id)
        {
            T obj = Select(id);

            if (obj == null)
            {
                return null;
            }

            _dbSet.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        public T Insert(T obj)
        {
            _dbSet.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public T Select(int id)
        {
            return _dbSet.Find(id);
        }

        public T Select(string id)
        {
            return _dbSet.Find(id);
        }

        public ICollection<T> SelectAll()
        {
            return _dbSet.ToList();
        }

        public T Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }
    }
}