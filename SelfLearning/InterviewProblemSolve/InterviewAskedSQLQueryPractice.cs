using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewProblemSolve
{
    internal class InterviewAskedSQLQueryPractice
    {

//        ROW_NUMBER() OVER(Select* from HR_Employee );

//        SELECT
//           ROW_NUMBER() OVER(
//            ORDER BY EmployeeId
        
//           )
//  rownumber, 
//   NationalityId,
//   PermanentAddress,  
//   Name
//FROM
//   HR_Employee;


        //Find Out Second highest number

//   SELECT min(BasicSalary) FROM(
//    select row_number() OVER (order by BasicSalary DESC) AS ROWINDEX, BasicSalary
//    from HR_Employee e ) TB
//WHERE TB.ROWINDEX <=2

//select min(salary)from(select distinct salary from emp order by salary desc)where rownum<=2;



//        SELECT min(BasicSalary) from
//        (select TOP 3 ROW_NUMBER () OVER(ORDER BY BasicSalary desc) AS RowNum, BasicSalary From HR_Employee) TB
//        where TB.RowNum <=3

//SELECT min(
//(select TOP 3 ROW_NUMBER () OVER(ORDER BY BasicSalary desc) AS RowNum, BasicSalary From HR_Employee)) TB
//where TB.RowNum <=3



    }
}
