using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioApi.Controllers;
using System.Net.Http.Json;

namespace AntonioPortfolio.Pages.Sections
{
    public class PortfolioModel : PageModel
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public PortfolioModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<Project> Projects { get; private set; }

        public async Task OnGet()
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetAsync("https://localhost:7145/api/projects");

            response.EnsureSuccessStatusCode();

            Projects = await response.Content.ReadFromJsonAsync<List<Project>>();
        }

    }
}
