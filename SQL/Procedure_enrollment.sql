--procedure Enrollments
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[Enrollments].[Insert]') AND
type in (N'P', N'PC'))
BEGIN
  DROP PROCEDURE Enrollments.[Insert]
END
GO
CREATE PROCEDURE Enrollments.[Insert]
	@EnrollmentId     INT OUTPUT,  
    @CourseId         INT,
    @EnrollmentDate   DATE OUTPUT,
    @StudentId INT

WITH ENCRYPTION
AS
BEGIN
	INSERT INTO Enrollments(EnrollmentId,CourseId,EnrollmentDate,StudentId )
	VALUES(@EnrollmentId,@CourseId,@EnrollmentDate,@StudentId)

	SET @EnrollmentId = SCOPE_IDENTITY()
END
GO 
EXEC sp_recompile N'[Enrollments].[Insert]'