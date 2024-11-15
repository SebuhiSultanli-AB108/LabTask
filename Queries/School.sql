-- CREATE TABLE Students
-- (
--     Id INT IDENTITY PRIMARY KEY,
--     FirstName VARCHAR(15) NOT NULL,
--     LastName VARCHAR(20) NOT NULL,
--     DataOfBirth DATE,
--     Username NVARCHAR(15) NOT NULL,
--     Password NVARCHAR(10) NOT NULL,
--     EnrollmentDate DATE
-- )

-- CREATE TABLE Departments
-- (
--     Id INT IDENTITY PRIMARY KEY,
--     DepartmentName VARCHAR(25) NOT NULL
-- )

-- CREATE TABLE Instructors
-- (
--     Id INT IDENTITY PRIMARY KEY,
--     FirstName VARCHAR(15) NOT NULL,
--     LastName VARCHAR(20) NOT NULL,
--     HireDate DATE,
--     DepartmentId INT REFERENCES Departments(Id),
--     Username NVARCHAR(15) NOT NULL,
--     Password NVARCHAR(10) NOT NULL,
--     PİN NVARCHAR(7) NOT NULL
-- )

-- CREATE TABLE Groups
-- (
--     Id INT IDENTITY PRIMARY KEY,
--     GroupName NVARCHAR(20),
--     DepartmentId INT REFERENCES Departments(Id),
--     StartDate DATE,
--     EndDate DATE
-- )

-- CREATE TABLE Enrollments
-- (
-- Id INT IDENTITY PRIMARY KEY,
-- StudentId INT REFERENCES Students(Id),
-- GroupId INT REFERENCES Groups(Id)
-- )

-- CREATE TABLE Classes
-- (
-- Id INT IDENTITY PRIMARY KEY,
-- GroupId INT REFERENCES Groups(Id),
-- InstructorId INT REFERENCES Instructors(Id),
-- Schedule NVARCHAR(64),
-- RoomName NVARCHAR(20)
-- )

------------------------------------------------------------------------------------------------------

-- ALTER PROCEDURE InsertStudent
--     @FirstName VARCHAR(15),
--     @LastName VARCHAR(20),
--     @DataOfBirth DATE,
--     @Username NVARCHAR(15),
--     @Password NVARCHAR(10)
-- AS
-- INSERT INTO Students (FirstName, LastName, DataOfBirth, Username, [Password] )
-- VALUES
--     (@FirstName, @LastName, @DataOfBirth, @Username, @Password)

-- EXEC InsertStudent 'Selcan', 'Karimli', '2002-08-31', 'Selcaster', 'password'

-- CREATE PROCEDURE PrintCedvel
-- AS
-- BEGIN
--     SELECT s.Id, s.FirstName, s.LastName, g.GroupName, c.Schedule, c.RoomName
--     FROM Students as s
--         JOIN Enrollments as e
--         ON s.Id = e.StudentId
--         JOIN Groups as g
--         ON g.Id = e.GroupId
--         JOIN Classes as c
--         ON g.Id = c.GroupId
-- END

-- EXEC PrintCedvel