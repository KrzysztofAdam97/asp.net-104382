using SOR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOR.Repositories
{
    public class PacjentRepository : IPacjentRepository
    {
        private readonly SORContext _context;
        public PacjentRepository(SORContext context) 
        {
            _context = context;
        }
        public PacjentModel Get(int pacjentId)
            => _context.Pacjenci.SingleOrDefault(x => x.PacjentId == pacjentId);
        public IQueryable<PacjentModel> GetAllActive()
            => _context.Pacjenci.Where(x => !x.Szpital);

        public void Add(PacjentModel pacjent)
        {
            _context.Pacjenci.Add(pacjent);
            _context.SaveChanges();
        }
        public void Update(int pacjentId, PacjentModel pacjent)
        {
            var result = _context.Pacjenci.SingleOrDefault(x => x.PacjentId == pacjentId);
            if (result != null)
            {
                result.Name = pacjent.Name;
                result.Pesel = pacjent.Pesel;
                result.Wywiad = pacjent.Wywiad;
                result.Leczenie = pacjent.Leczenie;
                result.Rozpoznanie = pacjent.Rozpoznanie;
                result.Szpital = pacjent.Szpital;

                _context.SaveChanges();

            }
        }
        public void Delete(int pacjentId)
        {
            var result = _context.Pacjenci.SingleOrDefault(x => x.PacjentId == pacjentId);
            if (result != null)
            {
                _context.Pacjenci.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}
