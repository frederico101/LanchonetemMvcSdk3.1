using System.Collections.Generic;
using Lanchonete.Context;
using Lanchonete.Models;

namespace Lanchonete.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => 
        _context.Categorias;
    }
}