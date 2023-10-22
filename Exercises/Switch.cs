//Char needs to be in single quotes
//Char is a single character
//Sting is a collection of characters and needs to be in double quotes
Char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return ''A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return ''C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'F';
        default:
            return '!';
    }
}
