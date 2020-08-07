using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Join = new HashSet<EngineerMachine>();
    }
    public int MachineId {get;set;}
    public string Name {get;set;}
    public virtual ICollection<EngineerMachine> Join {get;set;}
  }
}