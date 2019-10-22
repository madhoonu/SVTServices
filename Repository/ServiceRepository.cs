using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SVTService.DBContext;
using SVTService.Module;

namespace SVTService.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly SVTServiceDBContext _dbContext;

        public ServiceRepository(SVTServiceDBContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void DeleteSVTService(int serviceID)
        {
            var service = _dbContext.SVServices.Find(serviceID);
            _dbContext.SVServices.Remove(service);
            Save();
        }

        public IEnumerable<SVService> GetSVTServices()
        {
            return _dbContext.SVServices.ToList();
        }

        public SVService GetSVTServicesByID(int serviceID)
        {
            return _dbContext.SVServices.Find(serviceID);
        }

        public void InsertSVTService(SVService sVServices)
        {
            _dbContext.SVServices.Add(sVServices);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateSVTService(SVService sVServices)
        {
            _dbContext.Entry(sVServices).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
