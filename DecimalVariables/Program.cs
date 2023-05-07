
// decimal is more precise than double (costs more)
// primarily holds things like money and astronomical numbers
// math operations - add/subtract

// double = 4.12, 32, 1.234
// decimal = 4.12, 32, 1.234

// Int32 - 00000000 00000000 00000000 00000000

decimal bankAccountBalance;

bankAccountBalance = 2.34M;
Console.WriteLine(bankAccountBalance);