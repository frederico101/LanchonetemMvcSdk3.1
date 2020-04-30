using System.Collections.Generic;
using Lanchonete.Models;

namespace Lanchonete.Repositories
{
    public interface ICategoriaRepository
    {
           IEnumerable<Categoria> Categorias {get;}
    }
}