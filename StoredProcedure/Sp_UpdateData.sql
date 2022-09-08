CREATE PROCEDURE AddressBookUpdate
@ID int,
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
-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
SET NOCOUNT ON;
  DECLARE @result bit = 0;
 
Update  AddressDetails set FirstName = @FirstName, LastName = @LastName, Address = @Address, City = @City, State = @State,
Zip = @Zip, PhoneNumber = @PhoneNumber, Email = @Email where ID = @ID;

COMMIT TRANSACTION;
END TRY
BEGIN CATCH
SELECT ERROR_NUMBER() as ErrorNumber, ERROR_MESSAGE() as ErrorMessage;
IF(XACT_STATE()) = -1
 BEGIN
  PRINT
  'transaction is uncommitable' + 'rolling back transaction'
  ROLLBACK TRANSACTION;
  END;
ELSE IF(XACT_STATE()) = 1
 BEGIN
  PRINT
   'transaction is commitable' + 'rolling back transaction'
   COMMIT TRANSACTION;
 END;
ELSE
 BEGIN
 PRINT
  'transaction is failed'
  ROLLBACK TRANSACTION;
  END;
END CATCH
END