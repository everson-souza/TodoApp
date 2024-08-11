using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    [ApiController]
    [Route("[controller]")]
    public class Todo
    {

        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public Boolean Completed { get; set; }
        public DateTime Deadline { get; set; }
        
    }
}
