using System.ComponentModel.DataAnnotations;

namespace InvoiceSystem.Models
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        public string IssueType { get; set; }
        public DateTime IssueDate { get; set; }
        public string CustName { get; set; }
    }
}
