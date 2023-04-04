using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTEST2.Models;

public partial class Cauthu
{
    public string CauThuId { get; set; } = null!;

    public string? HoVaTen { get; set; }

    public string? CauLacBoId { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? ViTri { get; set; }
    [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Chỉ cho nhập chữ")]
    public string? QuocTich { get; set; }

    public string? SoAo { get; set; }
    [RegularExpression(@"\w+\.jpg", ErrorMessage = "Đuôi phải .jpg")]
    public string? Anh { get; set; }

    public virtual Caulacbo? CauLacBo { get; set; }

    public virtual ICollection<TrandauCauthu> TrandauCauthus { get; } = new List<TrandauCauthu>();

    public virtual ICollection<TrandauGhiban> TrandauGhibans { get; } = new List<TrandauGhiban>();
}
