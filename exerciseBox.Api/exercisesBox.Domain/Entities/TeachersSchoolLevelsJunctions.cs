﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Domain.Entities;

public partial class TeachersSchoolLevelsJunctions
{
    public string id { get; set; }

    public string teacher { get; set; }

    public int schoolLevel { get; set; }

    public virtual SchoolLevels schoolLevelNavigation { get; set; }

    public virtual Teachers teacherNavigation { get; set; }
}