namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAMS.factory_system_threshold_hist")]
    public partial class factory_system_threshold_hist
    {
        [Key]
        public int threshold_hist_id { get; set; }

        public int factory_system_id { get; set; }

        public int? cq_hours_threshold { get; set; }

        public int? JIRAStoryPointsThreshold { get; set; }

        public DateTime? CQThresholdEffectiveDate { get; set; }

        public DateTime? JIRAThresholdEffectiveDate { get; set; }

        public DateTime threshold_hist_datetime { get; set; }
    }
}
