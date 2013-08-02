/// <reference path="../jquery-1.8.2.min.js" />
/// <reference path="../knockout-2.3.0.js" />

function question(id, text, ansa, ansb, ansc, ansd, correct, catid) {

    var self = this; 
    
    self.QuestionID = id;
    self.Question1 = text;
    self.AnswerA = ansa;
    self.AnswerB = ansb;
    self.AnswerC = ansc;
    self.AnswerD = ansd;
    self.Correct = correct;
    self.CategoryID = catid;

    self.addQuestion = function()
    {
        $.ajax({
            url: "/api/quizapplicationapi",
            type: 'post',
            data: ko.toJSON(this),
            contentType: 'application/json',
            success: function (result) {
                alert("successfully added");
            }
        });
    }
}

function questionViewModel() {
    var self = this;
    self.questions = ko.observableArray();
    self.getQuestions = function () {
        self.questions.removeAll();
        $.getJSON("/api/quizapplicationapi", function (data) {
            $.each(data, function (key,val) {
                self.questions.push(new question(val.QuestionID, val.Question1, val.AnswerA, val.AnswerB, val.AnswerC, val.AnswerD, val.Correct, val.CategoryID));
            });
        });
    }
}

$(document).ready(function () {
    ko.applyBindings(new questionViewModel(), document.getElementById('displayNode'));
    ko.applyBindings(new question(), document.getElementById('createNode'));
});
