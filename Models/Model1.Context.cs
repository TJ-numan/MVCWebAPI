﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IMS_ASTHAEntities : DbContext
    {
        public IMS_ASTHAEntities()
            : base("name=IMS_ASTHAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adc_member_information> adc_member_information { get; set; }
        public virtual DbSet<adc_organization_setup> adc_organization_setup { get; set; }
        public virtual DbSet<adc_organization_wise_plan> adc_organization_wise_plan { get; set; }
        public virtual DbSet<adc_plan_wise_benefits> adc_plan_wise_benefits { get; set; }
        public virtual DbSet<adc_plan_wise_premium_info> adc_plan_wise_premium_info { get; set; }
        public virtual DbSet<astha_bahumatrik_collection_main> astha_bahumatrik_collection_main { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha> astha_bahumatrik_surokkha { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha_benefits> astha_bahumatrik_surokkha_benefits { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha_plan> astha_bahumatrik_surokkha_plan { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha_policy_document> astha_bahumatrik_surokkha_policy_document { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha_premium_collection> astha_bahumatrik_surokkha_premium_collection { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha_question> astha_bahumatrik_surokkha_question { get; set; }
        public virtual DbSet<astha_bahumatrik_surokkha_rate_chart> astha_bahumatrik_surokkha_rate_chart { get; set; }
        public virtual DbSet<bahumatrik_commission_generate> bahumatrik_commission_generate { get; set; }
        public virtual DbSet<bahumatrik_commission_payment> bahumatrik_commission_payment { get; set; }
        public virtual DbSet<bahumatrik_sms_send_history> bahumatrik_sms_send_history { get; set; }
        public virtual DbSet<claim_wise_gop_details> claim_wise_gop_details { get; set; }
        public virtual DbSet<comm_special> comm_special { get; set; }
        public virtual DbSet<common_sms> common_sms { get; set; }
        public virtual DbSet<gop_claim_refund_recovery> gop_claim_refund_recovery { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<policy_alt_attachment> policy_alt_attachment { get; set; }
        public virtual DbSet<sms_contact_list> sms_contact_list { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<t_leave_individual_leaves> t_leave_individual_leaves { get; set; }
        public virtual DbSet<t_leave_records> t_leave_records { get; set; }
        public virtual DbSet<t_leave_types> t_leave_types { get; set; }
        public virtual DbSet<t_leave_users> t_leave_users { get; set; }
        public virtual DbSet<t_leaves_bands> t_leaves_bands { get; set; }
        public virtual DbSet<t_leaves_departments> t_leaves_departments { get; set; }
        public virtual DbSet<t_leaves_designations> t_leaves_designations { get; set; }
        public virtual DbSet<t_leaves_holidays> t_leaves_holidays { get; set; }
        public virtual DbSet<tbl_account_type> tbl_account_type { get; set; }
        public virtual DbSet<tbl_attendance_remark> tbl_attendance_remark { get; set; }
        public virtual DbSet<tbl_benefit_categories> tbl_benefit_categories { get; set; }
        public virtual DbSet<tbl_benefit_types> tbl_benefit_types { get; set; }
        public virtual DbSet<tbl_blood_group> tbl_blood_group { get; set; }
        public virtual DbSet<tbl_bsb_claim> tbl_bsb_claim { get; set; }
        public virtual DbSet<tbl_bsb_claim_student_payment_schedule> tbl_bsb_claim_student_payment_schedule { get; set; }
        public virtual DbSet<tbl_bsb_member_info> tbl_bsb_member_info { get; set; }
        public virtual DbSet<tbl_bsb_nominee_details> tbl_bsb_nominee_details { get; set; }
        public virtual DbSet<tbl_child_care_benefits> tbl_child_care_benefits { get; set; }
        public virtual DbSet<tbl_claim_deduction_groups> tbl_claim_deduction_groups { get; set; }
        public virtual DbSet<tbl_claim_details_for_analysis> tbl_claim_details_for_analysis { get; set; }
        public virtual DbSet<tbl_claim_gops> tbl_claim_gops { get; set; }
        public virtual DbSet<tbl_claim_payment_bill_ref_no> tbl_claim_payment_bill_ref_no { get; set; }
        public virtual DbSet<tbl_claim_payment_ref_type> tbl_claim_payment_ref_type { get; set; }
        public virtual DbSet<tbl_claim_status> tbl_claim_status { get; set; }
        public virtual DbSet<tbl_claim_suplimentary_details> tbl_claim_suplimentary_details { get; set; }
        public virtual DbSet<tbl_claim_suplimentary_master> tbl_claim_suplimentary_master { get; set; }
        public virtual DbSet<tbl_claim_types> tbl_claim_types { get; set; }
        public virtual DbSet<tbl_claim_types_ilb> tbl_claim_types_ilb { get; set; }
        public virtual DbSet<tbl_claims_details> tbl_claims_details { get; set; }
        public virtual DbSet<tbl_claims_idra> tbl_claims_idra { get; set; }
        public virtual DbSet<tbl_claims_life_ci_other> tbl_claims_life_ci_other { get; set; }
        public virtual DbSet<tbl_collection_type> tbl_collection_type { get; set; }
        public virtual DbSet<tbl_dental_health_benefits> tbl_dental_health_benefits { get; set; }
        public virtual DbSet<tbl_equip_dept> tbl_equip_dept { get; set; }
        public virtual DbSet<tbl_equip_emi_collection> tbl_equip_emi_collection { get; set; }
        public virtual DbSet<tbl_equip_login_user> tbl_equip_login_user { get; set; }
        public virtual DbSet<tbl_equip_producer> tbl_equip_producer { get; set; }
        public virtual DbSet<tbl_equip_product_allocation> tbl_equip_product_allocation { get; set; }
        public virtual DbSet<tbl_equip_product_list> tbl_equip_product_list { get; set; }
        public virtual DbSet<tbl_group_benefit_schedule> tbl_group_benefit_schedule { get; set; }
        public virtual DbSet<tbl_group_bill_id> tbl_group_bill_id { get; set; }
        public virtual DbSet<tbl_group_collection> tbl_group_collection { get; set; }
        public virtual DbSet<tbl_group_health_premium_rate> tbl_group_health_premium_rate { get; set; }
        public virtual DbSet<tbl_group_life_premium_rate> tbl_group_life_premium_rate { get; set; }
        public virtual DbSet<tbl_group_member_bank_info_update_log> tbl_group_member_bank_info_update_log { get; set; }
        public virtual DbSet<tbl_group_premium_claim_summary> tbl_group_premium_claim_summary { get; set; }
        public virtual DbSet<tbl_health_benefit_types> tbl_health_benefit_types { get; set; }
        public virtual DbSet<tbl_hospital_bank_status> tbl_hospital_bank_status { get; set; }
        public virtual DbSet<tbl_hospital_banks> tbl_hospital_banks { get; set; }
        public virtual DbSet<tbl_hospital_benefit_types> tbl_hospital_benefit_types { get; set; }
        public virtual DbSet<tbl_hospital_benefits> tbl_hospital_benefits { get; set; }
        public virtual DbSet<tbl_hospital_cashless_status> tbl_hospital_cashless_status { get; set; }
        public virtual DbSet<tbl_hospital_contacts> tbl_hospital_contacts { get; set; }
        public virtual DbSet<tbl_hospital_status> tbl_hospital_status { get; set; }
        public virtual DbSet<tbl_hospitalization_health_benefits> tbl_hospitalization_health_benefits { get; set; }
        public virtual DbSet<tbl_hospitals> tbl_hospitals { get; set; }
        public virtual DbSet<tbl_hr_division_master> tbl_hr_division_master { get; set; }
        public virtual DbSet<tbl_hr_divisionwise_dept> tbl_hr_divisionwise_dept { get; set; }
        public virtual DbSet<tbl_hr_educational_info> tbl_hr_educational_info { get; set; }
        public virtual DbSet<tbl_hr_emp_address> tbl_hr_emp_address { get; set; }
        public virtual DbSet<tbl_hr_emp_hospital_doc> tbl_hr_emp_hospital_doc { get; set; }
        public virtual DbSet<tbl_hr_emp_info> tbl_hr_emp_info { get; set; }
        public virtual DbSet<tbl_hr_emp_prev_experience> tbl_hr_emp_prev_experience { get; set; }
        public virtual DbSet<tbl_hr_emp_reference> tbl_hr_emp_reference { get; set; }
        public virtual DbSet<tbl_hr_grades> tbl_hr_grades { get; set; }
        public virtual DbSet<tbl_hr_status> tbl_hr_status { get; set; }
        public virtual DbSet<tbl_hr_trainning_info> tbl_hr_trainning_info { get; set; }
        public virtual DbSet<tbl_ilb_ack_d> tbl_ilb_ack_d { get; set; }
        public virtual DbSet<tbl_ilb_address> tbl_ilb_address { get; set; }
        public virtual DbSet<tbl_ilb_adjusted_premium> tbl_ilb_adjusted_premium { get; set; }
        public virtual DbSet<tbl_ilb_age_proof> tbl_ilb_age_proof { get; set; }
        public virtual DbSet<tbl_ilb_bahumatrik_deed_delevery_details> tbl_ilb_bahumatrik_deed_delevery_details { get; set; }
        public virtual DbSet<tbl_ilb_bank_branch> tbl_ilb_bank_branch { get; set; }
        public virtual DbSet<tbl_ilb_bank_branch_master> tbl_ilb_bank_branch_master { get; set; }
        public virtual DbSet<tbl_ilb_bank_info> tbl_ilb_bank_info { get; set; }
        public virtual DbSet<tbl_ilb_bank_master> tbl_ilb_bank_master { get; set; }
        public virtual DbSet<tbl_ilb_banks> tbl_ilb_banks { get; set; }
        public virtual DbSet<tbl_ilb_bm_attach> tbl_ilb_bm_attach { get; set; }
        public virtual DbSet<tbl_ilb_business_closing_master> tbl_ilb_business_closing_master { get; set; }
        public virtual DbSet<tbl_ilb_child_info> tbl_ilb_child_info { get; set; }
        public virtual DbSet<tbl_ilb_ci_loding_update> tbl_ilb_ci_loding_update { get; set; }
        public virtual DbSet<tbl_ilb_ci_rate> tbl_ilb_ci_rate { get; set; }
        public virtual DbSet<tbl_ilb_claim_check_list> tbl_ilb_claim_check_list { get; set; }
        public virtual DbSet<tbl_ilb_claim_child_death_payment_schedule> tbl_ilb_claim_child_death_payment_schedule { get; set; }
        public virtual DbSet<tbl_ilb_claim_questions> tbl_ilb_claim_questions { get; set; }
        public virtual DbSet<tbl_ilb_collection_main> tbl_ilb_collection_main { get; set; }
        public virtual DbSet<tbl_ilb_com_deduction> tbl_ilb_com_deduction { get; set; }
        public virtual DbSet<tbl_ilb_com_deduction_temp> tbl_ilb_com_deduction_temp { get; set; }
        public virtual DbSet<tbl_ilb_com_fy_return_temp> tbl_ilb_com_fy_return_temp { get; set; }
        public virtual DbSet<tbl_ilb_com_fy_return_temp_2> tbl_ilb_com_fy_return_temp_2 { get; set; }
        public virtual DbSet<tbl_ilb_com_payment> tbl_ilb_com_payment { get; set; }
        public virtual DbSet<tbl_ilb_com_register_temp> tbl_ilb_com_register_temp { get; set; }
        public virtual DbSet<tbl_ilb_com_reserve_balance> tbl_ilb_com_reserve_balance { get; set; }
        public virtual DbSet<tbl_ilb_com_reserve_balance_temp> tbl_ilb_com_reserve_balance_temp { get; set; }
        public virtual DbSet<tbl_ilb_commission_register> tbl_ilb_commission_register { get; set; }
        public virtual DbSet<tbl_ilb_commission_schedule> tbl_ilb_commission_schedule { get; set; }
        public virtual DbSet<tbl_ilb_company_for_exp> tbl_ilb_company_for_exp { get; set; }
        public virtual DbSet<tbl_ilb_deed_delevery_details> tbl_ilb_deed_delevery_details { get; set; }
        public virtual DbSet<tbl_ilb_deed_delivery_status> tbl_ilb_deed_delivery_status { get; set; }
        public virtual DbSet<tbl_ilb_designation_for_exp> tbl_ilb_designation_for_exp { get; set; }
        public virtual DbSet<tbl_ilb_desigwise_targeted_policy_count> tbl_ilb_desigwise_targeted_policy_count { get; set; }
        public virtual DbSet<tbl_ilb_district> tbl_ilb_district { get; set; }
        public virtual DbSet<tbl_ilb_division> tbl_ilb_division { get; set; }
        public virtual DbSet<tbl_ilb_document_list> tbl_ilb_document_list { get; set; }
        public virtual DbSet<tbl_ilb_educational_subject> tbl_ilb_educational_subject { get; set; }
        public virtual DbSet<tbl_ilb_eft_deduction> tbl_ilb_eft_deduction { get; set; }
        public virtual DbSet<tbl_ilb_examination_list> tbl_ilb_examination_list { get; set; }
        public virtual DbSet<tbl_ilb_hi_claim_details_for_analysis> tbl_ilb_hi_claim_details_for_analysis { get; set; }
        public virtual DbSet<tbl_ilb_hi_coverage> tbl_ilb_hi_coverage { get; set; }
        public virtual DbSet<tbl_ilb_hi_due_update> tbl_ilb_hi_due_update { get; set; }
        public virtual DbSet<tbl_ilb_hi_plan> tbl_ilb_hi_plan { get; set; }
        public virtual DbSet<tbl_ilb_hi_planwise_benefits> tbl_ilb_hi_planwise_benefits { get; set; }
        public virtual DbSet<tbl_ilb_lpb_schedule> tbl_ilb_lpb_schedule { get; set; }
        public virtual DbSet<tbl_ilb_lpb_schedule_current> tbl_ilb_lpb_schedule_current { get; set; }
        public virtual DbSet<tbl_ilb_medical_bill_detail> tbl_ilb_medical_bill_detail { get; set; }
        public virtual DbSet<tbl_ilb_medical_bill_master> tbl_ilb_medical_bill_master { get; set; }
        public virtual DbSet<tbl_ilb_medical_diagonosis> tbl_ilb_medical_diagonosis { get; set; }
        public virtual DbSet<tbl_ilb_occupation> tbl_ilb_occupation { get; set; }
        public virtual DbSet<tbl_ilb_office_info> tbl_ilb_office_info { get; set; }
        public virtual DbSet<tbl_ilb_paidUp_policy_history> tbl_ilb_paidUp_policy_history { get; set; }
        public virtual DbSet<tbl_ilb_payment_type> tbl_ilb_payment_type { get; set; }
        public virtual DbSet<tbl_ilb_paymode> tbl_ilb_paymode { get; set; }
        public virtual DbSet<tbl_ilb_plan> tbl_ilb_plan { get; set; }
        public virtual DbSet<tbl_ilb_planwise_SB_benefits> tbl_ilb_planwise_SB_benefits { get; set; }
        public virtual DbSet<tbl_ilb_policy_child_info> tbl_ilb_policy_child_info { get; set; }
        public virtual DbSet<tbl_ilb_policy_comment> tbl_ilb_policy_comment { get; set; }
        public virtual DbSet<tbl_ilb_policy_document> tbl_ilb_policy_document { get; set; }
        public virtual DbSet<tbl_ilb_policy_family_history> tbl_ilb_policy_family_history { get; set; }
        public virtual DbSet<tbl_ilb_policy_lapse_revive> tbl_ilb_policy_lapse_revive { get; set; }
        public virtual DbSet<tbl_ilb_policy_lapse_revive_required_doc> tbl_ilb_policy_lapse_revive_required_doc { get; set; }
        public virtual DbSet<tbl_ilb_policy_payment> tbl_ilb_policy_payment { get; set; }
        public virtual DbSet<tbl_ilb_policy_question> tbl_ilb_policy_question { get; set; }
        public virtual DbSet<tbl_ilb_policy_SB_dis_voucher_counter> tbl_ilb_policy_SB_dis_voucher_counter { get; set; }
        public virtual DbSet<tbl_ilb_policy_SB_master> tbl_ilb_policy_SB_master { get; set; }
        public virtual DbSet<tbl_ilb_policy_surrender_info> tbl_ilb_policy_surrender_info { get; set; }
        public virtual DbSet<tbl_ilb_pr_type> tbl_ilb_pr_type { get; set; }
        public virtual DbSet<tbl_ilb_premium> tbl_ilb_premium { get; set; }
        public virtual DbSet<tbl_ilb_premium_collection> tbl_ilb_premium_collection { get; set; }
        public virtual DbSet<tbl_ilb_premium_collection_new> tbl_ilb_premium_collection_new { get; set; }
        public virtual DbSet<tbl_ilb_producer> tbl_ilb_producer { get; set; }
        public virtual DbSet<tbl_ilb_producer_attachment_dettachment> tbl_ilb_producer_attachment_dettachment { get; set; }
        public virtual DbSet<tbl_ilb_producer_deduction_master> tbl_ilb_producer_deduction_master { get; set; }
        public virtual DbSet<tbl_ilb_producer_dev_deduction_particular> tbl_ilb_producer_dev_deduction_particular { get; set; }
        public virtual DbSet<tbl_ilb_producer_file_attach> tbl_ilb_producer_file_attach { get; set; }
        public virtual DbSet<tbl_ilb_producer_info> tbl_ilb_producer_info { get; set; }
        public virtual DbSet<tbl_ilb_producer_other_payment_info> tbl_ilb_producer_other_payment_info { get; set; }
        public virtual DbSet<tbl_ilb_producer_other_payment_info_excel_duplicate_value> tbl_ilb_producer_other_payment_info_excel_duplicate_value { get; set; }
        public virtual DbSet<tbl_ilb_producer_other_payment_type> tbl_ilb_producer_other_payment_type { get; set; }
        public virtual DbSet<tbl_ilb_profile> tbl_ilb_profile { get; set; }
        public virtual DbSet<tbl_ilb_proposal_formno_entry> tbl_ilb_proposal_formno_entry { get; set; }
        public virtual DbSet<tbl_ilb_proposal_formno_info> tbl_ilb_proposal_formno_info { get; set; }
        public virtual DbSet<tbl_ilb_proposal_nominee> tbl_ilb_proposal_nominee { get; set; }
        public virtual DbSet<tbl_ilb_question_list> tbl_ilb_question_list { get; set; }
        public virtual DbSet<tbl_ilb_rate_chart> tbl_ilb_rate_chart { get; set; }
        public virtual DbSet<tbl_ilb_rider> tbl_ilb_rider { get; set; }
        public virtual DbSet<tbl_ilb_rider_rate> tbl_ilb_rider_rate { get; set; }
        public virtual DbSet<tbl_ilb_sms_policy> tbl_ilb_sms_policy { get; set; }
        public virtual DbSet<tbl_ilb_sms_pr> tbl_ilb_sms_pr { get; set; }
        public virtual DbSet<tbl_ilb_ssm_sm_asm> tbl_ilb_ssm_sm_asm { get; set; }
        public virtual DbSet<tbl_ilb_stamp_allocation> tbl_ilb_stamp_allocation { get; set; }
        public virtual DbSet<tbl_ilb_stamp_purchase_details> tbl_ilb_stamp_purchase_details { get; set; }
        public virtual DbSet<tbl_ilb_stamp_purchase_master> tbl_ilb_stamp_purchase_master { get; set; }
        public virtual DbSet<tbl_ilb_stamp_stock> tbl_ilb_stamp_stock { get; set; }
        public virtual DbSet<tbl_ilb_status> tbl_ilb_status { get; set; }
        public virtual DbSet<tbl_ilb_status_list> tbl_ilb_status_list { get; set; }
        public virtual DbSet<tbl_ilb_thana> tbl_ilb_thana { get; set; }
        public virtual DbSet<tbl_ilb_training_institute> tbl_ilb_training_institute { get; set; }
        public virtual DbSet<tbl_ilb_uchhco_shikkha_rate_chart> tbl_ilb_uchhco_shikkha_rate_chart { get; set; }
        public virtual DbSet<tbl_ilb_und_comment> tbl_ilb_und_comment { get; set; }
        public virtual DbSet<tbl_ilb_und_comment_details> tbl_ilb_und_comment_details { get; set; }
        public virtual DbSet<tbl_ilb_university_board> tbl_ilb_university_board { get; set; }
        public virtual DbSet<tbl_ilb_userid_info> tbl_ilb_userid_info { get; set; }
        public virtual DbSet<tbl_ilb_window_type> tbl_ilb_window_type { get; set; }
        public virtual DbSet<tbl_ilb_wp_rate> tbl_ilb_wp_rate { get; set; }
        public virtual DbSet<tbl_inv_bull_user> tbl_inv_bull_user { get; set; }
        public virtual DbSet<tbl_inv_catagory> tbl_inv_catagory { get; set; }
        public virtual DbSet<tbl_inv_details> tbl_inv_details { get; set; }
        public virtual DbSet<tbl_inv_details_test> tbl_inv_details_test { get; set; }
        public virtual DbSet<tbl_inv_item> tbl_inv_item { get; set; }
        public virtual DbSet<tbl_inv_requisition> tbl_inv_requisition { get; set; }
        public virtual DbSet<tbl_inv_requisition_main> tbl_inv_requisition_main { get; set; }
        public virtual DbSet<tbl_inv_stock> tbl_inv_stock { get; set; }
        public virtual DbSet<tbl_inv_sub_catagory> tbl_inv_sub_catagory { get; set; }
        public virtual DbSet<tbl_inv_transmission> tbl_inv_transmission { get; set; }
        public virtual DbSet<tbl_inv_unit> tbl_inv_unit { get; set; }
        public virtual DbSet<tbl_inv_user_allotment> tbl_inv_user_allotment { get; set; }
        public virtual DbSet<tbl_inv_user_signature> tbl_inv_user_signature { get; set; }
        public virtual DbSet<tbl_inv_vendor> tbl_inv_vendor { get; set; }
        public virtual DbSet<tbl_inv_vendor_cat> tbl_inv_vendor_cat { get; set; }
        public virtual DbSet<tbl_life_benefits> tbl_life_benefits { get; set; }
        public virtual DbSet<tbl_maritual_status> tbl_maritual_status { get; set; }
        public virtual DbSet<tbl_maternity_health_benefits> tbl_maternity_health_benefits { get; set; }
        public virtual DbSet<tbl_member_information> tbl_member_information { get; set; }
        public virtual DbSet<tbl_memberwise_premium_info> tbl_memberwise_premium_info { get; set; }
        public virtual DbSet<tbl_menu_control> tbl_menu_control { get; set; }
        public virtual DbSet<tbl_ocs_claim> tbl_ocs_claim { get; set; }
        public virtual DbSet<tbl_ocs_claim_attachment> tbl_ocs_claim_attachment { get; set; }
        public virtual DbSet<tbl_ocs_claim_attachment_temp> tbl_ocs_claim_attachment_temp { get; set; }
        public virtual DbSet<tbl_ocs_claim_details> tbl_ocs_claim_details { get; set; }
        public virtual DbSet<tbl_ocs_org_wise_file_attachment> tbl_ocs_org_wise_file_attachment { get; set; }
        public virtual DbSet<tbl_ocs_org_wise_file_attachment_temp> tbl_ocs_org_wise_file_attachment_temp { get; set; }
        public virtual DbSet<tbl_optical_health_benefits> tbl_optical_health_benefits { get; set; }
        public virtual DbSet<tbl_org_admin> tbl_org_admin { get; set; }
        public virtual DbSet<tbl_org_nature_of_business_info> tbl_org_nature_of_business_info { get; set; }
        public virtual DbSet<tbl_organization_banks> tbl_organization_banks { get; set; }
        public virtual DbSet<tbl_organization_booking> tbl_organization_booking { get; set; }
        public virtual DbSet<tbl_organization_contacts> tbl_organization_contacts { get; set; }
        public virtual DbSet<tbl_organizations> tbl_organizations { get; set; }
        public virtual DbSet<tbl_payable_tos> tbl_payable_tos { get; set; }
        public virtual DbSet<tbl_payment_proof_file> tbl_payment_proof_file { get; set; }
        public virtual DbSet<tbl_plan> tbl_plan { get; set; }
        public virtual DbSet<tbl_plan_benefits> tbl_plan_benefits { get; set; }
        public virtual DbSet<tbl_projects> tbl_projects { get; set; }
        public virtual DbSet<tbl_promoted_emp_initial_comm_return> tbl_promoted_emp_initial_comm_return { get; set; }
        public virtual DbSet<tbl_promoted_employee_list> tbl_promoted_employee_list { get; set; }
        public virtual DbSet<tbl_prospective_group_info> tbl_prospective_group_info { get; set; }
        public virtual DbSet<tbl_re_ins_ci_rate> tbl_re_ins_ci_rate { get; set; }
        public virtual DbSet<tbl_re_ins_life_rate> tbl_re_ins_life_rate { get; set; }
        public virtual DbSet<tbl_re_ins_pdab_diab_rate> tbl_re_ins_pdab_diab_rate { get; set; }
        public virtual DbSet<tbl_re_insurance_annuity> tbl_re_insurance_annuity { get; set; }
        public virtual DbSet<tbl_relation> tbl_relation { get; set; }
        public virtual DbSet<tbl_remote_desktop> tbl_remote_desktop { get; set; }
        public virtual DbSet<tbl_roles> tbl_roles { get; set; }
        public virtual DbSet<tbl_service_call_log_ilb> tbl_service_call_log_ilb { get; set; }
        public virtual DbSet<tbl_short_premium_adjusted_bm> tbl_short_premium_adjusted_bm { get; set; }
        public virtual DbSet<tbl_status> tbl_status { get; set; }
        public virtual DbSet<tbl_user_dep> tbl_user_dep { get; set; }
        public virtual DbSet<tbl_user_dep_privileged> tbl_user_dep_privileged { get; set; }
        public virtual DbSet<tbl_user_info> tbl_user_info { get; set; }
        public virtual DbSet<Third_Party_Token> Third_Party_Token { get; set; }
        public virtual DbSet<adc_claims> adc_claims { get; set; }
        public virtual DbSet<bahumatrik_comm_reserve_history> bahumatrik_comm_reserve_history { get; set; }
        public virtual DbSet<bahumatrik_commission_rate> bahumatrik_commission_rate { get; set; }
        public virtual DbSet<nominee_alt_attachment> nominee_alt_attachment { get; set; }
        public virtual DbSet<policy_bank_alt_attachment> policy_bank_alt_attachment { get; set; }
        public virtual DbSet<producer_fa_chain_alt_attachment> producer_fa_chain_alt_attachment { get; set; }
        public virtual DbSet<tbl_claim_categories> tbl_claim_categories { get; set; }
        public virtual DbSet<tbl_claim_charges> tbl_claim_charges { get; set; }
        public virtual DbSet<tbl_claim_projects> tbl_claim_projects { get; set; }
        public virtual DbSet<tbl_claims> tbl_claims { get; set; }
        public virtual DbSet<tbl_consultancy_rate_planwise> tbl_consultancy_rate_planwise { get; set; }
        public virtual DbSet<tbl_consultant_type> tbl_consultant_type { get; set; }
        public virtual DbSet<tbl_ilb_claim> tbl_ilb_claim { get; set; }
        public virtual DbSet<tbl_ilb_claim_stipend_closing_info> tbl_ilb_claim_stipend_closing_info { get; set; }
        public virtual DbSet<tbl_ilb_com_fy_deduction> tbl_ilb_com_fy_deduction { get; set; }
        public virtual DbSet<tbl_ilb_com_fy_return> tbl_ilb_com_fy_return { get; set; }
        public virtual DbSet<tbl_ilb_desig_wise_targeted_prem> tbl_ilb_desig_wise_targeted_prem { get; set; }
        public virtual DbSet<tbl_ilb_hi_claim> tbl_ilb_hi_claim { get; set; }
        public virtual DbSet<tbl_ilb_hi_claims_details> tbl_ilb_hi_claims_details { get; set; }
        public virtual DbSet<tbl_ilb_hi_rate> tbl_ilb_hi_rate { get; set; }
        public virtual DbSet<tbl_ilb_nominee_alt_history> tbl_ilb_nominee_alt_history { get; set; }
        public virtual DbSet<tbl_ilb_persistent_temp_02> tbl_ilb_persistent_temp_02 { get; set; }
        public virtual DbSet<tbl_ilb_policy_info> tbl_ilb_policy_info { get; set; }
        public virtual DbSet<tbl_ilb_policy_info_alter_history> tbl_ilb_policy_info_alter_history { get; set; }
        public virtual DbSet<tbl_ilb_policy_paid_up_remarks> tbl_ilb_policy_paid_up_remarks { get; set; }
        public virtual DbSet<tbl_ilb_premium_collection_with_no_reference> tbl_ilb_premium_collection_with_no_reference { get; set; }
        public virtual DbSet<tbl_ilb_tally> tbl_ilb_tally { get; set; }
        public virtual DbSet<tbl_ilb_training_info> tbl_ilb_training_info { get; set; }
        public virtual DbSet<tbl_opd_health_benefits> tbl_opd_health_benefits { get; set; }
    }
}
