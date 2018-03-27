using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplicationCore.Models
{
    public class MockPieRepository : IPieRepository
    {
        private IEnumerable<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>()
            {
                new Pie {Id = 1, Name = "Torta de Limão", Price = 12.50M },
                new Pie {Id = 1, Name = "Torta de Morango", Price = 10.50M},
                new Pie {Id = 1, Name = "Torta de maracujá", Price = 15.50M},
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int id)
        {
            return _pies.FirstOrDefault(x => x.Id == id);
        }
    }
}
