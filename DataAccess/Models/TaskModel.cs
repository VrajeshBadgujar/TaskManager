using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class TaskModel
{
    public int Id{ get; set; }
    public string Assigner { get; set; }

    public string AssignedTo { get; set; }

    public string TypeOf { get; set; }

    public DateTime Initiation { get; set; }

    public DateTime Deadline { get; set; }

}
