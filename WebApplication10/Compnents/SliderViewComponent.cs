using Microsoft.AspNetCore.Mvc;
using WebApplication10.Data;
using WebApplication10.DTOs;

namespace WebApplication10.Compnents
{
    public class SliderViewComponent : ViewComponent
    {

        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        public SliderViewComponent(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = _context.Sliders.Select(s => new SliderDto
            {
                SliderId = s.Id,
                Title = s.Title,
                BackroundImageUrl = _configuration["Folders:Sliders"] + s.BackgroundImageUrl,
                Text = s.Slogan,
                

            })

                .OrderByDescending(s => s.SliderId).ToList();
            return View(sliders);
        }
    }
}
