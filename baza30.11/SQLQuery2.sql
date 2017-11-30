alter procedure sp_Students_Update
(
	@StudentID int output,
	@Imie nvarchar(50),
	@Nazwisko nvarchar(50),
	@Plec bit,
	@Email varchar(50),
	@Adres nvarchar(250),
	@ImageUrl varchar(250)
)
as
    update Students set Imie = @Imie, Nazwisko = @Nazwisko, Email = @Email, Adres = @Adres, ImageUrl = @ImageUrl
	where StudentID = @StudentID