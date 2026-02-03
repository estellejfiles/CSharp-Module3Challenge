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

            // Add your if-else statement here
            // 🦁 If hunger >= 8, set HungerMessage to "Lion: Roar! I need a big meal!"
            // 🐵 If hunger >= 5, set HungerMessage to "Monkey: Ooh ooh! I'll take some bananas."
            // 🐢 If hunger < 5, set HungerMessage to "Tortoise: Slow and steady—I'll have some lettuce."

            // Add your ternary operator here
            // If hungerLevel >= 8, set SoundMessage to "Listen to the Lion: Roar!"
            // Else, set SoundMessage to "Listen to the Monkey: Ooh ooh!"

            // Add your switch statement here
            // Use dayOfWeek to set DayMessage with a fun zoo event for each day
        }
    }
}