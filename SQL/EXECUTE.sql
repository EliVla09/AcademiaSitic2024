DECLARE @StudentId INT,
		@CourseId INT,
		@EnrollmentId INT,
		@EnrollmentDate DATE = GETDATE()

EXEC [Students].[Insert] 'Mar�a Villase�or 2', '19960602', 'mar�a@sitic.com', @StudentId OUTPUT
EXEC [Courses].[Insert] 'Mate', 100, @CourseId OUTPUT
EXEC [Enrollments].[Insert] @StudentId, @CourseId, @EnrollmentDate, @EnrollmentId OUTPUT

SELECT * FROM Students
SELECT * FROM Courses
SELECT * FROM Enrollments