//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quiz_Application.EFModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public Int16 QuestionID { get; set; }
        public string Question1 { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string Correct { get; set; }
        public Int16 CategoryID { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
