using HotelSolEmmanuel.Categoria.Application.DTOs;
using HotelSolEmmanuel.WebUI.HelpController;
using HotelSolEmmanuel.WebUI.Links;
using HotelSolEmmanuel.WebUI.Models.Categoria;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HotelSolEmmanuel.WebUI.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly BaseHelp baseHelp;
        private readonly ConfigUrl configUrl;

        public CategoriaController(BaseHelp apiHelp, IOptions<ConfigUrl> options)
        {
            baseHelp = apiHelp;
            configUrl = options.Value;
        }


        // GET: CategoriaController
        public async Task<ActionResult> Index()
        {
            var Response = await baseHelp.GetAsync<List<CategoriaGetModelBase>>(configUrl.GetCategoria);
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return View(new List<CategoriaGetModelBase>());
            }
        }

        // GET: CategoriaController/Details/5
        public async Task<ActionResult> Details(int id)
        {

            var Response = await baseHelp.GetAsync<CategoriaGetModelBase>(configUrl.GetCategoriabyId(id));
            if (Response.Success)
            {
                return View(Response.data);
            }
            else
            {
                ModelState.AddModelError(string.Empty, Response.Message);
                return NotFound();
            }
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CategoriaSaveModel categoriaSaveModel)
        {

            if (!ModelState.IsValid)
            {
                return View(categoriaSaveModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.CategoriaSave, categoriaSaveModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(categoriaSaveModel);
            }
        }

        // GET: CategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, CategoriaUpdateModel categoriaUpdateModel)
        {

            if (!ModelState.IsValid)
            {
                return View(categoriaUpdateModel);
            }

            var apiResponse = await baseHelp.PostAsync(configUrl.CategoriaUpdate(id), categoriaUpdateModel);

            if (apiResponse.Success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.Message);
                return View(categoriaUpdateModel);
            }
        }

        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
