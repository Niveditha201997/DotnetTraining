CREATE DATABASE ORG;

USE ORG;

CREATE TABLE Worker (
	WORKER_ID INT NOT NULL PRIMARY KEY Identity,
	FIRST_NAME CHAR(25),
	LAST_NAME CHAR(25),
	SALARY NUMERIC(15),
	JOINING_DATE DATETIME,
	DEPARTMENT CHAR(25)
);

INSERT INTO Worker 
	(FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT) VALUES
		('Monika', 'Arora', 100000, '2014-02-20 09:00.00', 'HR'),
		('Niharika', 'Verma', 80000, '2014-06-11 09:00.00', 'Admin'),
		('Vishal', 'Singhal', 300000, '2014-02-20 09:00.00', 'HR'),
		('Amitabh', 'Singh', 500000, '2014-02-20 09:00.00', 'Admin'),
		('Vivek', 'Bhati', 500000, '2014-06-11 09:00.00', 'Admin'),
		('Vipul', 'Diwan', 200000, '2014-06-11 09:00.00', 'Account'),
		('Satish', 'Kumar', 75000, '2014-01-20 09:00.00', 'Account'),
		('Geetika', 'Chauhan', 90000, '2014-04-11 09:00.00', 'Admin');

		SELECT * FROM WORKER

CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Bonus 
	(WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE) VALUES
		(2, 5000, '2016-02-20'),
		(3, 3000, '2016-06-11'),
		(4, 4000, '2016-02-20'),
		(5, 4500, '2016-02-20'),
		(6, 3500, '2016-06-11');
    
CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE CHAR(25),
	AFFECTED_FROM DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Title 
(WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM) VALUES
 (2, 'Manager', '2016-02-20 00:00:00'),
 (3, 'Executive', '2016-06-11 00:00:00'),
 (9, 'Executive', '2016-06-11 00:00:00'),
 (6, 'Manager', '2016-06-11 00:00:00'),
 (5, 'Asst. Manager', '2016-06-11 00:00:00'),
 (8, 'Executive', '2016-06-11 00:00:00'),
 (7, 'Lead', '2016-06-11 00:00:00'),
 (4, 'Lead', '2016-06-11 00:00:00');


 --Q-1. Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.
    
	SELECT FIRST_NAME AS WORKER_NAME FROM WORKER

--Q-2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.

   SELECT UPPER(FIRST_NAME) FROM WORKER

--Q-3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.

   SELECT DISTINCT(DEPARTMENT) FROM WORKER

--Q-4. Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.

    select substring(FIRST_NAME,1,3) as subName from worker;

--Q-5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.


   select CHARINDEX('A',FIRST_NAME) from Worker where FIRST_NAME = 'Amitabh';

 -- Q-6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
  
   Select RTRIM(FIRST_NAME) from Worker;

--Q-7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.
   
   Select LTRIM(DEPARTMENT) from Worker;

--Q-8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.
 
   Select distinct len(DEPARTMENT) from Worker;

--Q-9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.

   Select REPLACE(FIRST_NAME,'a','A') from Worker;

--Q-10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.
  
   Select CONCAT(FIRST_NAME, '', LAST_NAME) AS 'COMPLETE_NAME' from Worker;

--Q-11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.
  
   Select * from Worker order by FIRST_NAME asc;

--Q-12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.

   Select * from Worker order by FIRST_NAME asc ,DEPARTMENT desc;

--Q-13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.

   Select * from Worker where FIRST_NAME in ('Vipul','Satish');
 

--Q-14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.

   Select * from Worker where FIRST_NAME not in ('Vipul','Satish');

--Q-15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.

   Select * from Worker where DEPARTMENT like 'Admin%';

--Q-16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.

   Select * from Worker where FIRST_NAME like '%a%';

--Q-17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.

  Select * from Worker where FIRST_NAME like '%a';

--Q-18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.

  Select * from Worker where FIRST_NAME like '_____h';

--Q-19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.

   Select * from Worker where SALARY between 100000 and 500000;

--Q-20. Write an SQL query to print details of the Workers who have joined in Feb’2014.

   Select * from Worker where year(JOINING_DATE) = 2014 and month(JOINING_DATE) = 2;


--Q-21. Write an SQL query to fetch the count of employees working in the department ‘Admin’.

   SELECT COUNT(*) FROM worker WHERE DEPARTMENT = 'Admin';

--Q-22. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.

   SELECT CONCAT(FIRST_NAME, ' ', LAST_NAME) As Worker_Name, Salary
   FROM worker 
   WHERE WORKER_ID IN (SELECT WORKER_ID FROM worker 
   WHERE Salary BETWEEN 50000 AND 100000);


--Q-23. Write an SQL query to fetch the no. of workers for each department in the descending order.

   SELECT DEPARTMENT, count(WORKER_ID) No_Of_Workers 
   FROM worker 
   GROUP BY DEPARTMENT 
   ORDER BY No_Of_Workers DESC;

--Q-24. Write an SQL query to print details of the Workers who are also Managers.

   SELECT DISTINCT W.FIRST_NAME, T.WORKER_TITLE
   FROM Worker W
   INNER JOIN Title T
   ON W.WORKER_ID = T.WORKER_REF_ID
   AND T.WORKER_TITLE in ('Manager');

--Q-25. Write an SQL query to fetch duplicate records having matching data in some fields of a table.

   SELECT WORKER_TITLE, AFFECTED_FROM, COUNT(*)
   FROM Title
   GROUP BY WORKER_TITLE, AFFECTED_FROM
   HAVING COUNT(*) > 1;

--Q-26. Write an SQL query to show only odd rows from a table.

   select *from Worker where worker_id %2 != 0;

--Q-27. Write an SQL query to show only even rows from a table.

   select *from Worker where worker_id %2 = 0;

--Q-28. Write an SQL query to clone a new table from another table.

   SELECT * INTO WorkerClone FROM Worker;

--Q-29. Write an SQL query to fetch intersecting records of two tables.

  (SELECT * FROM Worker)
   INTERSECT (SELECT * FROM WorkerClone);

--Q-30. Write an SQL query to show records from one table that another table does not have.

  SELECT * FROM Worker MINUS
  SELECT * FROM Title;

--Q-31 Write an SQL query to show the top n (say 10) records of a table. 

   SELECT TOP 10 * FROM Worker ORDER BY Salary DESC;

--Q-32 Write an SQL query to determine the 5th highest salary without using TOP or limit method. 

  SELECT SALARY FROM Worker W1
  WHERE 4 = (SELECT COUNT( DISTINCT ( W2.Salary ) )
  FROM Worker W2
  WHERE W2.Salary >= W1.SALARY);

--Q-33 Write an SQL query to print the name of employees having the highest salary in each department.

  SELECT t.DEPARTMENT,t.FIRST_NAME,t.Salary from(SELECT max(Salary) as TotalSalary,DEPARTMENT from Worker group by DEPARTMENT) as TempNew 
  Inner Join Worker t on TempNew.DEPARTMENT=t.DEPARTMENT and TempNew.TotalSalary=t.Salary;

--Q-34 Write an SQL query to fetch three max salaries from a table. 

   SELECT distinct Salary from worker a WHERE 3 >= (SELECT count(distinct Salary) from worker b WHERE a.Salary <= b.Salary) order by a.Salary desc;


--Q-35 Write an SQL query to show all departments along with the number of people in there.

   SELECT DEPARTMENT, COUNT(DEPARTMENT) as 'Number of Workers' FROM Worker GROUP BY DEPARTMENT;















 SELECT t.DEPARTMENT,t.FIRST_NAME,t.Salary from(SELECT max(Salary) as TotalSalary,DEPARTMENT from Worker group by DEPARTMENT) as TempNew 
  Inner Join Worker t on TempNew.DEPARTMENT=t.DEPARTMENT and TempNew.TotalSalary=t.Salary;


  SELECT * FROM WORKER
 