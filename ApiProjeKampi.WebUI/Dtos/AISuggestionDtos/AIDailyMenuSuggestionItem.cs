namespace ApiProjeKampi.WebUI.Dtos.AISuggestionDtos
{
    public class AIDailyMenuSuggestionItem
    {
        public int ProductId { get; set; }   // Product ID
        public string Name { get; set; }     // Ürün adı
        public string Category { get; set; } // Kategori adı
        public decimal Price { get; set; }   // Fiyat
        public string Reason { get; set; }   // AI neden bunu seçti
    }
}
