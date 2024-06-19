﻿using exerciseBox.Application.Abtraction.Repositories;
using exerciseBox.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace exerciseBox.Infrastructur.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        private readonly ExercisesBoxContext _context;

        public TopicRepository(ExercisesBoxContext context)
        {
            _context = context;
        }
        public Task<Topics> CreateAsync(Topics entity)
        {
            throw new NotImplementedException();
        }

        public Task<Topics> DeleteAsync(Topics entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Topics>> ReadAsync()
        {
            return await _context.Topics.ToListAsync();
        }
        public async Task<IEnumerable<Topics>> ReadBySubject(string subject)
        {
            return await _context.Topics.Where(t => t.Subject == subject).Include(s =>s.SubjectNavigation).ToListAsync();
        }
        public Task<Topics> ReadByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Topics> UpdateAsync(Topics entity)
        {
            throw new NotImplementedException();
        }
    }
}
