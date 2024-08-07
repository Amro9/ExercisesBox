﻿using exerciseBox.Application.Abtraction.Models;
using exerciseBox.Application.UseCases.DifficultyLevel.Queries;
using exerciseBox.Application.UseCases.Subject.Queries;
using exerciseBox.Application.UseCases.Topics.Queries;
using exerciseBox.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using exerciseBox.Application.Services.Interface;
using exerciseBox.Application.UseCases.SchoolLevels.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciseBox.Rest.Controllers
{
    /// <summary>
    /// Controller für Abfragen von Frageparametern.
    /// </summary>
    public class QuestionParametersController : BaseController
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="QuestionParametersController"/> Klasse.
        /// </summary>
        /// <param name="mediator">Der MediatR-Mediator.</param>
        public QuestionParametersController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Holt alle Fächer.
        /// </summary>
        /// <returns>Eine Liste von <see cref="SubjectDto"/> Objekten.</returns>
        [HttpGet("Subjects")]
        public async Task<IEnumerable<SubjectDto>> GetAllSubjects()
        {
            return await _mediator.Send(new GetAllSubjects());
        }

        /// <summary>
        /// Holt den Namen eines Faches anhand seiner ID.
        /// </summary>
        /// <param name="id">Die ID des Fachs.</param>
        /// <returns>Der Name des Fachs als Zeichenkette.</returns>
        [HttpGet("getSubjectNameById/{id}")]
        public async Task<string> GetSubjectNameById(string id)
        {
            var subject = await _mediator.Send(new GetSubjectById(id));
            return subject.Name;
        }

        /// <summary>
        /// Holt den Namen eines Faches anhand der Themen-ID.
        /// </summary>
        /// <param name="id">Die ID des Themas.</param>
        /// <returns>Der Name des Fachs als Zeichenkette.</returns>
        [HttpGet("getSubjectNameByTopic/{id}")]
        public async Task<string> GetSubjectNameByTopic(string id)
        {
            try
            {
                SubjectDto subject = await _mediator.Send(new GetSubjectByTopic(id));
                return subject.Name;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Holt ein Fach anhand der Themen-ID.
        /// </summary>
        /// <param name="id">Die ID des Themas.</param>
        /// <returns>Das Fach als <see cref="SubjectDto"/> Objekt.</returns>
        [HttpGet("getSubjectByTopic/{id}")]
        public async Task<SubjectDto> GetSubjectByTopic(string id)
        {
            try
            {
                SubjectDto subject = await _mediator.Send(new GetSubjectByTopic(id));
                return subject;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Holt alle Themen.
        /// </summary>
        /// <returns>Eine Liste von <see cref="TopicDto"/> Objekten.</returns>
        [HttpGet("Topics")]
        public async Task<IEnumerable<TopicDto>> GetAllTopics()
        {
            return await _mediator.Send(new GetAllTopics());
        }

        /// <summary>
        /// Holt den Namen eines Themas anhand seiner ID.
        /// </summary>
        /// <param name="id">Die ID des Themas.</param>
        /// <returns>Der Name des Themas als Zeichenkette.</returns>
        [HttpGet("getTopicNameById/{id}")]
        public async Task<string> GetTopicNameById(string id)
        {
            try
            {
                TopicDto topic = await _mediator.Send(new GetTopicById(id));
                return topic.Description;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Holt Themen anhand des Fachs.
        /// </summary>
        /// <param name="subject">Das Fach.</param>
        /// <returns>Eine Liste von <see cref="TopicDto"/> Objekten.</returns>
        [HttpGet("GetTopicBySubject/{subject}")]
        public async Task<IEnumerable<TopicDto>> GetTopicBySubject(string subject)
        {
            return await _mediator.Send(new GetTopicsBySubject(subject));
        }

        /// <summary>
        /// Holt Schulstufen anhand der Schulart-ID.
        /// </summary>
        /// <param name="schoolTypeId">Die ID der Schulart.</param>
        /// <returns>Eine sortierte Liste von Schulstufen als <see cref="IEnumerable{int}"/>.</returns>
        [HttpGet("GetSchoolLevelsBySchoolTypeId")]
        public async Task<IEnumerable<int>> GetSchoolLevelsBySchoolTypeId([FromQuery] int schoolTypeId)
        {
            var schoolLevels = await _mediator.Send(new GetSchoolLevelsBySchoolTypeId(schoolTypeId));
            return schoolLevels.OrderBy(level => level);
        }

        /// <summary>
        /// Holt Schulstufen anhand der Lehrer-ID.
        /// </summary>
        /// <param name="teacherId">Die ID des Lehrers.</param>
        /// <returns>Eine Liste von Schulstufen als <see cref="IEnumerable{int}"/>.</returns>
        [HttpGet("GetSchoolLevelsByTeacherId")]
        public async Task<IEnumerable<int>> GetSchoolLevelsByTeacherId([FromQuery] string teacherId)
        {
            var teacherLevels = await _mediator.Send(new GetSchoolLevelsByTeacherId(teacherId));
            return teacherLevels.OrderBy(level => level);
        }

        /// <summary>
        /// Holt alle Schwierigkeitsstufen.
        /// </summary>
        /// <returns>Eine Liste von <see cref="DifficultyLevelDto"/> Objekten.</returns>
        [HttpGet("GetDifficultyLevels")]
        public async Task<IEnumerable<DifficultyLevelDto>> GetDifficultyLevels()
        {
            return await _mediator.Send(new GetAllDifficultyLevels());
        }

        /// <summary>
        /// Holt eine Schwierigkeitsstufe anhand ihrer ID.
        /// </summary>
        /// <param name="id">Die ID der Schwierigkeitsstufe.</param>
        /// <returns>Die Schwierigkeitsstufe als <see cref="DifficultyLevelDto"/> Objekt.</returns>
        [HttpGet("GetDifficultyLevelById")]
        public async Task<DifficultyLevelDto> GetDifficultyLevelById([FromQuery] string id)
        {
            return await _mediator.Send(new GetDifficultyLevelById(id));
        }
    }
}
