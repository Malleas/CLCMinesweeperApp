select * from Player

insert into dbo.Player(FirstName, LastName, Gender, Age, State, EmailAddress, Username, Password) VALUES('foo', 'bar', 'male', '23', 'TN', 'a@a.com', 'foo', 'bar')

select  rtrim(Username), 
rtrim(Password) from dbo.Player where USERNAME = 'foo'