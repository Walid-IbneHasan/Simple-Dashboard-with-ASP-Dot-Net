using Microsoft.AspNetCore.Mvc;
using Simple_Dashboard_with_ASP_Dot_Net.Models;
using System.Collections.Generic;

namespace Simple_Dashboard_with_ASP_Dot_Net.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var inventories = new List<Inventory>
            {
                new Inventory { Id = 1, Name = "Laptop", Description = "Dell XPS 13" },
                new Inventory { Id = 2, Name = "Monitor", Description = "Dell UltraSharp" }
            };

            var members = new List<Member>
            {
                new Member { Id = 1, Name = "John Doe", Email = "john@example.com" },
                new Member { Id = 2, Name = "Jane Smith", Email = "jane@example.com" }
            };

            var assignments = new List<InventoryAssignment>
            {
                new InventoryAssignment { InventoryId = 1, MemberId = 1 },
                new InventoryAssignment { InventoryId = 2, MemberId = 2 }
            };

            var model = new DashboardViewModel
            {
                Inventories = inventories,
                Members = members,
                Assignments = assignments
            };

            return View(model);
        }
    }
}
