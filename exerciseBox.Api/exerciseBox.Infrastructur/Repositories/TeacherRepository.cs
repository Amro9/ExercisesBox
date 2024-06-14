﻿using exerciseBox.Application.Abtraction.Repositories;
using exerciseBox.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace exerciseBox.Infrastructur.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly ExercisesBoxContext _context;

    public TeacherRepository(ExercisesBoxContext context)
    {
        _context = context;
    }

    public async Task<Teachers> Create(Teachers entity)
    {
        var teacher = await _context.Teachers.AddAsync(entity);
        await _context.SaveChangesAsync();
        return teacher.Entity;
    }

    public Task<Teachers> Delete(Teachers entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Teachers>> Read()
    {
        return await _context.Teachers.Include(x => x.SchoolNavigation).ThenInclude(x => x.SchoolTypeNavigation).ToListAsync();
    }

    public async Task<Teachers> ReadByEmailAsync(string email)
    {
        return await _context.Teachers.Include(x => x.SchoolNavigation).ThenInclude(x => x.SchoolTypeNavigation).FirstOrDefaultAsync(x => x.Email == email);
    }

    public Task<Teachers> ReadById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Teachers>> ReadBySchoolIdAsync(string schoolId)
    {
        return await _context.Teachers.Where(x => x.School == schoolId).ToListAsync();
    }

    public Task<Teachers> Update(Teachers entity)
    {
        throw new NotImplementedException();
    }
}
