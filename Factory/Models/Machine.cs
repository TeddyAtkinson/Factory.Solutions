using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    // properties, constructors, methods, etc. go here
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    public int MachineId { get; set; }
    public List<EngineerMachine> JoinEngineerMachine { get; }
  }
}