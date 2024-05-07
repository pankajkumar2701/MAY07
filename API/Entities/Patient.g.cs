using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MAY07.Entities
{
#pragma warning disable
    /// <summary> 
    /// Represents a patient entity with essential details
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// TenantId of the Patient 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Patient 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// Code of the Patient 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// Name of the Patient 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// TitleId of the Patient 
        /// </summary>
        public Guid? TitleId { get; set; }
        /// <summary>
        /// FirstName of the Patient 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// MiddleName of the Patient 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the Patient 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// GenderId of the Patient 
        /// </summary>
        public Guid? GenderId { get; set; }
        /// <summary>
        /// Foreign key referencing the BloodGroup to which the Patient belongs 
        /// </summary>
        public Guid? BloodGroup { get; set; }

        /// <summary>
        /// Navigation property representing the associated BloodGroup
        /// </summary>
        [ForeignKey("BloodGroup")]
        public BloodGroup? BloodGroup_BloodGroup { get; set; }

        /// <summary>
        /// Dob of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Dob { get; set; }
        /// <summary>
        /// NationalIdNumber of the Patient 
        /// </summary>
        public string? NationalIdNumber { get; set; }

        /// <summary>
        /// RegisteredOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RegisteredOn { get; set; }

        /// <summary>
        /// DateOfDeath of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? DateOfDeath { get; set; }
        /// <summary>
        /// ReasonOfDeath of the Patient 
        /// </summary>
        public string? ReasonOfDeath { get; set; }
        /// <summary>
        /// IsDeceased of the Patient 
        /// </summary>
        public bool? IsDeceased { get; set; }
        /// <summary>
        /// ReferredBy of the Patient 
        /// </summary>
        public string? ReferredBy { get; set; }
        /// <summary>
        /// Mobile of the Patient 
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Email of the Patient 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// AddressId of the Patient 
        /// </summary>
        public Guid? AddressId { get; set; }

        /// <summary>
        /// LastVisitDate of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastVisitDate { get; set; }
        /// <summary>
        /// EntityCode of the Patient 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Patient 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// FileNumber of the Patient 
        /// </summary>
        public string? FileNumber { get; set; }
        /// <summary>
        /// CreatedBy of the Patient 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Patient 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// AlternateMobile of the Patient 
        /// </summary>
        public string? AlternateMobile { get; set; }
        /// <summary>
        /// IsDisabled of the Patient 
        /// </summary>
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// MobileNumberCountryCode of the Patient 
        /// </summary>
        public int? MobileNumberCountryCode { get; set; }
        /// <summary>
        /// AlternateNumberCountryCode of the Patient 
        /// </summary>
        public int? AlternateNumberCountryCode { get; set; }
        /// <summary>
        /// LocationId of the Patient 
        /// </summary>
        public Guid? LocationId { get; set; }
        /// <summary>
        /// PatientNotes of the Patient 
        /// </summary>
        public Guid? PatientNotes { get; set; }
        /// <summary>
        /// Import of the Patient 
        /// </summary>
        public bool? Import { get; set; }
        /// <summary>
        /// MembershipId of the Patient 
        /// </summary>
        public Guid? MembershipId { get; set; }
        /// <summary>
        /// PatientEnrollment of the Patient 
        /// </summary>
        public bool? PatientEnrollment { get; set; }

        /// <summary>
        /// EnrollmentDate of the Patient 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EnrollmentDate { get; set; }
        /// <summary>
        /// Landline of the Patient 
        /// </summary>
        public string? Landline { get; set; }
        /// <summary>
        /// IsVip of the Patient 
        /// </summary>
        public bool? IsVip { get; set; }
        /// <summary>
        /// IsConfidential of the Patient 
        /// </summary>
        public bool? IsConfidential { get; set; }
        /// <summary>
        /// PatientAllergy of the Patient 
        /// </summary>
        public Guid? PatientAllergy { get; set; }
        /// <summary>
        /// PatientStatistics of the Patient 
        /// </summary>
        public Guid? PatientStatistics { get; set; }
        /// <summary>
        /// PatientCategories of the Patient 
        /// </summary>
        public Guid? PatientCategories { get; set; }
        /// <summary>
        /// PatientComorbidities of the Patient 
        /// </summary>
        public Guid? PatientComorbidities { get; set; }
        /// <summary>
        /// ContactMembers of the Patient 
        /// </summary>
        public Guid? ContactMembers { get; set; }
        /// <summary>
        /// PatientPayors of the Patient 
        /// </summary>
        public Guid? PatientPayors { get; set; }
        /// <summary>
        /// PatientLifeStyle of the Patient 
        /// </summary>
        public Guid? PatientLifeStyle { get; set; }
        /// <summary>
        /// PatientEnrollmentLinks of the Patient 
        /// </summary>
        public Guid? PatientEnrollmentLinks { get; set; }
        /// <summary>
        /// PatientHospitalisationHistories of the Patient 
        /// </summary>
        public Guid? PatientHospitalisationHistories { get; set; }
        /// <summary>
        /// PregnancyHistories of the Patient 
        /// </summary>
        public Guid? PregnancyHistories { get; set; }
        /// <summary>
        /// PatientMedicalHistoryNotes of the Patient 
        /// </summary>
        public Guid? PatientMedicalHistoryNotes { get; set; }
        /// <summary>
        /// PatientPregnancies of the Patient 
        /// </summary>
        public Guid? PatientPregnancies { get; set; }
        /// <summary>
        /// AddressLine1 of the Patient 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Patient 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// StateId of the Patient 
        /// </summary>
        public Guid? StateId { get; set; }
        /// <summary>
        /// CityId of the Patient 
        /// </summary>
        public Guid? CityId { get; set; }
        /// <summary>
        /// PostalCode of the Patient 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// CountryId of the Patient 
        /// </summary>
        public Guid? CountryId { get; set; }
    }
}