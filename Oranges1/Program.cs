var rottenOranges = new List<(int row, int column)>(); 
var newRottenOranges = new List<(int row, int column)>();


string[] firstLine = Console.ReadLine().Split(" ");
var k = int.Parse(firstLine[0]);
var l = int.Parse(firstLine[1]);
var r = int.Parse(firstLine[2]);

var allOranges = k * l;
var initialRottenOranges = int.Parse(Console.ReadLine());

for(int i = 0; i<initialRottenOranges; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    var row = int.Parse(line[0]);
    var col = int.Parse(line[1]);
    rottenOranges.Add((row, col));
}

while (r > 0)
{
    int i = rottenOranges.Count - 1;

    while (i >= 0)
    {
        var orange = rottenOranges[i];

        var row = orange.row;
        var column = orange.column;
        var upperRow = row + 1;
        var lowerRow = row - 1;
        var leftColumn = column - 1;
        var rightColumn = column + 1;

        if (row == k)
        {
            if (column == 1)
            {
                newRottenOranges.Add((row, rightColumn));
                newRottenOranges.Add((lowerRow, column));
            }
            else if (column == l)
            {
                newRottenOranges.Add((row, leftColumn));
                newRottenOranges.Add((lowerRow, column));
            }
            else
            {
                newRottenOranges.Add((row, rightColumn));
                newRottenOranges.Add((row, leftColumn));
                newRottenOranges.Add((lowerRow, column));
            }
        }
        else if (row == 1)
        {
            if (column == 1)
            {
                newRottenOranges.Add((upperRow, column));
                newRottenOranges.Add((row, rightColumn));
            }
            else if (column == l)
            {
                newRottenOranges.Add((row, leftColumn));
                newRottenOranges.Add((upperRow, column));
            }
            else
            {
                newRottenOranges.Add((row, rightColumn));
                newRottenOranges.Add((row, leftColumn));
                newRottenOranges.Add((upperRow, column));
            }
        }
        else
        {
            if (column == 1)
            {
                newRottenOranges.Add((upperRow, column));
                newRottenOranges.Add((row, rightColumn));
                newRottenOranges.Add((lowerRow, column));
            }
            else if (column == l)
            {
                newRottenOranges.Add((upperRow, column));
                newRottenOranges.Add((row, leftColumn));
                newRottenOranges.Add((lowerRow, column));
            }
            else
            {
                newRottenOranges.Add((row, rightColumn));
                newRottenOranges.Add((row, leftColumn));
                newRottenOranges.Add((lowerRow, column));
                newRottenOranges.Add((upperRow, column));
            }
        }
        foreach (var item in newRottenOranges)
        {
            if (!rottenOranges.Contains(item))
            {
                rottenOranges.Add(item);
            }
        }
        newRottenOranges.Clear();

        i--;
    }
    r--;
}

var unrottenOranges = allOranges - rottenOranges.Count;
Console.WriteLine(unrottenOranges);





