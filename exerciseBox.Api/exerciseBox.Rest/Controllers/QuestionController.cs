﻿using exerciseBox.Application.Abtraction.Models;
using exerciseBox.Application.Services;
using exerciseBox.Application.Services.Interface;
using exerciseBox.Application.UseCases.Questions.Commands;
using exerciseBox.Application.UseCases.Questions.Queries;
using exerciseBox.Rest.Controllers.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace exerciseBox.Rest.Controllers
{
   
    public class QuestionController: BaseController
    {
        public QuestionController(IMediator mediator) : base(mediator)
        {
            
        }
        [HttpPost("saveQuestionToFolder")]
        public async Task<IActionResult> SaveQuestionToFolder([FromBody] SaveQuestionToFolderRequest request)
        {
            try
            {
                await _mediator.Send(
                    new SaveQuestionToFolder (
                        request.JunctionId.ToString(),request.FolderId,request.QuestionId
                        ));
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ein Problem ist aufgetreten. Hier müssen wir uns auf Messages einigen");
            }
        }
        [HttpPost("addQuestion")]
        public async Task<IActionResult> AddQuestion([FromBody] QuestionDto question)
        {
            try
                {
                //schulfach müssen noch vom lehrer profil kommen
                var validationContext = new ValidationContext(question);
                Validator.ValidateObject(question, validationContext);

                await _mediator.Send(new CreateQuestion { Question = question });
                return Ok();
            }
            catch (ValidationException ex)
            {
                return BadRequest($"Validierungsfehler: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ein Problem ist aufgetreten: {ex.Message}");

            }
        }
        [HttpGet("SearchQuestions")]
        public async Task<IActionResult> SearchQuestions([FromQuery] QuestionSearchParamsRequest parameters)
        {
            try
            {
               IEnumerable<QuestionDto> questions;
                //var questions = new Enumerable<QuestionDto>();
                //var questions = new List<QuestionDto>();
                if (!string.IsNullOrEmpty(parameters.Subject))
                {
                     questions = await _mediator.Send(new GetPublicQuestionsBySubject(parameters.Subject));
                }else
                {

                 questions = await _mediator.Send(new GetAllPublicQuestions());
                }
                var filteredQuestions = QuestionsFilter.Filter(questions, parameters);
                return Ok(filteredQuestions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ein Problem ist aufgetreten. Hier müssen wir uns auf Messages einigen");
            }
        }
        [HttpPut("hideQuestion")]
        public async Task<IActionResult> HideQuestion([FromBody] HideQuestionRequest request)
        {
            // Hier Logik zum Ausblenden der Frage basierend auf request.Days
            // Beispiel: this.questionService.HideQuestion(questionId, request.Days);
            bool isHidden = await _mediator.Send(new HideQuestionByTeacher (request.QuestionId , request.TeacherId));
            return Ok(new { message = "Frage erfolgreich ausgeblendet." });
        }

        [HttpGet("folderQuestions/{folderId}")]
        public async Task<IActionResult> GetFolderQuestions(string folderId)
        {
            try
            {
                var questions = await _mediator.Send(new GetFolderQuestions { FolderId = folderId });
                return Ok(new {value = questions});
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ein Problem ist aufgetreten. Hier müssen wir uns auf Messages einigen");
            }
        }
    }
}
