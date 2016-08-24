namespace DashBoardProject.Models.BOMSSPROD142
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_MSP_EpmProject_IS
    {
        [Key]
        [Column("Project Name", Order = 0)]
        [StringLength(255)]
        public string Project_Name { get; set; }

        [Key]
        [Column("Project UID", Order = 1)]
        public Guid Project_UID { get; set; }

        [Column("Project ID")]
        [StringLength(4000)]
        public string Project_ID { get; set; }

        [Column("Reference ID")]
        [StringLength(4000)]
        public string Reference_ID { get; set; }

        [Column("Project Description")]
        [StringLength(4000)]
        public string Project_Description { get; set; }

        [Column("Project Exclusions")]
        [StringLength(4000)]
        public string Project_Exclusions { get; set; }

        [Column("Project Scope")]
        [StringLength(4000)]
        public string Project_Scope { get; set; }

        [Key]
        [Column("IS Cost Project", Order = 2)]
        public bool IS_Cost_Project { get; set; }

        [Column("First Portfolio Submittal")]
        [StringLength(30)]
        public string First_Portfolio_Submittal { get; set; }

        [Column("Proposed Start")]
        [StringLength(30)]
        public string Proposed_Start { get; set; }

        [Column("Proposed Finish")]
        [StringLength(30)]
        public string Proposed_Finish { get; set; }

        [Column("Project Start Date")]
        [StringLength(30)]
        public string Project_Start_Date { get; set; }

        [Column("Project Finish Date")]
        [StringLength(30)]
        public string Project_Finish_Date { get; set; }

        [Column("Project Owner Name")]
        [StringLength(255)]
        public string Project_Owner_Name { get; set; }

        [Column("Project Manager Name")]
        [StringLength(255)]
        public string Project_Manager_Name { get; set; }

        [Column("Proposed PM")]
        [StringLength(4000)]
        public string Proposed_PM { get; set; }

        [Column("Proposal Authors")]
        [StringLength(4000)]
        public string Proposal_Authors { get; set; }

        [Column("Executive Sponsor")]
        [StringLength(4000)]
        public string Executive_Sponsor { get; set; }

        [Column("Project Sponsor")]
        [StringLength(4000)]
        public string Project_Sponsor { get; set; }

        [Column("Key Stakeholders")]
        [StringLength(4000)]
        public string Key_Stakeholders { get; set; }

        [Column("Lead Architect")]
        [StringLength(4000)]
        public string Lead_Architect { get; set; }

        [Column("Cost Status")]
        [StringLength(4000)]
        public string Cost_Status { get; set; }

        [Column("Cost Status Details")]
        [StringLength(4000)]
        public string Cost_Status_Details { get; set; }

        [Column("Resource Status")]
        [StringLength(4000)]
        public string Resource_Status { get; set; }

        [Column("Resource Status Detail")]
        [StringLength(4000)]
        public string Resource_Status_Detail { get; set; }

        [Column("Risks Status")]
        [StringLength(4000)]
        public string Risks_Status { get; set; }

        [Column("Risks Status Detail")]
        [StringLength(4000)]
        public string Risks_Status_Detail { get; set; }

        [Column("Schedule Status")]
        [StringLength(4000)]
        public string Schedule_Status { get; set; }

        [Column("Schedule Status Details")]
        [StringLength(4000)]
        public string Schedule_Status_Details { get; set; }

        [Column("Scope Status")]
        [StringLength(4000)]
        public string Scope_Status { get; set; }

        [Column("Scope Status Details")]
        [StringLength(4000)]
        public string Scope_Status_Details { get; set; }

        [Column("State of Project")]
        [StringLength(4000)]
        public string State_of_Project { get; set; }

        [StringLength(4000)]
        public string Phase { get; set; }

        [StringLength(4000)]
        public string Program { get; set; }

        [StringLength(4000)]
        public string Organization { get; set; }

        [StringLength(4000)]
        public string Portfolio { get; set; }

        [Column("Portfolio Domain")]
        [StringLength(4000)]
        public string Portfolio_Domain { get; set; }

        [Column("Portfolio Service")]
        [StringLength(4000)]
        public string Portfolio_Service { get; set; }

        [Column("Primary Service")]
        [StringLength(4000)]
        public string Primary_Service { get; set; }

        [StringLength(4000)]
        public string Billing { get; set; }

        [StringLength(4000)]
        public string Methodology { get; set; }
    }
}
