using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.DbContexts;
using CakesWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CakesWebApplication.Repository_Implementation
{
    public class PieRepository : IPieRepository
    {
        private PiesDbContext _Context;

        public PieRepository(PiesDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<PieDto> Pies => _Context.Pies.Include(c=> c.Category).ToList();

        public IEnumerable<PieDto> PiesOfTheWeek => _Context.Pies.Include(c => c.Category).Where(c  => c.IsPieOfTheWeek).ToList();

        public IEnumerable<PieDto> PiesWithCategory(string category)
        {
            return _Context.Pies.Include(c => c.Category).Where(c => c.Category.CategoryName==category).ToList();
        }

        public PieDto PieById(int Id)
        {
            return _Context.Pies.Include(c => c.Category).Where(c => c.Id == Id).FirstOrDefault();
        }

    }
}
