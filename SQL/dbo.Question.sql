CREATE TABLE [dbo].[Question] (
    [QuestionID] UNIQUEIDENTIFIER NOT NULL,
    [Question]   NVARCHAR (MAX)   NOT NULL,
    [AnswerA]    NVARCHAR (50)    NOT NULL,
    [AnswerB]    NVARCHAR (50)    NOT NULL,
    [AnswerC]    NVARCHAR (50)    NOT NULL,
    [AnswerD]    NVARCHAR (50)    NOT NULL,
    [Correct]    NCHAR (10)       NOT NULL, 
	[CategoryID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [Category]([CategoryID]), 
    CONSTRAINT [QuestionID] PRIMARY KEY ([QuestionID])
);

