namespace DashBoardProject.Models.BOMSSPROD131
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BOMSSPROD131BscmDBContext : DbContext
    {
        public BOMSSPROD131BscmDBContext()
            : base("name=BOMSSPROD131BscmDBContext")
        {
        }

        public virtual DbSet<accumulated_stage_hours> accumulated_stage_hours { get; set; }
        public virtual DbSet<bams_folder_approvals> bams_folder_approvals { get; set; }
        public virtual DbSet<bams_folder_members> bams_folder_members { get; set; }
        public virtual DbSet<bams_lookup> bams_lookup { get; set; }
        public virtual DbSet<cms_stage_xref> cms_stage_xref { get; set; }
        public virtual DbSet<completed_tasks> completed_tasks { get; set; }
        public virtual DbSet<CQ_CreateChangeRequest> CQ_CreateChangeRequest { get; set; }
        public virtual DbSet<department_billto> department_billto { get; set; }
        public virtual DbSet<department_facility_xref> department_facility_xref { get; set; }
        public virtual DbSet<department_fsrb_xref> department_fsrb_xref { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<ERS_import_queue> ERS_import_queue { get; set; }
        public virtual DbSet<ERS_import_xref> ERS_import_xref { get; set; }
        public virtual DbSet<facility> facilities { get; set; }
        public virtual DbSet<factory_system_threshold_hist> factory_system_threshold_hist { get; set; }
        public virtual DbSet<factory_systems> factory_systems { get; set; }
        public virtual DbSet<folder_line_item> folder_line_item { get; set; }
        public virtual DbSet<fsrb_factory_system_xref> fsrb_factory_system_xref { get; set; }
        public virtual DbSet<fsrb_folder_priority> fsrb_folder_priority { get; set; }
        public virtual DbSet<fsrb_members> fsrb_members { get; set; }
        public virtual DbSet<fsrb> fsrbs { get; set; }
        public virtual DbSet<JIRA_CreateChangeRequest> JIRA_CreateChangeRequest { get; set; }
        public virtual DbSet<legacy_event> legacy_event { get; set; }
        public virtual DbSet<line_item> line_item { get; set; }
        public virtual DbSet<line_item_unit> line_item_unit { get; set; }
        public virtual DbSet<stage_help> stage_help { get; set; }
        public virtual DbSet<strategic_directives> strategic_directives { get; set; }
        public virtual DbSet<BAMS_CaseMgmt> BAMS_CaseMgmt { get; set; }
        public virtual DbSet<BAMS_CaseTsk> BAMS_CaseTsk { get; set; }
        public virtual DbSet<eFolder> eFolders { get; set; }
        public virtual DbSet<eFolderPage> eFolderPages { get; set; }
        public virtual DbSet<accumulated_actual_hours> accumulated_actual_hours { get; set; }
        public virtual DbSet<actual_hours_history> actual_hours_history { get; set; }
        public virtual DbSet<actual_hours_history_old> actual_hours_history_old { get; set; }
        public virtual DbSet<facility_cost_centers> facility_cost_centers { get; set; }
        public virtual DbSet<eFolderID> eFolderIDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<accumulated_stage_hours>()
                .Property(e => e.eFolderID)
                .IsUnicode(false);

            modelBuilder.Entity<accumulated_stage_hours>()
                .Property(e => e.total_hours)
                .HasPrecision(10, 2);

            modelBuilder.Entity<accumulated_stage_hours>()
                .Property(e => e.accumulated_hours)
                .HasPrecision(10, 2);

            modelBuilder.Entity<bams_folder_approvals>()
                .Property(e => e.folderID)
                .IsUnicode(false);

            modelBuilder.Entity<bams_folder_members>()
                .Property(e => e.folderID)
                .IsUnicode(false);

            modelBuilder.Entity<bams_folder_members>()
                .Property(e => e.lead)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bams_folder_members>()
                .Property(e => e.allowedToApprove)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<completed_tasks>()
                .Property(e => e.eFolderID)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.CQID)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.SubGroup)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.MicronSystem)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Submitter)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Headline)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.RBSponsor)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Contact_CCList)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.CustomerSeverity)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Keywords)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.Note_Entry)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.ReviewBoard)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.BillTo)
                .IsUnicode(false);

            modelBuilder.Entity<CQ_CreateChangeRequest>()
                .Property(e => e.LeadOverride)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<department_facility_xref>()
                .Property(e => e.require_approval)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<department_facility_xref>()
                .Property(e => e.supervisor_bypass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.active_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.require_triage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .HasMany(e => e.department_billto)
                .WithRequired(e => e.department1)
                .HasForeignKey(e => e.department);

            modelBuilder.Entity<department>()
                .HasMany(e => e.department_facility_xref)
                .WithRequired(e => e.department1)
                .HasForeignKey(e => e.department);

            modelBuilder.Entity<department>()
                .HasMany(e => e.department_fsrb_xref)
                .WithRequired(e => e.department1)
                .HasForeignKey(e => e.department);

            modelBuilder.Entity<department>()
                .HasMany(e => e.strategic_directives)
                .WithMany(e => e.departments)
                .Map(m => m.ToTable("department_directive_xref", "BAMS").MapLeftKey("department").MapRightKey("directive_id"));

            modelBuilder.Entity<ERS_import_queue>()
                .Property(e => e.full_request_id)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_queue>()
                .Property(e => e.ERS_facility_id)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_queue>()
                .Property(e => e.ERS_area_id)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_queue>()
                .Property(e => e.event_desc)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_queue>()
                .Property(e => e.import_status)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_xref>()
                .Property(e => e.ERS_facility_id)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_xref>()
                .Property(e => e.ERS_area_id)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_xref>()
                .Property(e => e.facility_id)
                .IsUnicode(false);

            modelBuilder.Entity<ERS_import_xref>()
                .Property(e => e.fsrb_name)
                .IsUnicode(false);

            modelBuilder.Entity<facility>()
                .HasMany(e => e.fsrb_members)
                .WithRequired(e => e.facility)
                .HasForeignKey(e => e.assigned_facility);

            modelBuilder.Entity<factory_systems>()
                .Property(e => e.active_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<folder_line_item>()
                .Property(e => e.folderID)
                .IsUnicode(false);

            modelBuilder.Entity<fsrb_members>()
                .Property(e => e.fsrb_lead)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fsrb_members>()
                .Property(e => e.allowed_to_approve)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fsrb>()
                .Property(e => e.active_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fsrb>()
                .Property(e => e.fsrbOverrideAging)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fsrb>()
                .Property(e => e.auto_route_hours_est)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<fsrb>()
                .HasMany(e => e.department_fsrb_xref)
                .WithRequired(e => e.fsrb)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fsrb>()
                .HasMany(e => e.fsrb_factory_system_xref)
                .WithRequired(e => e.fsrb)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fsrb>()
                .HasMany(e => e.fsrb_members)
                .WithRequired(e => e.fsrb)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.ProjectName)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.JIRA_Key)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.issueType)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Priority)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Submitter)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Watchlist)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Reporter)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.Assignee)
                .IsUnicode(false);

            modelBuilder.Entity<JIRA_CreateChangeRequest>()
                .Property(e => e.LeadOverride)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<legacy_event>()
                .Property(e => e.folderID)
                .IsUnicode(false);

            modelBuilder.Entity<line_item>()
                .Property(e => e.active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<line_item>()
                .HasMany(e => e.folder_line_item)
                .WithRequired(e => e.line_item)
                .HasForeignKey(e => e.item_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<line_item_unit>()
                .HasMany(e => e.line_item)
                .WithRequired(e => e.line_item_unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<stage_help>()
                .Property(e => e.stageHelpUrl)
                .IsUnicode(false);

            modelBuilder.Entity<strategic_directives>()
                .Property(e => e.active_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAMS_CaseMgmt>()
                .Property(e => e.EFOLDERID)
                .IsUnicode(false);

            modelBuilder.Entity<BAMS_CaseMgmt>()
                .Property(e => e.pCoreApprover)
                .IsUnicode(false);

            modelBuilder.Entity<BAMS_CaseTsk>()
                .Property(e => e.EFOLDERID)
                .IsUnicode(false);

            modelBuilder.Entity<eFolder>()
                .Property(e => e.eFolderID)
                .IsUnicode(false);

            modelBuilder.Entity<eFolder>()
                .Property(e => e.eParent)
                .IsUnicode(false);

            modelBuilder.Entity<eFolder>()
                .Property(e => e.eTotalCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<eFolder>()
                .Property(e => e.eTotalRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<eFolderPage>()
                .Property(e => e.eLocaleID)
                .IsUnicode(false);

            modelBuilder.Entity<accumulated_actual_hours>()
                .Property(e => e.eFolderID)
                .IsUnicode(false);

            modelBuilder.Entity<accumulated_actual_hours>()
                .Property(e => e.total_hours)
                .HasPrecision(38, 6);

            modelBuilder.Entity<actual_hours_history>()
                .Property(e => e.eFolderID)
                .IsUnicode(false);

            modelBuilder.Entity<actual_hours_history>()
                .Property(e => e.EstHours)
                .HasPrecision(10, 2);

            modelBuilder.Entity<actual_hours_history>()
                .Property(e => e.ActualHours)
                .HasPrecision(10, 2);

            modelBuilder.Entity<actual_hours_history_old>()
                .Property(e => e.eFolderID)
                .IsUnicode(false);

            modelBuilder.Entity<actual_hours_history_old>()
                .Property(e => e.ActualHours)
                .HasPrecision(10, 2);

            modelBuilder.Entity<facility_cost_centers>()
                .Property(e => e.cost_center_desc)
                .IsUnicode(false);
        }
    }
}
