﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Domain.Entities;

public partial class Topics
{
    public string Id { get; set; }

    public string Description { get; set; }

    public string Subject { get; set; }

    public virtual ICollection<ExerciseSheets> ExerciseSheets { get; set; } = new List<ExerciseSheets>();

    public virtual ICollection<Questions> Questions { get; set; } = new List<Questions>();

    public virtual Subjects SubjectNavigation { get; set; }
}