namespace Refactoring;

public class Grading
{
    public static char GetLetterGrade(int grade)
    {
        switch (grade)
        {
            case 1:
                return 'A';
            case 2:
                return 'B';
            case 3:
                return 'C';
            case 4:
                return 'D';
            case 5:
                return 'E';
            case 6:
                return 'F';
            default:
                throw new ArgumentException("unknown grade " + grade);
        }
    }
}