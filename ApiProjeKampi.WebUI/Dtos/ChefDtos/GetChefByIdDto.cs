namespace ApiProjeKampi.WebUI.Dtos.ChefDtos
{
    public class GetChefByIdDto
    {
        public int ChefId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
