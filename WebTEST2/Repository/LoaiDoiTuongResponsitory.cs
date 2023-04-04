using WebTEST2.Models;

namespace WebTEST2.Repository
{
	public class LoaiDoiTuongResponsitory : ILoaiDoiTuongResponsitory
	{
		private readonly QlbongDaContext _context;

		public LoaiDoiTuongResponsitory(QlbongDaContext context)
		{
			_context = context;
		}
		public Caulacbo Add(Caulacbo caulacbo)
		{
			throw new NotImplementedException();
		}

		public Caulacbo Delete(string maLoai)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Caulacbo> GetAllCaulacbo()
		{
			return _context.Caulacbos;
		}

		public Caulacbo GetLoaiClb(string maclb)
		{
			return _context.Caulacbos.Find(maclb);
		}

		public Caulacbo Update(Caulacbo loaiSp)
		{
			throw new NotImplementedException();
		}
	}
}
