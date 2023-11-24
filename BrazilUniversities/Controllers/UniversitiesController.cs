using BrazilUniversities.Responses;
using BrazilUniversities.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace BrazilUniversities.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniversitiesController : ControllerBase
    {
        private readonly IUniversityDomainsListApi _universityDomainsListApi;

        public UniversitiesController(
            IUniversityDomainsListApi universityDomainsListApi)
        {
            _universityDomainsListApi = universityDomainsListApi;
        }

        [HttpGet(Name = "Universities")]
        public Task<IEnumerable<University>> Get(string? country, int? offset, int? limit)
        {
            return _universityDomainsListApi.GetUniversities(country, offset, limit);
        }
    }
}