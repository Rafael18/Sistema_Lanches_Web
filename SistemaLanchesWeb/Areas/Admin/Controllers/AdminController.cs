using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaLanchesWeb.Services;

namespace SistemaLanchesWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        //private readonly ISeedUserRoleInitial _userRoler;
        //public AdminController(ISeedUserRoleInitial userRole)
        //{
        //    _userRoler = userRole;
        //}

        public IActionResult Index()
        {
            //CriarPerfisUsuario();
            return View();
        }

        //Método responsavel por fornecedor uma instancia de tipos em tempo de execução
        //void CriarPerfisUsuario()
        //{
        //    _userRoler.SeedRoles();
        //    _userRoler.SeedUsers();
        //}
    }
}
