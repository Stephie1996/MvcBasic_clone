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
        [Display(Name = "�m�W")]
        [Required(ErrorMessage = "Name������J")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "�ֻ̤ݭn�T�Ӧr��")]
        public string Name { get; set; }
        [Display(Name = "��ʹq��")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "�ݬ�09xx-xxx-xxx�榡")]
        [Required(ErrorMessage = "Phone������J")]
        public string Phone { get; set; }
        [Display(Name = "�q�l�l��")]
        [Required(ErrorMessage = "Email������J")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "�ʧO")]
        [Required(ErrorMessage = "Gender������J")]
        public string Gender { get; set; }
    }
}
