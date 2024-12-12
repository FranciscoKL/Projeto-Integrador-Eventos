using System.ComponentModel.DataAnnotations;

namespace Events.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A Data é obrigatória.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "O Local é obrigatório.")]
        public string Location { get; set; }
        [Required(ErrorMessage = "A capacidade é obrigatória")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "O Valor é obrigatório")]
        public double Price { get; set; }
        public Event()
        {
        }
        public Event(int id, string name, DateTime date, string location, int capacity, double price)
        {
            Id = id;
            Name = name;
            Date = date;
            Location = location;
            Capacity = capacity;
            Price = price;
        }
    }
}







