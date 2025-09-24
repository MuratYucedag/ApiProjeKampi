namespace ApiProjeKampi.WebApi.Entities
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<EmployeeTaskChef> EmployeeTaskChefs { get; set; }
    }
}