﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Domain.Entities;

public partial class Schools
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string SchoolType { get; set; }

    public virtual ICollection<SchoolsBranchesJunctions> SchoolsBranchesJunctions { get; set; } = new List<SchoolsBranchesJunctions>();

    public virtual ICollection<SchoolsLevelsJunctions> SchoolsLevelsJunctions { get; set; } = new List<SchoolsLevelsJunctions>();

    public virtual ICollection<SchoolsSubjectsJunctions> SchoolsSubjectsJunctions { get; set; } = new List<SchoolsSubjectsJunctions>();

    public virtual ICollection<Teachers> Teachers { get; set; } = new List<Teachers>();

    public virtual SchoolTypes SchoolTypeNavigation { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
}