using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRenter.Models;

namespace MovieRenter.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _db.Movie.ToListAsync());

        }

        private readonly MovieDbContext _db;
        public MovieController(MovieDbContext db)
        {
            _db = db;
        }

    }
}
