using RadarFit.DAO;

namespace RadarFit.BLL
{
    public abstract class BaseBLL : IDisposable
    {
        public readonly Context _db;

        public BaseBLL(Context db)
        {
            _db = db;
        }

        public virtual void Dispose()
        {

        }
    }
}
