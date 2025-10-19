-- Students 
-- 1
SELECT * FROM HomeWorkWeek15.dbo.Students
WHERE Dob >= '1990-01-01'

-- 2
DECLARE @currentDate date = CAST (GETDATE() as date)

SELECT Firstname, Lastname, 
    DATEDIFF(YEAR, DoB, @currentDate) 
    - CASE WHEN 
            (MONTH(@currentDate) < MONTH(DoB)) 
            OR
            (MONTH(@currentDate) = MONTH(DoB) AND DAY(@currentDate) < DAY(DoB)) THEN 1 
            ELSE 0 
            END AS Age
FROM HomeWorkWeek15.dbo.Students
WHERE Country IN ('Libya', 'Georgia')

-- 3
INSERT INTO HomeWorkWeek15.dbo.Students
(Lastname, Firstname, DoB, Email, Quiz1, Quiz2, MiddleTest, FinalTest, Country)
VALUES
('Chikovani', 'Iovane', '2001-12-31', 'test@gmail.com', 10, 9, 100, 99, 'Georgia')

SELECT * FROM HomeWorkWeek15.dbo.Students
WHERE Lastname = 'Chikovani'

-- 4
SELECT TOP 5 WITH TIES Firstname, MiddleTest
FROM HomeWorkWeek15.dbo.Students
ORDER BY MiddleTest desc

WITH Ranked AS (
    SELECT Firstname, MiddleTest,
    DENSE_RANK() OVER (ORDER BY MiddleTest desc) AS Ranking
    FROM HomeWorkWeek15.dbo.Students
    )
SELECT Firstname, MiddleTest
FROM Ranked
WHERE Ranking <= 5

-- 5
DELETE HomeWorkWeek15.dbo.Students
OUTPUT deleted.*
WHERE FinalTest = 19

-- 6
UPDATE HomeWorkWeek15.dbo.Students
SET FinalTest = 0
WHERE MiddleTest = 1

-- Persons
-- 1
SELECT * 
FROM HomeWorkWeek15.dbo.Persons
WHERE PrivateId like '163%'

-- 2
SELECT * 
FROM HomeWorkWeek15.dbo.Persons
WHERE Lastname = City

-- 3
SELECT * 
FROM HomeWorkWeek15.dbo.Persons
WHERE Country IN ('Monaco', 'Canada')

-- 4
SELECT Firstname, Lastname, PrivateId
FROM HomeWorkWeek15.dbo.Persons
WHERE Email is null

-- 5
SELECT * 
FROM HomeWorkWeek15.dbo.Persons
WHERE Country IN ('Spain', 'Turkey') and Salary between 1000 and 3000

-- 6
SELECT WorkPlace
FROM HomeWorkWeek15.dbo.Persons
WHERE WorkPlace like '%[LLC, PC, LLP]'

-- 7
SELECT IIF(LEN(Email) - LEN(REPLACE(Email, '.', '')) > 2, 'more than 2 dots', 'less than 2 dots') AS DotsCount
FROM HomeWorkWeek15.dbo.Persons

-- 8
SELECT * 
FROM HomeWorkWeek15.dbo.Persons
WHERE PINcode like '__51'

-- 9
SELECT Country, AVG(Salary) AS AverageSalary
FROM HomeWorkWeek15.dbo.Persons
GROUP BY Country
ORDER By AverageSalary desc