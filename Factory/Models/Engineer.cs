using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    // properties, constructors, methods, etc. go here
    // [Required(ErrorMessage = "Name must be entered!")]
    public string Name { get; set; }
    // [Required(ErrorMessage = "You must enter a date.")]
    public int EngineerId { get; set; }
    public List<EngineerMachine> JoinEngineerMachine { get; } // collection navigation property
  }
}