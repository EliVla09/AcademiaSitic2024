IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[Courses].[Delete]') AND
type in (N'P', N'PC'))
BEGIN
  DROP PROCEDURE [Courses].[Delete]
END
GO
CREATE PROCEDURE [Courses].[Delete]
	@CourseId       INT 
AS
BEGIN
	DELETE Courses
	WHERE CourseId = @CourseId

	SET @CourseId = SCOPE_IDENTITY()
END
GO 
EXEC sp_recompile N'[Courses].[Delete]'