﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Infrastructur.Models;

public partial class SchoolBranch
{
    public string Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<BranchSubjectJunction> BranchSubjectJunctions { get; set; } = new List<BranchSubjectJunction>();

    public virtual ICollection<SchoolsBranchesJunction> SchoolsBranchesJunctions { get; set; } = new List<SchoolsBranchesJunction>();
}