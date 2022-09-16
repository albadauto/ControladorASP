using ControladorASP.Models;

namespace ControladorASP.Repository
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> BuscarTodos();
    }
}
