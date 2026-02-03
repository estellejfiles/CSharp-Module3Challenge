using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            // Get the values from the form
            int hungerLevel = int.Parse(Request.Form["hungerLevel"]);
            int dayOfWeek = int.Parse(Request.Form["dayOfWeek"]);

            // if-else statement to edit HungerMessage according to hungerLevel
            if (hungerLevel >= 8) {
                // 🦁 if hunger >= 8, set HungerMessage
                HungerMessage = "Lion: Roar! I need a big meal!";
            } else if (hungerLevel >=5) {
                // 🐵 if hunger >= 5, set HungerMessage
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
            } else {
                // 🐢 If hunger < 5, set HungerMessage
                HungerMessage = "Tortoise: Slow and steady—I'll have some lettuce.";
            } // end of if-else


            // ternery operator to edit SoundMessage according to hungerLevel
            // if hungerLevel >= 8, set SoundMessage to "Listen to the Lion: Roar!"
            // else, set SoundMessage to "Listen to the Monkey: Ooh ooh!"
            SoundMessage = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";


            // switch statement here to set DayMessage according to dayOfWeek
            switch (dayOfWeek)
            {   
                // according to what number dayOfWeek is, execute case statement
            
                // use default for case 1, as all other cases have been stated
                default:
                    
                    // include break to fall out of switch statement
                    break;


            } // end of switch statement


        } // end of method
    } // end of class
} // end of namespace