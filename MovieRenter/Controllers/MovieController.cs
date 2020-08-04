using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRenter.Models;

namespace MovieRenter.Controllers
{
    public class MovieController : Controller
    {

        private readonly MovieDbContext _db;
        public MovieController(MovieDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _db.Movie.ToListAsync());

        }

        public async Task<IActionResult> Details (int? id)
        {
            if (id == null) return NotFound();
            var movie = await _db.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if(movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }



    }
}
