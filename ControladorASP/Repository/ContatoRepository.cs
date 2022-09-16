using ControladorASP.Data;
using ControladorASP.Models;

namespace ControladorASP.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly DatabaseContext _databaseContext;
        public ContatoRepository(DatabaseContext database)
        {
            _databaseContext = database;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _databaseContext.Contatos.Add(contato);
            _databaseContext.SaveChanges();
            return contato;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _databaseContext.Contatos.ToList();
        }
    }
}
