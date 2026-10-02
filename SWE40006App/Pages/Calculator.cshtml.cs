using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SWE40006App.Pages;

public class CalculatorModel : PageModel
{
    [BindProperty] public double A { get; set; }
    [BindProperty] public double B { get; set; }
    [BindProperty] public string Op { get; set; } = "+";
    public string? Result { get; set; } // Stores the calculation result to display on the web page.

// Runs when the calculator form is submitted.
    public void OnPost()
    {
        switch (Op)
        {
            case "+": Result = (A + B).ToString(); break;
            case "-": Result = (A - B).ToString(); break;
            case "*": Result = (A * B).ToString(); break;
            case "/":
            // Prevents division by zero from causing an error invalid calculation
                Result = B == 0 ? "Cannot divide by zero" : (A / B).ToString();
                break;

            // Handles an operation that is not recognised.
            default: Result = "Unknown operation"; break;
        }
    }
}
