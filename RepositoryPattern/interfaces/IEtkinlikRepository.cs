using marsev.Models;

namespace marsev.RepositoryPattern.interfaces
{
    public interface IEtkinlikRepository : IRepository<Etkinlik>
    {
        List<Etkinlik> EtkinlikAl(string EtkTipi);
    }
}
