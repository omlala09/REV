// 1. Printing output to the console terminal screen
Console.WriteLine("--- C# Variables & Baseline Practice ---");

// 2. Declaring basic explicit Data Types
string studentName = "Om";           // Holds text variables
int trainingDays = 30;               // Holds whole numerical integers
double courseProgressPercentage = 0.05; // Holds accurate fractional floating-point numbers
bool isTrainingFun = true;           // Holds binary evaluation constraints (true/false)

// 3. Printing variables dynamically using String Interpolation ($"...")
Console.WriteLine($"Student Name: {studentName}");
Console.WriteLine($"Days Registered: {trainingDays} days");
Console.WriteLine($"Initial Progress Layout: {courseProgressPercentage * 100}%");
Console.WriteLine($"Is .NET awesome? {isTrainingFun}");

// 4. Capturing User Input dynamically from the terminal window
Console.Write("\nEnter a new text note for your learning log: ");
string? userNote = Console.ReadLine(); // Pauses execution until you type and press Enter

Console.WriteLine($"\nSuccessfully saved note: \"{userNote}\"");