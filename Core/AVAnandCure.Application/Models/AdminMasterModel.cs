using AVAnandCure.Domain.Entities;
using AVAnandCure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AVAnandCure.Application.Models
{
    #region Company Type

    public class CompanyType_Search : BaseSearchEntity
    {
    }

    public class CompanyType_Request : BaseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class CompanyType_Response : BaseResponseEntity
    {
        public string? CompanyType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Gender
    public class Gender_Search : BaseSearchEntity
    {
    }

    public class Gender_Request : BaseEntity
    {
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Gender_Response : BaseResponseEntity
    {
        public string? Gender { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Blood Group
    public class BloodGroup_Search : BaseSearchEntity
    {
    }

    public class BloodGroup_Request : BaseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BloodGroup_Response : BaseResponseEntity
    {
        public string? BloodGroup { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Marital Status

    public class MaritalStatus_Search : BaseSearchEntity
    {
    }

    public class MaritalStatus_Request : BaseEntity
    {
        public string? MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    public class MaritalStatus_Response : BaseResponseEntity
    {
        public string? MaritalStatus { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Product Category
    public class ProductCategory_Search : BaseSearchEntity
    {
    }

    public class ProductCategory_Request : BaseEntity
    {
        public string? ProductCategory { get; set; }
        public bool? IsActive { get; set; }
    }

    public class ProductCategory_Response : BaseResponseEntity
    {
        public string? ProductCategory { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Product
    public class Product_Search : BaseSearchEntity
    {
    }

    public class Product_Request : BaseEntity
    {
        public int? ProductCategoryId { get; set; }
        public string? ProductName { get; set; }
        public decimal? OriginalRate { get; set; }
        public decimal? SellingRate { get; set; }
        public int? OfferType { get; set; }
        public string? ProductDesc { get; set; }
        public string? ProductBenefits { get; set; }
        public string? Ingredients { get; set; }
        public string? DirectionForUsage { get; set; }
        public string? VideoLink { get; set; }

        [DefaultValue("")]
        public string? ProductImageOriginalFileName { get; set; }

        [DefaultValue("")]
        public string? ProductImageFileName { get; set; }

        [DefaultValue("")]
        public string? ProductImage_Base64 { get; set; }

        [DefaultValue("")]
        public string? ProductBannerOriginalFileName { get; set; }

        [DefaultValue("")]
        public string? ProductBannerFileName { get; set; }

        [DefaultValue("")]
        public string? ProductBanner_Base64 { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Product_Response : BaseResponseEntity
    {
        public int? ProductCategoryId { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductName { get; set; }
        public decimal? OriginalRate { get; set; }
        public decimal? SellingRate { get; set; }
        public int? OfferType { get; set; }
        public string? ProductDesc { get; set; }
        public string? ProductBenefits { get; set; }
        public string? Ingredients { get; set; }
        public string? DirectionForUsage { get; set; }
        public string? VideoLink { get; set; }
        public string? ProductImageOriginalFileName { get; set; }
        public string? ProductImageFileName { get; set; }
        public string? ProductImageUrl { get; set; }
        public string? ProductBannerOriginalFileName { get; set; }
        public string? ProductBannerFileName { get; set; }
        public string? ProductBannerUrl { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Billing Source
    public class BillingSource_Search : BaseSearchEntity
    {
    }

    public class BillingSource_Request : BaseEntity
    {
        public string? BillingSource { get; set; }
        public bool? IsActive { get; set; }
    }

    public class BillingSource_Response : BaseResponseEntity
    {
        public string? BillingSource { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Payment Mode
    public class PaymentMode_Search : BaseSearchEntity
    {
    }

    public class PaymentMode_Request : BaseEntity
    {
        public string? PaymentMode { get; set; }
        public bool? IsActive { get; set; }
    }

    public class PaymentMode_Response : BaseResponseEntity
    {
        public string? PaymentMode { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region User Type
    public class UserType_Search : BaseSearchEntity
    {
    }

    public class UserType_Request : BaseEntity
    {
        public string? UserType { get; set; }
        public bool? IsActive { get; set; }
    }

    public class UserType_Response : BaseResponseEntity
    {
        public string? UserType { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Godown
    public class Godown_Search : BaseSearchEntity
    {
    }

    public class Godown_Request : BaseEntity
    {
        public string? GodownNumber { get; set; }
        public string? GodownName { get; set; }
        public string? GAddress { get; set; }
        public int? StateId { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PinCode { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Godown_Response : BaseResponseEntity
    {
        public string? GodownNumber { get; set; }
        public string? GodownName { get; set; }
        public string? GAddress { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public int? CityId { get; set; }
        public string? CityName { get; set; }
        public string? PinCode { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region Relationship
    public class Relationship_Search : BaseSearchEntity
    {
    }

    public class Relationship_Request : BaseEntity
    {
        public string? Relationship { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Relationship_Response : BaseResponseEntity
    {
        public string? Relationship { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion
}
