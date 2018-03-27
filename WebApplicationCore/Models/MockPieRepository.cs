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
                new Pie {PieId = 1, Name = "Torta de Limão", Price = 12.50M, ShortDescription = "Bolo muito macio, mas pouco saboroso", ImageThumbnailUrl = "https://www.vovopalmirinha.com.br/wp-content/uploads/2017/02/bolo-prestigio.jpg" },
                new Pie {PieId = 1, Name = "Torta de Morango", Price = 10.50M, ShortDescription = "Bolo um tanto estranho porém irresistivel", ImageThumbnailUrl = "https://guiadacozinha.com.br/wp-content/uploads/2016/11/Bolo-leite-condensado-molhadinho.jpg"},
                new Pie {PieId = 1, Name = "Torta de maracujá", Price = 15.50M, ShortDescription = "Bolo de doce de leite com cobertura desconhecida", ImageThumbnailUrl = "https://www.lactosenao.com/wp-content/uploads/2017/07/bolo-festa-sem-gluten-e-lactose.png"},
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
