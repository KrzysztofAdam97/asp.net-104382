using SOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOR.Repositories
{
    public interface IPacjentRepository
    {
        PacjentModel Get(int pacjentId);
        IQueryable<PacjentModel> GetAllActive();
        void Add(PacjentModel pacjent);
        void Update(int pacjentId, PacjentModel pacjent);
        void Delete(int pacjentId);
    }
}
