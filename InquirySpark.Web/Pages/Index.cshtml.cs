using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;

namespace InquirySpark.Web.Pages
{

    public class ApiPageModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiPageModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        // Public method to get an HttpClient instance.
        public HttpClient GetApiClient()
        {
            return _httpClientFactory.CreateClient();
        }
    }

    public class IndexModel : ApiPageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory factory): base(factory)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            var _client = GetApiClient();
            InquirySparkAPIClient client = new InquirySparkAPIClient(_client);
            var result = await client.GetApplicationCollectionAsync();
            ViewData["Applications"] = result;

        }
    }
}
