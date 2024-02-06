using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace nms_backend_api.Entity
{
    [Table("tbl_schedule")]
    public class ScheduleClass
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        [Column("ClassId")]
        public int ClassId { get; set; }

        [Required]
        [Column("TeacherId")]
        public int TeacherId { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        public string Sessiontime {  get; set; }


        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }
        [ForeignKey("ClassId")]
        public Class1 Class1 { get; set; }
    }
}