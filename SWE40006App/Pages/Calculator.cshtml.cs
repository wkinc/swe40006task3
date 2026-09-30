using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SWE40006App.Pages;

public class CalculatorModel : PageModel
{
    [BindProperty] public double A { get; set; }
    [BindProperty] public double B { get; set; }
    [BindProperty] public string Op { get; set; } = "+";
    public string? Result { get; set; }

    public void OnPost()
    {
        switch (Op)
        {
            case "+": Result = (A + B).ToString(); break;
            case "-": Result = (A - B).ToString(); break;
            case "*": Result = (A * B).ToString(); break;
            case "/":
                Result = B == 0 ? "Cannot divide by zero" : (A / B).ToString();
                break;
            default: Result = "Unknown operation"; break;
        }
    }
}