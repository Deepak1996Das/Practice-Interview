/*                 Create Database             */
Create database DemoPracticeDb;


/*============================= Table===============================================*/



/*                Create table            */


Create table employee(
     Name varchar(100),
	 Age int,
	 Gender varchar(25)
)



/*               Retrive data from a table        */

select * from employee;



/*               Insert Data into table              */

insert employee(Name,age,Gender) values('Deepak',27,'Male');



/*         Change table name                   */

alter table employee
rename to Employee_Details;


EXEC sp_rename new_table_name, 'Emp'