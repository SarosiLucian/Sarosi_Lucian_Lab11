using System.Threading.Tasks;
using Sarosi_Lucian_Lab11.Models;

namespace Sarosi_Lucian_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
