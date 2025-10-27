using AVAnandCure.Domain.Entities;
using AVAnandCure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVAnandCure.Application.Models
{
    public class ContactDetails_Request : BaseEntity
    {
        public int? RefId { get; set; }

        [DefaultValue("Customer")]
        public string? RefType { get; set; }
        public string? ContactPerson { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public string? RefParty { get; set; }

        [DefaultValue("")]
        public string? FBCardOriginalFileName { get; set; }

        [DefaultValue("")]
        public string? FBCardFileName { get; set; }

        [DefaultValue("")]
        public string? FBCard_Base64 { get; set; }

        [DefaultValue("")]
        public string? BBCardOriginalFileName { get; set; }

        [DefaultValue("")]
        public string? BBCardFileName { get; set; }

        [DefaultValue("")]
        public string? BBCard_Base64 { get; set; }

        [DefaultValue(false)]
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
    }
    public class ContactDetails_Search : BaseSearchEntity
    {
        [DefaultValue(0)]
        public int RefId { get; set; }

        [DefaultValue("Patient")]
        public string? RefType { get; set; }
    }
    public class ContactDetails_Response : BaseEntity
    {
        public int? RefId { get; set; }

        [DefaultValue("Patient")]
        public string? RefType { get; set; }
        public string? ContactPerson { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public string? RefParty { get; set; }
        public string? FBCardOriginalFileName { get; set; }
        public string? FBCardFileName { get; set; }
        public string? FBCardUrl { get; set; }
        public string? BBCardOriginalFileName { get; set; }
        public string? BBCardFileName { get; set; }
        public string? BBCardUrl { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
    }
}
