using AVAnandCure.Application.Models;
using AVAnandCure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVAnandCure.Application.Interfaces
{
    public interface IAdminMasterRepository
    {
        #region Company Type

        Task<int> SaveCompanyType(CompanyType_Request parameters);
        Task<IEnumerable<CompanyType_Response>> GetCompanyTypeList(CompanyType_Search parameters);
        Task<CompanyType_Response?> GetCompanyTypeById(long Id);

        #endregion

        #region Gender

        Task<int> SaveGender(Gender_Request parameters);
        Task<IEnumerable<Gender_Response>> GetGenderList(Gender_Search parameters);
        Task<Gender_Response?> GetGenderById(long Id);

        #endregion

        #region Blood Group

        Task<int> SaveBloodGroup(BloodGroup_Request parameters);
        Task<IEnumerable<BloodGroup_Response>> GetBloodGroupList(BloodGroup_Search parameters);
        Task<BloodGroup_Response?> GetBloodGroupById(long Id);

        #endregion

        #region Marital Status

        Task<int> SaveMaritalStatus(MaritalStatus_Request parameters);
        Task<IEnumerable<MaritalStatus_Response>> GetMaritalStatusList(MaritalStatus_Search parameters);
        Task<MaritalStatus_Response?> GetMaritalStatusById(long Id);

        #endregion

        #region Product Category
        Task<int> SaveProductCategory(ProductCategory_Request parameters);
        Task<IEnumerable<ProductCategory_Response>> GetProductCategoryList(ProductCategory_Search parameters);
        Task<ProductCategory_Response?> GetProductCategoryById(long Id);
        #endregion

        #region Product
        Task<int> SaveProduct(Product_Request parameters);
        Task<IEnumerable<Product_Response>> GetProductList(Product_Search parameters);
        Task<Product_Response?> GetProductById(long Id);
        #endregion

        #region Billing Source

        Task<int> SaveBillingSource(BillingSource_Request parameters);
        Task<IEnumerable<BillingSource_Response>> GetBillingSourceList(BillingSource_Search parameters);
        Task<BillingSource_Response?> GetBillingSourceById(long Id);

        #endregion

        #region Payment Mode

        Task<int> SavePaymentMode(PaymentMode_Request parameters);
        Task<IEnumerable<PaymentMode_Response>> GetPaymentModeList(PaymentMode_Search parameters);
        Task<PaymentMode_Response?> GetPaymentModeById(long Id);

        #endregion

        #region User Type

        Task<int> SaveUserType(UserType_Request parameters);
        Task<IEnumerable<UserType_Response>> GetUserTypeList(UserType_Search parameters);
        Task<UserType_Response?> GetUserTypeById(long Id);

        #endregion

        #region Godown

        Task<int> SaveGodown(Godown_Request parameters);
        Task<IEnumerable<Godown_Response>> GetGodownList(Godown_Search parameters);
        Task<Godown_Response?> GetGodownById(long Id);

        #endregion

        #region Relationship

        Task<int> SaveRelationship(Relationship_Request parameters);
        Task<IEnumerable<Relationship_Response>> GetRelationshipList(Relationship_Search parameters);
        Task<Relationship_Response?> GetRelationshipById(long Id);

        #endregion
    }
}
