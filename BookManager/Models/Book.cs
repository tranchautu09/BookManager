namespace BookManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ID không được để trống")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title không được để trống")]
        [StringLength(100,ErrorMessage ="Title không được quá 100 kí tự")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description không được để trống")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Author không được để trống")]
        [StringLength(30, ErrorMessage = "Author không được quá 30 kí tự")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Image không được để trống")]
        [StringLength(255)]
        public string Images { get; set; }

        [Required(ErrorMessage = "Price không được để trống")]
        [Range(1000,1000000, ErrorMessage = "Price khoảng 1000 - 1tr")]
        public int Price { get; set; }
    }
}
