using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTEST2.Models;
using WebTEST2.Models.APIModels;

namespace WebTEST2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CauthuAPIController : ControllerBase
    {
        QlbongDaContext db = new QlbongDaContext();
        public IEnumerable<CauthuApi> GetAllProducts()
        {
            IList<CauthuApi> cauthus = new List<CauthuApi>();
            var sanPham = db.Cauthus.ToList();
            foreach (var s in sanPham)
            {
                cauthus.Add(new CauthuApi { CauThuId = s.CauThuId, HoVaTen = s.HoVaTen, CauLacBoId = s.CauLacBoId, SoAo = s.SoAo, Anh = s.Anh });
            }
            return cauthus;
        }
        [HttpGet("{maclb}")]
        public IEnumerable<CauthuApi> GetProductsByCategory(string maclb)
        {
            IList<CauthuApi> cauthus = new List<CauthuApi>();
            var sanPham = db.Cauthus.Where(x => x.CauLacBoId == maclb).ToList();
            foreach (var s in sanPham)
            {
                cauthus.Add(new CauthuApi { CauThuId = s.CauThuId, HoVaTen = s.HoVaTen, CauLacBoId = s.CauLacBoId, SoAo = s.SoAo, Anh = s.Anh });
            }
            return cauthus;
        }
    }
}
