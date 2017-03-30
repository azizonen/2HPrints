using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XChange.Controllers
{
    [Route("api/auctions")]
    public class AuctionsController : Controller
    {
        [HttpGet("hot")]
        public IEnumerable<AuctionDTO> HotAuctions()
        {
            List<AuctionDTO> list = new List<AuctionDTO>();
            AuctionDTO data = new AuctionDTO();
            data.Active = true;
            data.Category = 1;
            data.City = "אשדוד";
            data.CreatedAt = DateTime.Today;
            data.Creator = "a5fj2n62kn32236mk";
            data.Description = "תיאור ניסיון";
            data.EndsAt = DateTime.Now;
            data.Image = "";
            data.MoneyGoal = 500;
            data.MoneyRaised = 300;
            data.MoneyStep = 10;
            data.Name = "הגרלת ניסיון";
            data.Subcategory = 5;

            list.Add(data);
            return list;
        }

        public class AuctionDTO
        {
            public bool Active;

            // Info
            public string Creator;
            public string Name;
            public string Description;
            public string Image;
            public string City;


            // Categories
            public int Category;
            public int Subcategory;
            public string[] tags;

            // Timestamps
            public DateTime CreatedAt;
            public DateTime EndsAt;

            // Money
            public int MoneyGoal;
            public int MoneyRaised;
            public int MoneyStep;
        }
    }
}
