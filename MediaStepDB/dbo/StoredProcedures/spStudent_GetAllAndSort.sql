CREATE PROCEDURE [dbo].[spStudent_GetAllAndSort]
AS
BEGIN
	SELECT Id, FullName, DateOfBirth
	FROM dbo.[Student]
	WHERE Archived = 0
	ORDER BY DateOfBirth ASC
END
