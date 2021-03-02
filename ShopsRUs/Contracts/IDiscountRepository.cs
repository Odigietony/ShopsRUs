using ShopsRUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Contracts
{
    public interface IDiscountRepository
    {
        Task<IEnumerable<DiscountType>> GetAllDiscounts(bool trackChanges);
        Task<DiscountType> GetDiscountPercentageByType(string type, bool trackChanges);
        void CreateDiscountType(DiscountType discount);
        string DiscountPercentage(DiscountType discount);
    }
}
