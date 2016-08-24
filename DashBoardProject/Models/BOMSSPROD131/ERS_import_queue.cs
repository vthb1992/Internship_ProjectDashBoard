namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.ERS_import_queue")]
    public partial class ERS_import_queue
    {
        [Key]
        [StringLength(10)]
        public string full_request_id { get; set; }

        [Required]
        [StringLength(50)]
        public string ERS_facility_id { get; set; }

        [Required]
        [StringLength(50)]
        public string ERS_area_id { get; set; }

        public DateTime submit_date { get; set; }

        [StringLength(50)]
        public string event_desc { get; set; }

        [Required]
        [StringLength(20)]
        public string import_status { get; set; }
    }
}
