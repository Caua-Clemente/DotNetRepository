try{
    int result = Divide(10, 0);
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex) {
    Console.WriteLine("Error: cannot divide by zero");
    Console.WriteLine(ex.Message);    
}
catch (Exception ex) {
    Console.WriteLine("Error: an error occurred");
    Console.WriteLine(ex.Message);    
}
finally{
    Console.WriteLine("Finally block executed");
}

int Divide(int a, int b){
    if(b == 0){
        throw new DivideByZeroException("Cannot divide by zero");
    }

    return a/b;
}