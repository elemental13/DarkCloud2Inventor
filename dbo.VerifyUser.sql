CREATE PROCEDURE [dbo].[AddUser]
	@user nvarchar(25),
	@pass nvarchar(25)
AS

if Exists (Select username from users where username = @user)
Begin
Print 'User Exists'
End
Else
Begin
	insert into users values(@user, @pass);
End

	
GO

