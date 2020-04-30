using System.Collections.Generic;
using System.Collections;
using Lanchonete.Models;

namespace Lanchonete.Repositories
{
    public interface ILancheRepository
    {
         IEnumerable<Lanche> Lanches {get;}
         IEnumerable<Lanche> LanchesPreferidos {get;}
         Lanche GetLancheById(int lancheId);

    }
}