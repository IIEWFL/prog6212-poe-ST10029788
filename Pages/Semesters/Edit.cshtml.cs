﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModuleCalculatorWeb.Data;
using ModuleCalculatorWeb.Models;

namespace ModuleCalculatorWeb.Pages.Semesters
{
    public class EditModel : PageModel
    {
        private readonly ModuleCalculatorWeb.Data.ApplicationDbContext _context;

        public EditModel(ModuleCalculatorWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Semester Semester { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Semester = await _context.Semester.FirstOrDefaultAsync(m => m.semesterID == id);

            if (Semester == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Semester).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SemesterExists(Semester.semesterID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SemesterExists(int id)
        {
            return _context.Semester.Any(e => e.semesterID == id);
        }
    }
}
