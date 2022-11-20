using System.ComponentModel.DataAnnotations;

namespace InvoiceSystem.Models
{
    public class IssueItems
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemQuantity { get; set; }
        public string ItemPrice { get; set; }
    }
}
