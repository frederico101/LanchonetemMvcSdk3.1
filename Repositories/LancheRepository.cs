using System.Collections.Generic;
using System.Linq;
using Lanchonete.Context;
using Lanchonete.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.Repositories {
    public class LancheRepository : ILancheRepository {
        private readonly AppDbContext _context;

        public LancheRepository (AppDbContext context) {
            _context = context;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include (c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(x => x.IsLanchePreferido).Include(t => t.Categoria);

        public Lanche GetLancheById (int lancheId) =>
            _context.Lanches.FirstOrDefault (x => x.LancheId == lancheId);
        
    }
}