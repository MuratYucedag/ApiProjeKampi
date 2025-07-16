namespace ApiProjeKampi.WebUI.Dtos.YummyEventDtos
{
    public class CreateYummyEventDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}
