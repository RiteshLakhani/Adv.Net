create database Sem5

--Insert---
CREATE PROCEDURE [dbo].[InsertCountry]
    @CountryName VARCHAR(100),
    @CountryCode VARCHAR(3)
AS
BEGIN
    INSERT INTO [dbo].[Country] (CountryName, CountryCode)
    VALUES (@CountryName, @CountryCode);
    PRINT 'Inserted country: ' + @CountryName + ' (' + @CountryCode + ')';
END;


--exe--
EXEC [dbo].[InsertCountry] @CountryName = 'India', @CountryCode = 'In';
EXEC [dbo].[InsertCountry] @CountryName = 'Japan', @CountryCode = 'JPN';
EXEC [dbo].[InsertCountry] @CountryName = 'Mexico', @CountryCode = 'MEX';
EXEC [dbo].[InsertCountry] @CountryName = 'South Africa', @CountryCode = 'SA';
EXEC [dbo].[InsertCountry] @CountryName = 'United State', @CountryCode = 'US';

Select * from [dbo].[Country]



---For Update Procedure-----
CREATE PROCEDURE [dbo].[UpdateCountryCode]
    @CountryName VARCHAR(100),
    @NewCountryCode VARCHAR(3)
AS
BEGIN
    UPDATE [dbo].[Country]
    SET CountryCode = @NewCountryCode
    WHERE CountryName = @CountryName;

    IF @@ROWCOUNT > 0
    BEGIN
        PRINT 'Updated CountryCode for ' + @CountryName + ' to ' + @NewCountryCode;
    END
    ELSE
    BEGIN
        PRINT 'No country found with Name: ' + @CountryName;
    END
END;

--exec
EXEC [dbo].[UpdateCountryCode] @CountryName = 'United States', @NewCountryCode = 'USA';
Select * from [dbo].[Country]



--delete
CREATE PROCEDURE [dbo].[DeleteCountryByName]
    @CountryName VARCHAR(100)
AS
BEGIN
    DELETE FROM [dbo].[Country]
    WHERE CountryName = @CountryName;

    IF @@ROWCOUNT > 0
    BEGIN
        PRINT 'Deleted country: ' + @CountryName;
    END
    ELSE
    BEGIN
        PRINT 'No country found with Name: ' + @CountryName;
    END
END;

--EXE
EXEC [dbo].[DeleteCountryByName] @CountryName = 'Germany';
EXEC [dbo].[DeleteCountryByName] @CountryName = 'Australia';
EXEC [dbo].[DeleteCountryByName] @CountryName = 'United Kingdom';
EXEC [dbo].[DeleteCountryByName] @CountryName = 'United States';

SELECT * FROM Country


--select by id 

CREATE PROCEDURE [dbo].[Pr_Country_SelectById]
	@CountryID int
AS
BEGIN
    SELECT  [dbo].[Country].[CountryID] , [dbo].[Country].[CountryName] , [dbo].[Country].[CountryCode]
	from [dbo].[Country]
	where [dbo].[Country].[CountryID] = @CountryID
END;

exec Pr_Country_SelectById 17



---For State:- 
CREATE PROCEDURE [dbo].[InsertState]
    @StateName VARCHAR(100),
    @StateCode VARCHAR(3),
    @CountryID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [dbo].[State] (StateName, StateCode, CountryID)
    VALUES (@StateName, @StateCode, @CountryID);

    PRINT 'Inserted state: ' + @StateName + ' (' + @StateCode + ') for CountryID: ' + CAST(@CountryID AS VARCHAR(10));
END;

exec