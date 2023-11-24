using BrazilUniversities.Responses;
using Refit;

namespace BrazilUniversities.Gateways
{
    public interface IUniversityDomainsListApi
    {
        [Get("/search")]
        Task<IEnumerable<University>> GetUniversities([Query] string? country, [Query] int? offset, [Query] int? limit);
    }
}
