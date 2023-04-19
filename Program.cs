/* 1 Point The application prompts the user to enter values of length and width of the classroom.
2 Points: The application displays the area and perimeter of that classroom.
2 Points: The application classifies the room as small (up to and including 250 square feet), medium(more than 250 but less than 650 square feet), or large(650 square feet or more).

Build Specifications:
1 Point: Assume that the rooms are rectangles (90 degree corners).
1 Point: Assume that the user will enter valid numeric data for length and width.
1 Point: The application should accept decimal entries.

Additional Requirements:
1 Point: For answering the Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method). 

Hints:
Don’t mess up the formulas for area or perimeter.

Extra Challenges:
1 Point: Calculate the volume of the rooms.
1 Point: Calculate the surface area of the rooms.*/

Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

double area;
double perimeter;
double volume;
double surfaceArea;

Console.WriteLine("Enter Length:");
string inputLength  = Console.ReadLine();
double length = double.Parse(inputLength);

Console.WriteLine("Enter Width:");
string inputWidth = Console.ReadLine();
double width = double.Parse(inputWidth);

Console.WriteLine("Enter Height:");
string inputHeight = Console.ReadLine();
double height = double.Parse(inputHeight);

area = width * length;
perimeter = 2 * (width + length);
volume = length * width * height;


Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");

if (area <= 250)
{
    Console.WriteLine("Calculated: this is a small room");
}
else if (area <= 650)
{
    Console.WriteLine("Calculated: this is a medium sized room");
}
else
{
    Console.WriteLine("Caclulated: this is a large room");
}



