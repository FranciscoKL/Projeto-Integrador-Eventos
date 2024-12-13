using System.ComponentModel.DataAnnotations;

namespace Events.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [Display(Name="Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A Data é obrigatória.")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "O Local é obrigatório.")]
        [Display(Name = "Local")]
        public string Location { get; set; }
        [Required(ErrorMessage = "A Capacidade é obrigatória")]
        [Display(Name = "Capacidade")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "O Valor é obrigatório")]
        [Display(Name = "Preço")]
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







