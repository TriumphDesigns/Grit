using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class EmployeeNote
    {
        [Key]
        public Guid NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Assigned Employee")]
        public Guid EID { get; set; }
        public Employee FullName { get; set; }
    }
}
