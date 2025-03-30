﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00172691_BlazorServer.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);
        void Delete(T obj);
        IEnumerable<T> GetAll();

        T Get(int id);
    }
}
