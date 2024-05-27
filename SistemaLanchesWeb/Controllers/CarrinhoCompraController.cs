using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaLanchesWeb.Models;
using SistemaLanchesWeb.Repositories.Interfaces;
using SistemaLanchesWeb.ViewModels;

namespace SistemaLanchesWeb.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        [Authorize]
        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            var lanchesSelecionado = _lancheRepository.GetLancheById(lancheId);

            if (lanchesSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lanchesSelecionado); 
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {
            var lanchesSelecionado = _lancheRepository.GetLancheById(lancheId);

            if (lanchesSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lanchesSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
