﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace exerciseBox.Infrastructur.Models;

public partial class QuestionDifficultyLevel
{
    public string Id { get; set; }

    public string Description { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}