string ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            result = "A";
        case 8:
        case 7:
        case 6:
            result = "B";
        case 5:
        case 4:
        case 3:
            result = "C";
        case 2:
        case 1:
            resut = "D";
        case 0:
            result = "F";
        default:
            result = "Invalid grade";
    }
}