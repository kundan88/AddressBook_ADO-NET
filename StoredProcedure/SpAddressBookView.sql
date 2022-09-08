CREATE PROCEDURE Sp_RetrieveData
(
@ID int,
@FirstName varchar (200),
@LastName varchar(150),
@ACity varchar(1),
@PhoneNumber varchar(10),
@Address varchar(50),
@Zip int,
@State varchar(20),
@NAME varchar(100),
@TYPE varchar(100)
)
	
AS
SET XACT_ABORT on;
SET NOCOUNT ON;
BEGIN
BEGIN TRY
BEGIN TRANSACTION;
	SET NOCOUNT ON;
	DECLARE @new_identity INTEGER = 0;
	DECLARE @result bit = 0;
	select * from Addressbook where Id=@id;
	SELECT @new_identity = @@IDENTITY;
	COMMIT TRANSACTION
	SET @result = 1;
	RETURN @result;
	END TRY
	BEGIN CATCH

	IF(XACT_STATE()) = -1
		BEGIN
		PRINT
		'Transaction is uncommitable' + ' Rolling back transaction'
		ROLLBACK TRANSACTION;
		RETURN @result;		
		END
	ELSE IF(XACT_STATE()) = 1
		BEGIN
		PRINT
		'Transaction is commitable' + ' Commiting back transaction'
		COMMIT TRANSACTION;
		SET @result = 1;
	    RETURN @result;
	END;
	END CATCH
END
GO

select * from Addressbook