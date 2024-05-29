﻿using exerciseBox.Domain.Entities;

namespace exerciseBox.Application.Abtraction.Repositories;

public interface ISchoolRepository : IRepository<Schools, Guid>
{
    Task<Schools> ReadByEmail(string email);
}
