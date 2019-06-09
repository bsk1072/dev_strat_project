using System.ComponentModel.DataAnnotations;

namespace dotnetHelloWorld.Models
{
    public class Visitor
    {
		//testing the branching strategy in git - by developer 1
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}