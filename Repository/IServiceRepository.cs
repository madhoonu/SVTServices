using SVTService.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVTService.Repository
{
    public interface IServiceRepository
    {
        IEnumerable<SVService> GetSVTServices();
        SVService GetSVTServicesByID(int ServiceID);
        void InsertSVTService(SVService sVServices);
        void DeleteSVTService(int ServiceID);
        void UpdateSVTService(SVService sVServices);
        void Save();
    }
}
