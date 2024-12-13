using System.ComponentModel.DataAnnotations;

namespace Events.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória.")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [Display(Name = "Local")]
        public string Location { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        [Display(Name = "Capacidade")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
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







