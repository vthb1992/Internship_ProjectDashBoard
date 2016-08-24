namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmResource_UserView
    {
        [Key]
        [Column(Order = 0)]
        public Guid ResourceUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ResourceName { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ResourceStandardRate { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ResourceOvertimeRate { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid ResourceStatusUID { get; set; }

        [StringLength(255)]
        public string ResourceCode { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ResourceCostPerUse { get; set; }

        [StringLength(255)]
        public string ResourceEmailAddress { get; set; }

        [StringLength(255)]
        public string ResourceInitials { get; set; }

        [StringLength(255)]
        public string ResourceMaterialLabel { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ResourceType { get; set; }

        [StringLength(255)]
        public string ResourceGroup { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ResourceMaxUnits { get; set; }

        public byte? ResourceBookingType { get; set; }

        public Guid? ResourceTimesheetManagerUID { get; set; }

        public DateTime? ResourceEarliestAvailableFrom { get; set; }

        public DateTime? ResourceLatestAvailableTo { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool ResourceCanLevel { get; set; }

        [StringLength(1024)]
        public string ResourceHyperlink { get; set; }

        [StringLength(255)]
        public string ResourceHyperlinkHref { get; set; }

        [StringLength(255)]
        public string ResourceNTAccount { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool ResourceIsActive { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool ResourceIsGeneric { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool ResourceIsTeam { get; set; }

        [StringLength(255)]
        public string ResourceBaseCalendar { get; set; }

        public short? ResourceWorkgroup { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceClientUniqueId { get; set; }

        [StringLength(255)]
        public string ResourceCostCenter { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceCreatedRevisionCounter { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceModifiedRevisionCounter { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime ResourceCreatedDate { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime ResourceModifiedDate { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceCount { get; set; }

        [Column("Cost Type")]
        [StringLength(4000)]
        public string Cost_Type { get; set; }

        [Column("Team Name")]
        [StringLength(4000)]
        public string Team_Name { get; set; }

        [StringLength(4000)]
        public string RBS { get; set; }

        [Column("Worker Team")]
        [StringLength(4000)]
        public string Worker_Team { get; set; }

        [Column("Worker Organization")]
        [StringLength(4000)]
        public string Worker_Organization { get; set; }

        [Column("Worker Role")]
        [StringLength(4000)]
        public string Worker_Role { get; set; }

        [Column("Resource Departments")]
        [StringLength(4000)]
        public string Resource_Departments { get; set; }

        [Column("Worker Domain")]
        [StringLength(4000)]
        public string Worker_Domain { get; set; }
    }
}
