﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Infrastructur.Models;

public partial class TeachersSubjectsJunction
{
    public string Id { get; set; }

    public string Teacher { get; set; }

    public string Subject { get; set; }

    public virtual Subject SubjectNavigation { get; set; }

    public virtual Teacher TeacherNavigation { get; set; }
}