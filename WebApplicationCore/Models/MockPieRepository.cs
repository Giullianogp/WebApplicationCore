using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public IEnumerable<Pie> GetAllPies()
        {
            throw new NotImplementedException();
        }

        public Pie GetPieById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
