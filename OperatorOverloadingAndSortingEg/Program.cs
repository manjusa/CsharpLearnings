// See https://aka.ms/new-console-template for more information
using OperatorOverloadingAndSortingEg;

CalculatorEg();
SortingComparableEg();
SortingComparerEg();

void CalculatorEg()
{
    Calculator c = new(5);
    Calculator d = new(4);
    Calculator addNums = Calculator.Add(c, d);
    Console.WriteLine($"val of addNums with Add method is : {addNums.Value}");
    Calculator addNumsWithPlusOp = c + d;
    Console.WriteLine($"val of addNumsWithPlusOp with Plus operator method is: {addNumsWithPlusOp.Value}");

    Calculator subtractNums = Calculator.Subtract(c, d); 
    Console.WriteLine($"val of subtractNums with Subtract method is: {subtractNums.Value}");
    Calculator subtractNumsWithMinusOperator = c - d;
    Console.WriteLine($"val of subtractNumsWithMinusOperator with Subtract operator method is: {subtractNumsWithMinusOperator.Value}");
   

    Calculator c1 = new(100);
    Calculator d1 = new(10);

    Calculator multiplyNums = Calculator.Multiply(c1, d1);
    Console.WriteLine($"val of multiplyNums with Multiply method is: {multiplyNums.Value}");
    Calculator multiplyNumsWithMultiplyOp = c1 * d1;
    Console.WriteLine($"val of multiplyNusmWithMultiplyOp with Multiply operator method is: {multiplyNumsWithMultiplyOp.Value}");

    Calculator divideNums = c1 / d1;
    Console.WriteLine($"val of divideNums with Divide method is: {divideNums.Value}");
    Calculator divideNumsWithDivideOp = c1 / d1;
    Console.WriteLine($"val of divideNumsWithDivideOp with Divide operator method is: {divideNumsWithDivideOp.Value}");
}

void SortingComparableEg()
{
    List<Employee> employees = new List<Employee>{
       new ("Manju s", 30, "Software Engineer"),
        new ("Tom s", 25, "Devops"),
        new ("Kristy s", 45, "Devops")
   };
    employees.Sort();
    Console.WriteLine("Employees sorted by Name:");
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
    }
}

void SortingComparerEg()
{
    List<Customer> customers = new List<Customer>{
        new ("Manju s", 30),
        new ("Tom s", 2),
        new ("Kristy", 33)
   };
    customers.Sort(new CustomerComparer());
    Console.WriteLine("Customer sorted by Name:");
    foreach (var customer in customers)
    {
        Console.WriteLine(customer);
    }
}

