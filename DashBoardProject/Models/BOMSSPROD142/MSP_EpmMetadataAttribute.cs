namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSP_EpmMetadataAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSP_EpmMetadataAttribute()
        {
            MSP_EpmCustomFieldAssociation = new HashSet<MSP_EpmCustomFieldAssociation>();
            MSP_TimesheetCustomFieldAssociation = new HashSet<MSP_TimesheetCustomFieldAssociation>();
        }

        [Key]
        public Guid AttributeTypeUID { get; set; }

        public Guid EntityTypeUID { get; set; }

        public bool AttributeIsIntrinsic { get; set; }

        public bool AttributeIsTimephased { get; set; }

        [StringLength(255)]
        public string AttributeColumnName { get; set; }

        public Guid? SecondaryCustomFieldTypeUID { get; set; }

        public int? CustomFieldColumnID { get; set; }

        public int? CustomFieldWeightColumnID { get; set; }

        [Required]
        [StringLength(255)]
        public string AttributeName { get; set; }

        public byte AttributeProjType { get; set; }

        public int IntrinsicAttributeOlapRole { get; set; }

        public Guid? DimensionUID { get; set; }

        public bool AttributeIsMultiValueEnabled { get; set; }

        public bool AttributeHasWeights { get; set; }

        public bool AssignmentRollDown { get; set; }

        public int? AttributeIndex { get; set; }

        public int OlapAggregationType { get; set; }

        [Required]
        [StringLength(1000)]
        public string AttributeDescription { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModificationDate { get; set; }

        public bool IsSelectable { get; set; }

        public bool PresentInTable { get; set; }

        public bool PresentInUserView { get; set; }

        public int EpmBaselineIndex { get; set; }

        public int GroupingTypeID { get; set; }

        public Guid? TimesheetPrimaryCustomFieldTypeUID { get; set; }

        public byte TimesheetCustomFieldOrigin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_EpmCustomFieldAssociation> MSP_EpmCustomFieldAssociation { get; set; }

        public virtual MSP_EpmMetadataProjectType MSP_EpmMetadataProjectType { get; set; }

        public virtual MSP_EpmMetadataColumnPool MSP_EpmMetadataColumnPool { get; set; }

        public virtual MSP_EpmMetadataColumnPool MSP_EpmMetadataColumnPool1 { get; set; }

        public virtual MSP_EpmMetadataEntities MSP_EpmMetadataEntities { get; set; }

        public virtual MSP_EpmMetadataOlapAggregationType MSP_EpmMetadataOlapAggregationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSP_TimesheetCustomFieldAssociation> MSP_TimesheetCustomFieldAssociation { get; set; }
    }
}
