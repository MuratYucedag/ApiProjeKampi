namespace ApiProjeKampi.WebUI.Dtos.AISuggestionDtos
{
    public class MenuSuggestionDto
    {
        public string Cuisine { get; set; }
        public string MenuTitle { get; set; }
        public string CountryCode { get; set; }
        public List<MenuItemDto> Items { get; set; }
    }
}
