﻿using exerciseBox.Application.Abtraction.Models;
using exerciseBox.Domain.Entities;

namespace exerciseBox.Application.Abtraction.Extensions
{
    public static class QuestionMappingExtension
    {
        public static IEnumerable<QuestionDto> MapToQuestionDto(IEnumerable<Questions> questions)
        {
            return questions.Select(q => new QuestionDto
            {
                Id = Guid.Parse(q.id),
                Content = q.content
            });
        }
        public static IEnumerable<Questions> MapToQuestions(IEnumerable<QuestionDto> questionsDto)
        {
            return questionsDto.Select(q => new Questions
            {
               id = q.Id.ToString(),
                content = q.Content
            });
        }
    }
}