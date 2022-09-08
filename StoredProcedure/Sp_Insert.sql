create PROCEDURE AddressBookInsert

@FirstName varchar(20),
@LastName varchar(20),
@Address varchar(100),
@City varchar (20),
@State varchar (20),
@Zip bigint,
@PhoneNumber bigint,
@Email varchar (50)


AS
SET XACT_ABORT ON;
SET NOCOUNT ON;
BEGIN
BEGIN TRY
BEGIN TRANSACTION;

SET NOCOUNT ON;
declare @new_identity int = 0
declare @result bit = 0;
Insert into AddressDetails (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values (@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email)
Commit Transaction
Set @result = 1;
return @result;
END TRY
Begin Catch

if(XACT_STATE()) = -1
 Begin
  Print
  'transaction is uncommitable' + 'rolling back transaction'
 ROLLBACK TRANSACTION;
 RETURN @result;
 End;
else if (XACT_STATE()) = 1
Begin
Print
'transaction is commitable' + 'commiting back transaction'
COMMIT TRANSACTION
set @result = 1;
return @result;
END
END Catch
END

SELECT * FROM Addressbook




