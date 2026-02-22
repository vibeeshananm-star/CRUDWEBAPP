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
    public class IndexModel : PageModel
    {
        private readonly CRUDWEBAPP.Data.CRUDWEBAPPContext _context;

        public IndexModel(CRUDWEBAPP.Data.CRUDWEBAPPContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
