using Microsoft.AspNetCore.Mvc;
using Store.Entities;
using Store.Service.Abstract;

namespace Store.WebUI.ViewComponents
{
    public class Categories : ViewComponent
    {
        private readonly IService<Category> _service;

        public Categories(IService<Category> service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // var model = await _service.GetAllAsync();
            return View(await _service.GetAllAsync(c => c.IsActive && c.IsTopMenu));
        }

    }
}
