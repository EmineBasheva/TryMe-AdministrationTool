using System.Threading.Tasks;
using Admindesk;
using Grpc.Core;
using Google.Protobuf.Collections;

namespace AdminDesk_Server
{
    public class AdminDeskServer : Admindesk.AdminDesk.AdminDeskBase
    {
        public override Task<SubjectsReply> GetSubjects(IdRequest request, ServerCallContext context)
        {
            var subjects = new RepeatedField<SimpleObject>();
            subjects.Add(new SimpleObject() { Id = "02", Name = "Math" });
            subjects.Add(new SimpleObject() { Id = "05", Name = "History" });

            var reply = new SubjectsReply() { Subjects = { subjects } };
            return Task.FromResult(reply);
        }

        public override Task<ClassesReply> GetClasses(IdRequest request, ServerCallContext context)
        {
            var classes = new RepeatedField<SimpleObject>();
            classes.Add(new SimpleObject() { Id = "03", Name = "3 grade" });
            classes.Add(new SimpleObject() { Id = "06", Name = "6 grade" });

            var reply = new ClassesReply() { Classes = { classes } };
            return Task.FromResult(reply);
        }

        public override Task<TestNamesReply> GetTestNames(IdRequest request, ServerCallContext context)
        {
            var testNames = new RepeatedField<SimpleObject>();
            testNames.Add(new SimpleObject() { Id = "009", Name = "Some theme's name" });
            testNames.Add(new SimpleObject() { Id = "023", Name = "Other theme's name" });

            var reply = new TestNamesReply() { Themes = { testNames } };
            return Task.FromResult(reply);
        }

        public override Task<TestReply> GetTest(IdRequest request, ServerCallContext context)
        {
            var questions = new RepeatedField<Question>();
            var answers = new RepeatedField<Answer>();
            answers.Add(new Answer() { Text = "42", IsCorrect = true });
            answers.Add(new Answer() { Text = "not 42", IsCorrect = false });
            questions.Add(new Question() { Id = "01", Text = "What is ... ?", Answers = { answers } });
            questions.Add(new Question() { Id = "03", Text = "How is ... ?", Answers = { answers } });

            var reply = new TestReply() { Id = "009", Name = "Some theme's name", Questions = { questions } };
            return Task.FromResult(reply);
        }
    }
}
