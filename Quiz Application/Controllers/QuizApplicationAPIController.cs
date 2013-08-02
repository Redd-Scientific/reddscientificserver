using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quiz_Application.Models;
using Quiz_Application.EFModels;

namespace Quiz_Application.Controllers
{
    public class QuizApplicationAPIController : ApiController
    {
        // GET api/quizapplicationapi
        public IEnumerable<Question> Get()
        {
            var questionRepository = QuestionsRepository.GetQuestions();
            return questionRepository;
        }


        // GET api/quizapplicationapi/5
        public Question Get(int id)
        {
            return QuestionsRepository.GetQuestions().Where((q) => q.QuestionID == id).FirstOrDefault();
        }

        // POST api/quizapplicationapi
        public HttpResponseMessage Post([FromBody]Question value)
        {
            QuestionsRepository.InsertQuestion(value);

            var response = Request.CreateResponse<Question>(HttpStatusCode.Created, value);

            string uri = Url.Link("DefaultApi", new { id = value.QuestionID });
            response.Headers.Location = new Uri(uri);

            return response;
        }

        /*// PUT api/quizapplicationapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/quizapplicationapi/5
        public void Delete(int id)
        {
        }*/


    }
}
