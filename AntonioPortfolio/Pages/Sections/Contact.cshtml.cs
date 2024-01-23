using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;


namespace AntonioPortfolio.Pages.Sections
{

    public class ContactModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }

        public void OnGet()
        {
            // Handle GET request
        }

        public IActionResult OnPostSubmitForm()
        {
            if (!ModelState.IsValid)
            {
                // Validation failed, return to the page with validation errors
                return Page();
            }

            // Your logic for handling the form submission goes here
            // Display success message
            TempData["SuccessMessage"] = "Thank you for contacting me!";

            return RedirectToPage("Contact");
        }
    }


}

