using marsev.Context;
using marsev.Models;
using marsev.RepositoryPattern.Base;
using marsev.RepositoryPattern.interfaces;

namespace marsev.RepositoryPattern.Concrete
{
    public class EtkinlikRepository : Repository<Etkinlik>, IEtkinlikRepository
    {
        public EtkinlikRepository(MMDbContext db) : base(db)
        {
        }

        public List<Etkinlik> EtkinlikAl(string EtkTipi)
        {
            return table.Where(x => x.EtkinlikTipi==EtkTipi).ToList();    
        }
    }
}
