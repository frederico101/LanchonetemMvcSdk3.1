using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lanchonete.Context;
using Lanchonete.Models;
using Lanchonete.Repositories;

namespace Lanchonete.Controllers
{
    public class LancheController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        // GET: Lanche
        public IActionResult List()
        {
            ViewBag.lanche = "lanches";
            var lanche = _lancheRepository.Lanches;

            return View(lanche);
        }


    }
}
