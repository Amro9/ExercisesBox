﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Domain.Entities;

public partial class TeachersHiddenQuestions
{
    public string Id { get; set; }

    public string TeacherId { get; set; }

    public string QuestionId { get; set; }

    public virtual Questions Question { get; set; }

    public virtual Teachers Teacher { get; set; }
}