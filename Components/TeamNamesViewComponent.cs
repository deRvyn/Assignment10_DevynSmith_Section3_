using Assignment10_DevynSmith_Section3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This returns the information for the navigation viewcompenent
namespace Assignment10_DevynSmith_Section3.Components
{
    public class TeamNamesViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamNamesViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            //gets the team name information to select it visually
            ViewBag.SelectedCategory = RouteData?.Values["teamname"];

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x)
                .ToList());
        }

    }
}
