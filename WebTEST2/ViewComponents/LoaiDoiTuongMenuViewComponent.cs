using Microsoft.AspNetCore.Mvc;
using WebTEST2.Repository;

namespace WebTEST2.ViewComponents
{
    public class LoaiDoiTuongMenuViewComponent : ViewComponent
    {
		private readonly ILoaiDoiTuongResponsitory _qgResponsitory;
		public LoaiDoiTuongMenuViewComponent(ILoaiDoiTuongResponsitory qgResponsitory)
		{
			_qgResponsitory = qgResponsitory;
		}
		public IViewComponentResult Invoke()
		{
			var clbs = _qgResponsitory.GetAllCaulacbo().OrderBy(x => x.TenClb);
			return View(clbs);
		}
	}
}
