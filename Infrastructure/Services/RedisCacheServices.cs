﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services
{
    public class RedisCacheServices : ICacheService
    {
        public void Remove(string cacheKey)
        {
            throw new NotImplementedException();
        }

        public T Set<T>(string cacheKey, T value)
        {
            throw new NotImplementedException();
        }

        public bool TryGet<T>(string cacheKey, out T value)
        {
            throw new NotImplementedException();
        }
    }
}
