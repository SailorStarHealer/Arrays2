class Program
{
    //Creates a static int with a length of 15
    static int height = 15;

    //Creates a static int with a length of 80
    static int width = 80;

    //Creates a constant int with the value of '0' and names it 'right'
    const int right = 0;

    //Creates a constant int with the value of '1' and names it 'down'
    const int down = 1;

    //Creates a constant int with the value of '2' and names it 'left'
    const int left = 2;

    //Create a constant int with the 
    const int up = 3;

    //Creates a static random.
    static Random random = new Random();

    //Creates a static boolean value
    static bool[,] roads = new bool[width, height];

    //creates a new 'main'.
    static void Main(string[] args)
    {

        int intersectX = random.Next(0, width-1);

        int intersectY = random.Next(0, height-1);

        GenerateIntersection(roads, intersectX, intersectY);

        intersectX = random.Next(0, width-1);

        intersectY = random.Next(0, height-1);


        GenerateIntersection(roads, intersectX, intersectY);

        intersectX = random.Next(0, width-1);

        intersectY = random.Next(0, height-1);


        GenerateIntersection(roads, intersectX, intersectY);
        DrawRoads();
    }

    //Creates a static method called 'GenerateIntersection'/
    static void GenerateIntersection(bool[,] roads, int x, int y)
    {
        int createRoad = random.Next(0, 10);

        if (createRoad < 7)
        {
            GenerateRoad(roads, x, y, up);
        }

        createRoad = random.Next(0, 10);

        if (createRoad < 7)
        {
            GenerateRoad(roads, x, y, down);
        }

        createRoad = random.Next(0, 10);

        if (createRoad < 7)
        {
            GenerateRoad(roads, x, y, left);
        }

        createRoad = random.Next(0, 10);

        if (createRoad < 7)
        {
            GenerateRoad(roads, x, y, right);
        }
        
    }
    //Creates a static method that initializes with parametres as defined below.
    static void GenerateRoad(bool[,] roads, int startX, int startY, int direction)
    {

        //The program checks if the value of the direction is equal to the value for 'right'.
        if ((direction == right))
        {
            //If the above condition holds true, a loop begins that initializes it's index value, 'x', to
            //the value of 'startX'. This will continue for as long as 'x' is smaller than 'width'. 'x' will
            //increase with one with each iteration of the loop.
            for (int x = startX; x < width; x++)
            {
                //roads will now have the values of 'x' and 'startY'.
                roads[x, startY] = true;
            }
        }

        ////The program checks if the value of the direction is equal to the value for 'down'.
        else if (direction == down)
        {
            //If the above condition holds true, a loop begins that initializes it's index value, 'y', to
            //the value of 'startX'. This will continue for as long as 'y' is smaller than 'width'. 'y' will
            //increase with one with each iteration of the loop.
            for (int y = startY; y < height; y++)
            {
                //roads will now have the values of 'startX' and 'y'.
                roads[startX, y] = true;
            }
        }

        //The program checks if the value of the direction is equal to the value for 'left'.
        else if (direction == left)
        {
            //If the above condition holds true, a loop begins that initializes it's index value, 'x', to
            //the value of 'startX'. This will continue for as long as 'x' is smaller than 0. 'x' will
            //deccrease with one with each iteration of the loop.
            for (int x = startX; x >= 0; x--)
            {
                //roads will now have the values of 'x' and 'startY'.
                roads[x, startY] = true;
            }

        }

        //The program checks if the value of the direction is equal to the value for 'up'.
        else if (direction == up)
        {
            //If the above condition holds true, a loop begins that initializes it's index value, 'y', to
            //the value of 'startY'. This will continue for as long as 'y' is smaller than 'startY'. 'y' will
            //increase with one with each iteration of the loop.
            for (int y = startY; y >= 0; y--)

            {
                //roads will now have the values of 'startX' and 'y'.
                roads[startX, y] = true;
            }
        }

    }

    static void DrawRoads()
    {
        for (int y = 0; y < height; y++)
        {

            //A loop is created. The index valiue is set to 'x'. This loop will continue for as long as 'width' is smaller than 'x'.
            //each iteration of the loop will increase it by one.
            for (int x = 0; x < width; x++)
            {
                //IF the variable 'roads' have the values of 'x,y', the condition will be set to true.
                //The program will write '#'
                if (roads[x, y] == true)
                {
                    Console.Write("#");
                }

                //If the condition is not fulfilled, the program will write '.'
                else
                {
                    Console.Write(".");
                }
            }

            //After the above, the console outputs a new line.
            Console.WriteLine("");
        }
    }

    static string CreateDayDescription(int day, int season, int year)
    {

        //Indicates the indexes for each string to be used. "1" has value '0' for example.
        string[] days = { "1", "14", "25", "30" };
        string[] years = { "1990", "1995", "2000", "2010" };
        string[] seasons = { "Spring", "Fall", "Winter", "Summer" };

        //Makes the console output the following text, with the mustache'd text replaced with the parametre specified in the main.
        return ($"day {days[day]} of {seasons[season]} in year {years[year]}");
    }

    static void InitiateMonsters()
    {
        Console.WriteLine(CreateDayDescription(1, 2, 1));
        Console.WriteLine(CreateDayDescription(3, 2, 3));
        Console.WriteLine(CreateDayDescription(1, 2, 0));
        monsterGen();

        Console.WriteLine("");
    }

    //Creates new string called 'monsterGen'
    static void monsterGen()
    {
        //Sets the int 'monsterAmount' to '0'
        int monsterAmount = 0;

        //creates new string called 'MonsterLevels' with space for 100.
        int[] MonsterLevels = new int[100];

        //Creates new random generator
        var random = new Random();

        //For each element of MonsterLevels, a new iteration of the below loop occurs.
        for (int i = 0; i < MonsterLevels.Length; i++)
        {
            //Creates a random variable called 'monsterAmount'
            monsterAmount = random.Next(1, 51);

            //Stores said variable in the string.
            MonsterLevels[i] = monsterAmount;
        }

        //Sorts the levels in numerical order.
        Array.Sort(MonsterLevels);
        //Writes out each level.
        foreach (int i in MonsterLevels)
        {
            Console.Write($"{i},");
        }
    }


}

