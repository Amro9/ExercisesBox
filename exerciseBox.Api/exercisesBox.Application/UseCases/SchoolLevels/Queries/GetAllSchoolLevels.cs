﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseBox.Application.UseCases.SchoolLevels.Queries
{
    public class GetAllSchoolLevels: IRequest<IEnumerable<int>>
    {
    }
}