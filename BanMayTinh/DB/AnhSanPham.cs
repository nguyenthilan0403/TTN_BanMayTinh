namespace BanMayTinh.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnhSanPham")]
    public partial class AnhSanPham
    {
        public int Id { get; set; }

        public int? Id_SanPham { get; set; }

        public string UR_Anh { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
