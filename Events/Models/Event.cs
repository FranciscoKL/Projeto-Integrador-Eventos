using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public decimal Price { get; set; }

    }
}



//1.Sistema de Gestão de Eventos

//Descrição: Um sistema para gerenciar eventos como conferências, workshops, ou festas.

//Entidades principais:

//Evento: Nome, Data, Local, Capacidade Máxima, Preço.

//Participante: Nome, E-mail, Telefone, Tipo de Ingresso, Status de Pagamento.

//Organizador: Nome, Empresa, Contato, Email, CNPJ.


//Funcionalidades:

//Cadastro de eventos.

//Registro de participantes.

//Controle de lotação.
