using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPlayground.Data;
using RazorPagesPlayground.Models;

namespace RazorPagesPlayground.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPlayground.Data.RazorPagesPostContext _context;

        public IndexModel(RazorPagesPlayground.Data.RazorPagesPostContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
