using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MAY07.Entities
{
#pragma warning disable
    /// <summary> 
    /// Represents a doctor entity with essential details
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// TenantId of the Doctor 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Doctor 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// EntityCode of the Doctor 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Doctor 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// Name of the Doctor 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Code of the Doctor 
        /// </summary>
        public string? Code { get; set; }
        /// <summary>
        /// IsStandard of the Doctor 
        /// </summary>
        public bool? IsStandard { get; set; }

        /// <summary>
        /// Required field DateOfBirth of the Doctor 
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Foreign key referencing the BloodGroup to which the Doctor belongs 
        /// </summary>
        public Guid? BloodGroup { get; set; }

        /// <summary>
        /// Navigation property representing the associated BloodGroup
        /// </summary>
        [ForeignKey("BloodGroup")]
        public BloodGroup? BloodGroup_BloodGroup { get; set; }
        /// <summary>
        /// DobIsApproximate of the Doctor 
        /// </summary>
        public bool? DobIsApproximate { get; set; }
        /// <summary>
        /// TitleId of the Doctor 
        /// </summary>
        public Guid? TitleId { get; set; }

        /// <summary>
        /// Required field FirstName of the Doctor 
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// MiddleName of the Doctor 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the Doctor 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// OfficialAddressId of the Doctor 
        /// </summary>
        public Guid? OfficialAddressId { get; set; }
        /// <summary>
        /// TimezoneId of the Doctor 
        /// </summary>
        public string? TimezoneId { get; set; }
        /// <summary>
        /// LanguageId of the Doctor 
        /// </summary>
        public Guid? LanguageId { get; set; }
        /// <summary>
        /// GenderId of the Doctor 
        /// </summary>
        public Guid? GenderId { get; set; }
        /// <summary>
        /// NationalityId of the Doctor 
        /// </summary>
        public string? NationalityId { get; set; }
        /// <summary>
        /// MedicalRegistrationNumber of the Doctor 
        /// </summary>
        public string? MedicalRegistrationNumber { get; set; }
        /// <summary>
        /// Qualifications of the Doctor 
        /// </summary>
        public string? Qualifications { get; set; }
        /// <summary>
        /// Specialisations of the Doctor 
        /// </summary>
        public string? Specialisations { get; set; }
        /// <summary>
        /// ProfessionalMemberships of the Doctor 
        /// </summary>
        public string? ProfessionalMemberships { get; set; }
        /// <summary>
        /// CommunicationVerificationId of the Doctor 
        /// </summary>
        public string? CommunicationVerificationId { get; set; }
        /// <summary>
        /// AgeUnitId of the Doctor 
        /// </summary>
        public string? AgeUnitId { get; set; }
        /// <summary>
        /// Age of the Doctor 
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// Deleted of the Doctor 
        /// </summary>
        public bool? Deleted { get; set; }
        /// <summary>
        /// BankDetailCompleted of the Doctor 
        /// </summary>
        public bool? BankDetailCompleted { get; set; }
        /// <summary>
        /// SpecialityId of the Doctor 
        /// </summary>
        public string? SpecialityId { get; set; }
        /// <summary>
        /// CalendarSync of the Doctor 
        /// </summary>
        public bool? CalendarSync { get; set; }
        /// <summary>
        /// StaffCode of the Doctor 
        /// </summary>
        public string? StaffCode { get; set; }
        /// <summary>
        /// ZohoLeadId of the Doctor 
        /// </summary>
        public string? ZohoLeadId { get; set; }
        /// <summary>
        /// Notes of the Doctor 
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// AddressLine1 of the Doctor 
        /// </summary>
        public string? AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2 of the Doctor 
        /// </summary>
        public string? AddressLine2 { get; set; }
        /// <summary>
        /// StateId of the Doctor 
        /// </summary>
        public Guid? StateId { get; set; }
        /// <summary>
        /// CityId of the Doctor 
        /// </summary>
        public Guid? CityId { get; set; }
        /// <summary>
        /// PostalCode of the Doctor 
        /// </summary>
        public string? PostalCode { get; set; }
        /// <summary>
        /// CountryId of the Doctor 
        /// </summary>
        public Guid? CountryId { get; set; }
    }
}