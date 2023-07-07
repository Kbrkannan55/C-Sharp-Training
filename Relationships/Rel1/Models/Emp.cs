using System;
using System.Collections.Generic;

namespace Rel1.Models;

public partial class Emp
{
    public int Empid { get; set; }

    public string Empname { get; set; } = null!;

    public int? Deptno { get; set; }

    public virtual Dept? DeptnoNavigation { get; set; }
}
