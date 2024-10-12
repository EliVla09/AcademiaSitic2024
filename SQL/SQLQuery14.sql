--ENROLLMENT UPDATE
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[Enrollments].[Update]') AND
type in (N'P', N'PC'))
BEGIN
  DROP PROCEDURE [Enrollments].[Update]
END
GO
CREATE PROCEDURE [Enrollments].[Update]
	@EnrollmentId     INT OUTPUT,  
    @CourseId         INT,
    @EnrollmentDate   DATE OUTPUT,
    @StudentId INT

AS
BEGIN
	UPDATE Enrollments
	SET EnrollmentId =		@EnrollmentId,  
    CourseId=				@CourseId ,        
    EnrollmentDate =		@EnrollmentDate,
    StudentId=				@StudentId

	WHERE EnrollmentId = @EnrollmentId

	SET @EnrollmentId = SCOPE_IDENTITY()
END
GO 
EXEC sp_recompile N'[Enrollments].[Update]'
