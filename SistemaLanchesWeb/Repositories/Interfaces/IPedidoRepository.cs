using SistemaLanchesWeb.Models;

namespace SistemaLanchesWeb.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
