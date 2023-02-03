CREATE PROCEDURE [dbo].[spStudent_Insert]
	@FullName nvarchar(100),
	@DateOfBirth DATE
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM dbo.[Student] WHERE UPPER(FullName) = UPPER(@FullName))
	BEGIN
		INSERT INTO  dbo.[Student](FullName, DateOfBirth)
		VALUES(@FullName, @DateOfBirth)
	END
END
