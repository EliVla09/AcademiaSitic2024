DECLARE @StudentId INT,
		@CourseId INT,
		@EnrollmentId INT,
		@EnrollmentDate DATE = GETDATE()

EXEC [Students].[Insert] 'María Villaseñor 2', '19960602', 'maría@sitic.com', @StudentId OUTPUT
EXEC [Courses].[Insert] 'Mate', 100, @CourseId OUTPUT
EXEC [Enrollments].[Insert] @StudentId, @CourseId, @EnrollmentDate, @EnrollmentId OUTPUT

SELECT * FROM Students
SELECT * FROM Courses
SELECT * FROM Enrollments