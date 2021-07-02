using System;

namespace Domain.Entities
{
    public class Session
    {
        public int Id { get; set; }

        public int FilmId { get; set; }

        public int CinemaId { get; set; }

        public DateTime SessionDate { get; set; }
    }
}
