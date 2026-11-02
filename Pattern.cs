string bankRecords = """
    DEPOSIT,   10000, Initial balance
    DEPOSIT,     500, regular deposit
    WITHDRAWAL, 1000, rent
    DEPOSIT,    2000, freelance payment
    WITHDRAWAL,  300, groceries
    DEPOSIT,     700, gift from friend
    WITHDRAWAL,  150, utility bill
    DEPOSIT,    1200, tax refund
    WITHDRAWAL,  500, car maintenance
    DEPOSIT,     400, cashback reward
    WITHDRAWAL,  250, dining out
    DEPOSIT,    3000, bonus payment
    WITHDRAWAL,  800, loan repayment
    DEPOSIT,     600, stock dividends
    WITHDRAWAL,  100, subscription fee
    DEPOSIT,    1500, side hustle income
    WITHDRAWAL,  200, fuel expenses
    DEPOSIT,     900, refund from store
    WITHDRAWAL,  350, shopping
    DEPOSIT,    2500, project milestone payment
    WITHDRAWAL,  400, entertainment
    """;  // CSVs input

double currentBalance = 0.0;
var reader = new StringReader(bankRecords); // In C#, file streams use StreamReader, but if your text data is already sitting in 
// a string variable (bankRecords), you can't read it line-by-line out of the box. Wrapping it in a StringReader gives you a 
// stream interface, allowing you to use methods like ReadLine() on plain text. Like io.StringIO(...) in python 

string? line; // allows it to be null like string? line can be a valid string or null, in bool? can be true, false or null  
while ((line = reader.ReadLine()) is not null) // fetches the next line of the text and assigns it to line.
{
    if (string.IsNullOrWhiteSpace(line)) continue; // line.strip() function in python checks three things : 1. if string is empty 
    // 2: null 3: entirely full of blanks and spaces 
    
    // Split the line based on comma delimiter and trim each part
    string[] parts = line.Split(','); // same as line.split(",") in python 

    string? transactionType = parts[0]?.Trim(); // fetches the first element of parts then null operator like if its null then it 
    // stops and returns null then ttrim extra spaces transaction_type = parts[0].strip() if parts[0] is not None else None
    if (double.TryParse(parts[1].Trim(), out double amount)) // return string into numbers double.Parse() provides exception if someone 
    // writes string instead of numbers TryParse returns false for this out double creates new variable and stores it in with the 
    // numbers just converted  if the check succeeds.
    {
        // Update the balance based on transaction type
        if (transactionType?.ToUpper() is "DEPOSIT")
            currentBalance += amount;
        else if (transactionType?.ToUpper() is "WITHDRAWAL")
            currentBalance -= amount;

        // Console.WriteLine($"{line.Trim()} => Parsed Amount: {amount}, New Balance: {currentBalance}");
    }
}


static IEnumerable<(TransactionType type, double amount)> TransactionRecords(string inputText)
{
    var reader = new StringReader(inputText);
    string? line;
    while ((line = reader.ReadLine()) is not null)
    {
        string[] parts = line.Split(',');

        string? transactionType = parts[0]?.Trim();
        if (double.TryParse(parts[1].Trim(), out double amount))
        {
            // Update the balance based on transaction type
            if (transactionType?.ToUpper() is "DEPOSIT")
                yield return (TransactionType.Deposit, amount);
            else if (transactionType?.ToUpper() is "WITHDRAWAL")
                yield return (TransactionType.Withdrawal, amount);
        }
        else {
            yield return (TransactionType.Invalid, 0.0);
        }
    }
}

currentBalance = 0.0;

foreach (var transaction in TransactionRecords(bankRecords))
{
    if (transaction.type == TransactionType.Deposit)
        currentBalance += transaction.amount;
    else if (transaction.type == TransactionType.Withdrawal)
        currentBalance -= transaction.amount;
    Console.WriteLine($"{transaction.type} => Parsed Amount: {transaction.amount}, New Balance: {currentBalance}");
}
public enum TransactionType
{
    Deposit,
    Withdrawal,
    Invalid
}

