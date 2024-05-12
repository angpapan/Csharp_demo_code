try
{
    // Code that may throw an exception
    int a = 100;
    int b = 0;
    // Division by zero, throws DivideByZeroException
    int result = a / b;  
}
catch (DivideByZeroException ex)
{
    // Prints the message "Attempted to divide by zero."
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    // Handle other types of exceptions
    Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
    // Optional block for cleanup code (runs every time)
    Console.WriteLine("Cleanup code");
}