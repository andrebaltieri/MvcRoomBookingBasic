using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcRoomBooking.Models
{
    public class Room
    {
        public int Id { get; set; }

        [DataType(DataType.Time, ErrorMessage = "Hora inválida")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time, ErrorMessage = "Hora inválida")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(60, ErrorMessage = "Este campo deve conter no máximo 60 caracteres")]
        public string Title { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}