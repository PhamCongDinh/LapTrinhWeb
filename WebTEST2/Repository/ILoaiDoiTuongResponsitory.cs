using WebTEST2.Models;

namespace WebTEST2.Repository
{
    public interface ILoaiDoiTuongResponsitory
    {
		Caulacbo Add(Caulacbo caulacbo);
		Caulacbo Update(Caulacbo loaiSp);
		Caulacbo Delete(string maLoai);
		Caulacbo GetLoaiClb(string maclb);
		IEnumerable<Caulacbo> GetAllCaulacbo();
	}
}
