
INSERT INTO AspNetUsers(Id,UserName,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount)
VALUES (1,'David',0,0,0,0,0)
INSERT INTO AspNetUsers
VALUES ('2','Brian','0','0','0',0,'0','0','0','0',1,1,'2022/09/28',1,5)
INSERT INTO AspNetUsers(Id,UserName,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount)
VALUES (3,'Cesar',0,0,0,0,0)


INSERT INTO AspNetUserLogins
VALUES('ASP.NET','1','ASP.NET','1')

INSERT INTO Departments
VALUES('Construction'),('Human Resources'),('Purchasing')



INSERT INTO EmployeeTypes
VALUES('Superintendent'),('Project Engineer'),('Recruiter'),('Supply chain Manager')



INSERT INTO Employees(UserId,FirstName,LastName,DepartmentId,EmployeeTypeId)
VALUES(2,'David','Garcia',1,1)



INSERT INTO LoggedTimeTypes
VALUES('Regular'),('Sick'),('Vacation')


INSERT INTO LoggedTime
VALUES(GETDATE(),6,1,100000,1)



--DROP TABLE Employees
--DELETE FROM AspNetUsers