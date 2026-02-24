using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class addDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choice_Question_QuestionId",
                table: "Choice");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructor_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Courses_CourseId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestion_Exam_ExamId",
                table: "ExamQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestion_Question_QuestionId",
                table: "ExamQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Instructor_InstructorId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswer_Choice_SelectedChoiceId",
                table: "StudentAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswer_Question_QuestionId",
                table: "StudentAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswer_StudentExam_StudentExamId",
                table: "StudentAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentExam_Exam_ExamId",
                table: "StudentExam");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentExam_Student_StudentId",
                table: "StudentExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAnswer",
                table: "StudentAnswer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamQuestion",
                table: "ExamQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exam",
                table: "Exam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Choice",
                table: "Choice");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "StudentAnswer",
                newName: "StudentAnswers");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "ExamQuestion",
                newName: "ExamQuestions");

            migrationBuilder.RenameTable(
                name: "Exam",
                newName: "Exams");

            migrationBuilder.RenameTable(
                name: "Choice",
                newName: "Choices");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAnswer_StudentExamId",
                table: "StudentAnswers",
                newName: "IX_StudentAnswers_StudentExamId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAnswer_SelectedChoiceId",
                table: "StudentAnswers",
                newName: "IX_StudentAnswers_SelectedChoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAnswer_QuestionId",
                table: "StudentAnswers",
                newName: "IX_StudentAnswers_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_InstructorId",
                table: "Questions",
                newName: "IX_Questions_InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestion_QuestionId",
                table: "ExamQuestions",
                newName: "IX_ExamQuestions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestion_ExamId",
                table: "ExamQuestions",
                newName: "IX_ExamQuestions_ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_CourseId",
                table: "Exams",
                newName: "IX_Exams_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Choice_QuestionId",
                table: "Choices",
                newName: "IX_Choices_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAnswers",
                table: "StudentAnswers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamQuestions",
                table: "ExamQuestions",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Choices",
                table: "Choices",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Questions_QuestionId",
                table: "Choices",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Exams_ExamId",
                table: "ExamQuestions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionId",
                table: "ExamQuestions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseId",
                table: "Exams",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Instructors_InstructorId",
                table: "Questions",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswers_Choices_SelectedChoiceId",
                table: "StudentAnswers",
                column: "SelectedChoiceId",
                principalTable: "Choices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswers_Questions_QuestionId",
                table: "StudentAnswers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswers_StudentExam_StudentExamId",
                table: "StudentAnswers",
                column: "StudentExamId",
                principalTable: "StudentExam",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentExam_Exams_ExamId",
                table: "StudentExam",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentExam_Students_StudentId",
                table: "StudentExam",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Questions_QuestionId",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Exams_ExamId",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionId",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Instructors_InstructorId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswers_Choices_SelectedChoiceId",
                table: "StudentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswers_Questions_QuestionId",
                table: "StudentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswers_StudentExam_StudentExamId",
                table: "StudentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentExam_Exams_ExamId",
                table: "StudentExam");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentExam_Students_StudentId",
                table: "StudentExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAnswers",
                table: "StudentAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamQuestions",
                table: "ExamQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Choices",
                table: "Choices");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "StudentAnswers",
                newName: "StudentAnswer");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "Exam");

            migrationBuilder.RenameTable(
                name: "ExamQuestions",
                newName: "ExamQuestion");

            migrationBuilder.RenameTable(
                name: "Choices",
                newName: "Choice");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAnswers_StudentExamId",
                table: "StudentAnswer",
                newName: "IX_StudentAnswer_StudentExamId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAnswers_SelectedChoiceId",
                table: "StudentAnswer",
                newName: "IX_StudentAnswer_SelectedChoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAnswers_QuestionId",
                table: "StudentAnswer",
                newName: "IX_StudentAnswer_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_InstructorId",
                table: "Question",
                newName: "IX_Question_InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_CourseId",
                table: "Exam",
                newName: "IX_Exam_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestions_QuestionId",
                table: "ExamQuestion",
                newName: "IX_ExamQuestion_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamQuestions_ExamId",
                table: "ExamQuestion",
                newName: "IX_ExamQuestion_ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Choices_QuestionId",
                table: "Choice",
                newName: "IX_Choice_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAnswer",
                table: "StudentAnswer",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exam",
                table: "Exam",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamQuestion",
                table: "ExamQuestion",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Choice",
                table: "Choice",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Choice_Question_QuestionId",
                table: "Choice",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructor_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Courses_CourseId",
                table: "Exam",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestion_Exam_ExamId",
                table: "ExamQuestion",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestion_Question_QuestionId",
                table: "ExamQuestion",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Instructor_InstructorId",
                table: "Question",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswer_Choice_SelectedChoiceId",
                table: "StudentAnswer",
                column: "SelectedChoiceId",
                principalTable: "Choice",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswer_Question_QuestionId",
                table: "StudentAnswer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswer_StudentExam_StudentExamId",
                table: "StudentAnswer",
                column: "StudentExamId",
                principalTable: "StudentExam",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentExam_Exam_ExamId",
                table: "StudentExam",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentExam_Student_StudentId",
                table: "StudentExam",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
