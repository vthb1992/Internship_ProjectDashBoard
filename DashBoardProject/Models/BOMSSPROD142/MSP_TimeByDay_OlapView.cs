namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_TimeByDay_OlapView
    {
        [Key]
        [Column(Order = 0)]
        public DateTime TimeByDay { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CalendarMemberKeyYear { get; set; }

        [StringLength(30)]
        public string CalendarMemberNameYear { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte CalendarMemberKeyQuarter { get; set; }

        [StringLength(37)]
        public string CalendarMemberNameQuarter { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte CalendarMemberKeyMonth { get; set; }

        [StringLength(1000)]
        public string CalendarMemberNameMonth { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte CalendarMemberKeyWeek { get; set; }

        [StringLength(34)]
        public string CalendarMemberNameWeek { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CalendarMemberKeyDay { get; set; }

        [StringLength(33)]
        public string CalendarMemberNameDay { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string FiscalMemberKeyYear { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string FiscalMemberNameYear { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string FiscalMemberKeyQuarter { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(258)]
        public string FiscalMemberNameQuarter { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(255)]
        public string FiscalMemberKeyPeriod { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(255)]
        public string FiscalMemberNamePeriod { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime FiscalMemberKeyDay { get; set; }

        [StringLength(1035)]
        public string FiscalMemberNameDay { get; set; }
    }
}
