CREATE PROCEDURE [dbo].[InsertDepartment]
    @departmentName VARCHAR(100),
    @departmentFaculty VARCHAR(100),
    @departmentCode VARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[Department] (departmentName, departmentFaculty, departmentCode)
    VALUES (@departmentName, @departmentFaculty, @departmentCode);

    PRINT 'Data Inserted in Department Table';
END;


drop procedure [dbo].[InsertDepartment]
drop procedure [dbo].[InsertDesignation]

CREATE PROCEDURE [dbo].[InsertDesignation]
    @designationName VARCHAR(100),
    @departmentId INT
AS
BEGIN
    INSERT INTO [dbo].[Designation] (designationName, departmentId)
    VALUES (@designationName, @departmentId);

    PRINT 'Data Inserted in Designation Table';
END;


CREATE PROCEDURE [dbo].[InsertEmployee]
    @empolyeeName NVARCHAR(100),
    @designationId INT,
    @departmentId INT,
    @empsalary DECIMAL(10, 2),
    @contact NVARCHAR(20),
    @empemail NVARCHAR(100),
    @address NVARCHAR(200),
    @age INT,
    @qualification NVARCHAR(100)
AS
BEGIN
    INSERT INTO [dbo].[Employee] (empolyeeName, designationId, departmentId, empsalary, contact, empemail, address, age, qualification)
    VALUES (@empolyeeName, @designationId, @departmentId, @empsalary, @contact, @empemail, @address, @age, @qualification);

    PRINT 'Data Inserted in Employee Table';
END;


-------------------UPDATE-------------------------------------

CREATE PROCEDURE [dbo].[UpdateDepartment]
    @departmentId INT,
    @departmentName VARCHAR(100),
    @departmentFaculty VARCHAR(100),
    @departmentCode VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Department]
    SET departmentName = @departmentName,
        departmentFaculty = @departmentFaculty,
        departmentCode = @departmentCode
    WHERE departmentId = @departmentId;

    PRINT 'Data Updated in Department Table';
END;

drop procedure [dbo].[UpdateDepartment]

CREATE PROCEDURE [dbo].[UpdateDesignation]
    @designationId INT,
    @designationName VARCHAR(100),
    @departmentId INT
AS
BEGIN
    UPDATE [dbo].[Designation]
    SET designationName = @designationName,
        departmentId = @departmentId
    WHERE designationId = @designationId;

    PRINT 'Data Updated in Designation Table';
END;


CREATE PROCEDURE [dbo].[UpdateEmployee]
    @empId INT,
    @empolyeeName NVARCHAR(100),
    @designationId INT,
    @departmentId INT,
    @empsalary DECIMAL(10, 2),
    @contact NVARCHAR(20),
    @empemail NVARCHAR(100),
    @address NVARCHAR(200),
    @age INT,
    @qualification NVARCHAR(100)
AS
BEGIN
    UPDATE [dbo].[Employee]
    SET EmpolyeeName = @empolyeeName,
        designationId = @designationId,
        departmentId = @departmentId,
        empsalary = @empsalary,
        contact = @contact,
        empemail = @empemail,
        address = @address,
        age = @age,
        qualification = @qualification
    WHERE empId = @empId;

    PRINT 'Data Updated in Employee Table';
END;

-------------------------------Delete--------------------------------------
CREATE PROCEDURE [dbo].[DeleteDepartment]
    @departmentId INT
AS
BEGIN
    DELETE FROM [dbo].[Department]
    WHERE departmentId = @departmentId;

    PRINT 'Data Deleted from Department Table';
END;

drop procedure [dbo].[DeleteDepartment]


CREATE PROCEDURE [dbo].[DeleteDesignation]
    @designationId INT
AS
BEGIN
    DELETE FROM [dbo].[Designation]
    WHERE designationId = @designationId;

    PRINT 'Data Deleted from Designation Table';
END;


CREATE PROCEDURE [dbo].[DeleteEmployee]
    @empolyeeId INT
AS
BEGIN
    DELETE FROM [dbo].[Employee]
    WHERE EmpID = @empolyeeId;

    PRINT 'Data Deleted from Employee Table';
END;



--------------------Select by all ----------------------

CREATE PROCEDURE [dbo].[PR_Department_SelectAll]
AS
BEGIN
    SELECT [dbo].[Department].[DepartmentId],
           [dbo].[Department].[DepartmentName],
           [dbo].[Department].[DepartmentCode],
           [dbo].[Department].[DepartmentFaculty]
    FROM [dbo].[Department];
END;


CREATE PROCEDURE [dbo].[PR_Designation_SelectAll]
AS
BEGIN
    SELECT [dbo].[Designation].[DesignationId],
           [dbo].[Designation].[DesignationName],
           [dbo].[Designation].[DepartmentId]
    FROM [dbo].[Designation];
END;


CREATE PROCEDURE [dbo].[PR_Employee_SelectAll]
AS
BEGIN
    SELECT [dbo].[Employee].[EmpId],
           [dbo].[Employee].[EmpolyeeName],
           [dbo].[Employee].[DesignationId],
           [dbo].[Employee].[DepartmentId],
           [dbo].[Employee].[EmpSalary],
           [dbo].[Employee].[Contact],
           [dbo].[Employee].[EmpEmail],
           [dbo].[Employee].[Address],
           [dbo].[Employee].[Age],
           [dbo].[Employee].[Qualification]
    FROM [dbo].[Employee];
END;


---------------------Select by ID---------------------------




