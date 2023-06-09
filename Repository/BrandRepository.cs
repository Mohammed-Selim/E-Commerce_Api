﻿using Application.Contracts;
using Context;
using Domain.Entities;

namespace Repository
{
	public class BrandRepository : Repository<Brand, int>, IBrandRepository
    {
        public BrandRepository(DContext context) : base(context)
        { }
        public Task<IEnumerable<Brand>> FilterByAsync(string? name = null)
        {
            IEnumerable<Brand> brands = _context.Brand
            .Where(p => name == null || p.Name.ToLower().Contains(name.ToLower()));
            return Task.FromResult(brands);
        }
	}
}
