using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace LottoQuickPicks.Pages
{
    public class LottoQuickPicksModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string? LottoType { get; set; } = "Lotto649";

        [BindProperty]
        public int QuickPicks { get; set; } = 3;

        //Define Properties that can be get from the page
        public string? InfoMessage { get; set; }
        public string ErrorMessage { get; set; }

        public List<int[]> QuickPickNumbers { get; private set; } = new();
        public void OnPostGenerateNumbers()
        {
            if(string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "<strong>Username</strong> is required and cannot be blank";
            }
            else
            {
                //Remove any QuickPicksNumbers
                QuickPickNumbers.Clear();
                //Create a Random object to generate random numbers
                Random rand = new();
                //Create a new array of int for each quick pick
                for(int quickCount = 1; quickCount <= QuickPicks; quickCount++)
                {
                    //Generate 6 numbers between 1 and 49 for lotto649
                    if(LottoType.ToUpper() == "LOTTO649")
                    {
                        int[] currentLottoQuickPicks = new int[6];
                        for(int count = 1; count <= 6; count++)
                        {
                            currentLottoQuickPicks[count - 1] = rand.Next(1, 50);
                        }
                        //Sort the contents of the array
                        Array.Sort(currentLottoQuickPicks);

                        //Loop to replace duplicate numbers
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = i + 1; j < 6; j++)
                            {
                                if (currentLottoQuickPicks[i] == currentLottoQuickPicks[j])
                                {
                                    currentLottoQuickPicks[j] = rand.Next(1, 50);
                                }
                            }
                        }

                        //Add the array of int to our list
                        QuickPickNumbers.Add(currentLottoQuickPicks);
                    }
                    //Generate 7 unique numbers between 1 and 50 for lottoMax
                }
                InfoMessage = $"Hello {Username}";
            }
        }
        public IActionResult OnPostClear()
        {
            Username = null;
            InfoMessage = null;
            ErrorMessage = null;
            return RedirectToPage();
        }
    }
}
