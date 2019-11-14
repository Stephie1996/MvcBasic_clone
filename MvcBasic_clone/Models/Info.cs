namespace MvcBasic_clone.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Info")]
    public partial class Info
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "Name必須輸入")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "最少需要三個字元")]
        public string Name { get; set; }
        [Display(Name = "行動電話")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [Required(ErrorMessage = "Phone必須輸入")]
        public string Phone { get; set; }
        [Display(Name = "電子郵件")]
        [Required(ErrorMessage = "Email必須輸入")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "性別")]
        [Required(ErrorMessage = "Gender必須輸入")]
        public string Gender { get; set; }
    }
}
