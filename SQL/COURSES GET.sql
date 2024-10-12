--COURSES GET
IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[Courses].[Get]') AND
type in (N'P', N'PC'))
BEGIN
  DROP PROCEDURE [Courses].[Get]
END
GO
CREATE PROCEDURE [Courses].[Get]
	@CourseId		INT = NULL
AS
BEGIN
	SELECT CourseId, Name, Credits
	FROM Courses Where @CourseId IS  NULL OR (@CourseId IS NOT NULL AND CourseId= @CourseId)
	
END
GO 
EXEC sp_recompile N'[Courses].[Get]'
EXEC [Courses].[Get] 1
