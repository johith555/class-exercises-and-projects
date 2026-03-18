-- Crime Management System - 20 SQL Queries

-- 1. Select all open incidents
SELECT * 
FROM Crime
WHERE Status = 'Open';

-- 2. Find the total number of incidents
SELECT COUNT(*) AS TotalIncidents
FROM Crime;

-- 3. List all unique incident types
SELECT DISTINCT IncidentType
FROM Crime;

-- 4. Retrieve incidents between '2023-09-01' and '2023-09-10'
SELECT *
FROM Crime
WHERE IncidentDate BETWEEN '2023-09-01' AND '2023-09-10';

-- 5. List persons involved in incidents in descending order of age
SELECT Name, Age
FROM Victim
ORDER BY Age DESC;

-- 6. Find the average age of persons involved in incidents
SELECT AVG(Age) AS AverageAge
FROM Victim;

-- 7. List incident types and their counts, only for open cases
SELECT IncidentType, COUNT(*) AS TotalOpenCases
FROM Crime
WHERE Status = 'Open'
GROUP BY IncidentType;

-- 8. Find persons with names containing 'Doe'
SELECT *
FROM Victim
WHERE Name LIKE '%Doe%';

-- 9. Retrieve the names of persons involved in open and closed cases
SELECT v.Name, c.Status
FROM Victim v
JOIN Crime c ON v.CrimeID = c.CrimeID
WHERE c.Status IN ('Open', 'Closed');

-- 10. List incident types where persons aged 30 or 35 involved
SELECT DISTINCT c.IncidentType
FROM Crime c
JOIN Victim v ON c.CrimeID = v.CrimeID
WHERE v.Age IN (30, 35);

-- 11. Find persons involved in incidents of the same type as 'Robbery'
SELECT v.Name
FROM Victim v
JOIN Crime c ON v.CrimeID = c.CrimeID
WHERE c.IncidentType = 'Robbery';

-- 12. List incident types with more than one open case
SELECT IncidentType
FROM Crime
WHERE Status = 'Open'
GROUP BY IncidentType
HAVING COUNT(*) > 1;

-- 13. List all incidents with suspects whose names also appear as victims in other incidents
SELECT DISTINCT c.*
FROM Crime c
JOIN Suspect s ON c.CrimeID = s.CrimeID
JOIN Victim v ON s.Name = v.Name;

-- 14. Retrieve all incidents along with victim and suspect details
SELECT c.*, v.Name AS VictimName, s.Name AS SuspectName
FROM Crime c
LEFT JOIN Victim v ON c.CrimeID = v.CrimeID
LEFT JOIN Suspect s ON c.CrimeID = s.CrimeID;

-- 15. Find incidents where the suspect is older than any victim
SELECT DISTINCT c.*
FROM Crime c
JOIN Suspect s ON c.CrimeID = s.CrimeID
JOIN Victim v ON c.CrimeID = v.CrimeID
WHERE s.Age > v.Age;

-- 16. Find suspects involved in multiple incidents
SELECT Name, COUNT(*) AS TotalIncidents
FROM Suspect
GROUP BY Name
HAVING COUNT(*) > 1;

-- 17. List incidents with no suspects involved
SELECT c.*
FROM Crime c
LEFT JOIN Suspect s ON c.CrimeID = s.CrimeID
WHERE s.SuspectID IS NULL;

-- 18. List all cases where at least one incident is of type 'Homicide' and all others are 'Robbery'
SELECT *
FROM Crime
WHERE IncidentType IN ('Homicide', 'Robbery');

-- 19. Retrieve a list of all incidents and associated suspects or 'No Suspect' if none
SELECT c.CrimeID, c.IncidentType,
COALESCE(s.Name, 'No Suspect') AS SuspectName
FROM Crime c
LEFT JOIN Suspect s ON c.CrimeID = s.CrimeID;

-- 20. List all suspects involved in 'Robbery' or 'Assault' incidents
SELECT DISTINCT s.Name
FROM Suspect s
JOIN Crime c ON s.CrimeID = c.CrimeID
WHERE c.IncidentType IN ('Robbery', 'Assault');
