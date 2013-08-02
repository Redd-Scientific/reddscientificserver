using Quiz_Application.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_Application.Models
{
    public class QuestionsRepository
    {
        public static IEnumerable<Question> GetQuestions()
        {
            var myDB = new QuizAppDBEntities();
            var query = from q in myDB.Questions
                        select q;

            return query.ToList();
        }

        public static IEnumerable<Category> GetCategories()
        {
            var myDB = new QuizAppDBEntities();
            var query = from c in myDB.Categories
                        select c;
            return query.ToList();
        }

        public static void InsertQuestion(Question q)
        {
            var myDB = new QuizAppDBEntities();
            myDB.Questions.Add(q);
            myDB.SaveChanges();
        }


    }
}