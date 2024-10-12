IF EXISTS(SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[Courses].[Update]') AND
type in (N'P', N'PC'))
BEGIN
  DROP PROCEDURE [Courses].[Update]
END
GO
CREATE PROCEDURE [Courses].[Update]
	@CourseId       INT OUTPUT,
    @Name           VARCHAR(150),
    @Credits		INT

AS
BEGIN
	UPDATE Courses
	SET Name =		@Name,
	Credits =	@Credits
	WHERE CourseId = @CourseId

	SET @CourseId = SCOPE_IDENTITY()
END
GO 
EXEC sp_recompile N'[Courses].[Update]'