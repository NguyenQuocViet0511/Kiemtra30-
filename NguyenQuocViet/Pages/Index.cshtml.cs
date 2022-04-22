using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace NguyenQuocViet.Pages;

public class IndexModel : PageModel
{
    // private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    private readonly MyDB _context;

    public IndexModel(MyDB context)
    {
        _context = context;
    }

    public IList<NguyenQuocViet.Models.News> News { get; set; }
     public IList<NguyenQuocViet.Models.Comment> Comments { get; set; }

    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
        Comments = await _context.Comment.ToListAsync();
    }

}
