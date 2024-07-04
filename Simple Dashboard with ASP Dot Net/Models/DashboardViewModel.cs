namespace Simple_Dashboard_with_ASP_Dot_Net.Models
{
    public class DashboardViewModel
    {
        public List<Inventory> Inventories { get; set; }
        public List<Member> Members { get; set; }
        public List<InventoryAssignment> Assignments { get; set; }
    }
}
