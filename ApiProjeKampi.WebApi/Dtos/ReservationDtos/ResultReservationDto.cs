namespace ApiProjeKampi.WebApi.Dtos.ReservationDtos
{
    public class ResultReservationDto
    {
        public int ReservationId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public int CountofPeople { get; set; }
        public string Message { get; set; }
        public string ReservationStatus { get; set; }
    }
}
