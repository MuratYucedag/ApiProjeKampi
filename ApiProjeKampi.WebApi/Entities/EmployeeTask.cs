using System.ComponentModel.DataAnnotations;

namespace ApiProjeKampi.WebApi.Entities
{
    public class EmployeeTask
    {
        [Key]
        public int EmployeeTaskId { get; set; }
        public string TaskName { get; set; }
        public byte TaskStatusValue { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string TaskStatus { get; set; }

        // Many-to-many navigation
        public List<EmployeeTaskChef> EmployeeTaskChefs { get; set; }
    }
}
