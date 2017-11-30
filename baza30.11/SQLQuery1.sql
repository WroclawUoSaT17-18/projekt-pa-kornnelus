alter procedure sp_Students_Insert
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
	insert into Students(Imie, Nazwisko, Plec, Email, [Adres], ImageUrl)
	values(@Imie, @Nazwisko, @Plec, @Email, @Adres, @ImageUrl)
	set @StudentID = SCOPE_IDENTITY()

