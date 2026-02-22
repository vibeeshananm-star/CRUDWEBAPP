using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDWEBAPP.Data;
using CRUDWEBAPP.Model;

namespace CRUDWEBAPP.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly CRUDWEBAPP.Data.CRUDWEBAPPContext _context;

        public DetailsModel(CRUDWEBAPP.Data.CRUDWEBAPPContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.id == id);

            if (user is not null)
            {
                User = user;

                return Page();
            }

            return NotFound();
        }
    }
}
