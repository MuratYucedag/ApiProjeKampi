namespace ApiProjeKampi.WebApi.Dtos.GroupReservationDtos
{
    public class GetGroupReservationByIdDto
    {
        public int GroupReservationId { get; set; }
        public string ResponsibleCustomerName { get; set; }
        public string GroupTitle { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime LastProcessDate { get; set; }
        public string Priority { get; set; }
        public string Details { get; set; }
        public string ReservationStatus { get; set; }
    }
}
