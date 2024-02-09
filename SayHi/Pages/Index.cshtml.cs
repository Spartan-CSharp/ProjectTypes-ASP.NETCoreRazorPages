using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SayHi.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public string FirstName
		{
			get; set;
		}

		[BindProperty]
		public string LastName
		{
			get; set;
		}

		[BindProperty]
		public string Greeting
		{
			get; set;
		}

		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			_logger.LogInformation("On GET Index Page, Index Model");
		}

		public IActionResult OnPost()
		{
			Greeting = $"Hi {FirstName} {LastName}!";
			_logger.LogInformation("On POST Index Page, Index Model, with Greeting = {Greeting}", Greeting);
			return Page();
		}
	}
}
