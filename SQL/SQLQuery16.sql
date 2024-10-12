--Enrollment Get
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[Enrollments].[Get]') AND
type in (N'P', N'PC'))
BEGIN
  DROP PROCEDURE [Enrollments].[Get]
END
GO
CREATE PROCEDURE [Enrollments].[Get]
	@EnrollmentId		INT = NULL
AS
BEGIN
	SELECT EnrollmentId, StudentId, EnrollmentDate,CourseId
	FROM Enrollments Where @EnrollmentId IS  NULL OR (@EnrollmentId IS NOT NULL AND EnrollmentId= @EnrollmentId)
	
END
GO 
EXEC sp_recompile N'[Enrollments].[Get]'
EXEC [Enrollments].[Get] 1
