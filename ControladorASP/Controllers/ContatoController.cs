using ControladorASP.Models;
using ControladorASP.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControladorASP.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contato = _contatoRepository.BuscarTodos();
            return View(contato);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            ContatoModel contato = _contatoRepository.ListById(id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Create(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRegister(int Id)
        {
            _contatoRepository.Excluir(Id);
            return RedirectToAction("Index");
        }
    }
}
