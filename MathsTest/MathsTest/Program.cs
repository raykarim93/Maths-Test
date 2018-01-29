using System;

namespace MathsTest
{
    class Program
    {
        static int Start() // the start menu
        {
            int start = 0;

            bool answerone = false; // loop if the input (answerone) is wrong
            do // start loof
            {
                answerone = false;
                Console.ForegroundColor = ConsoleColor.Black; // text colour balck
                Console.BackgroundColor = ConsoleColor.White; // text backgroung colour white
                Console.WriteLine("         1. Begin Test        "); // display text
                Console.WriteLine("         2. Help              ");
                Console.WriteLine("         3. Exit              ");
                Console.ResetColor(); //end text/background colour
                Console.ForegroundColor = ConsoleColor.Cyan; // text colour cyan
                string read = Console.ReadLine(); // read input and sign it to string
                Console.ResetColor(); // end text colour

                try // try and catch if user is not entering number
                {
                    start = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    answerone = false;
                }
                if ((start < 1) || (start > 3)) //checks if the user's input is valid
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 3");
                    Console.ResetColor();
                    answerone = false;
                }

            } while (answerone == false);// while loop is the above is false
            return start; //returns the value to start
        }
        static void Name()// Ask user for their name
        {
            Console.WriteLine("Please enter your name ");
        }
        static int Level()//ask user for their level
        {
            int level = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            string StudentName = Console.ReadLine();
            Console.ResetColor();


            bool answerone = false;// loop if the input (answerone) is wrong
            do
            {
                answerone = false;
                Console.WriteLine("Hello {0}, please enter your level", StudentName);
                Console.WriteLine("     1. Level 1");
                Console.WriteLine("     2. Level 2");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string read = Console.ReadLine();
                Console.ResetColor();
                try// try and catch if user is not entering number
                {
                    level = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    answerone = false;
                }
                if ((level < 1) || (level > 2))//checks if the user's input is valid
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 2");
                    Console.ResetColor();
                    answerone = false;
                }

            } while (answerone == false);// while loop is the above is false
            return level; //returns the value to level

        }
        static int Menu()// ask user what category they want to dp
        {
            int menu = 0;

            bool answerone = false;
            do
            {
                answerone = false;
                Console.WriteLine("Please select from the followings");
                Console.WriteLine("     1. Addition");
                Console.WriteLine("     2. Subtraction");
                Console.WriteLine("     3. Multiplication");
                Console.WriteLine("     4. Division");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string read = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    menu = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    answerone = false;
                }
                if ((menu < 1) || (menu > 4))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 4");
                    Console.ResetColor();
                    answerone = false;
                }

            } while (answerone == false);
            return menu;
        }
        static void Help()// showing some help and tips
        {
            Console.WriteLine("Please enter your name ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string StudentName = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================================================================================================");
            Console.ResetColor();
            Console.WriteLine("                         Hello {0}, Welcome To The Help Menu", StudentName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================================================================================================");
            Console.ResetColor();
            Console.WriteLine("This Program is to help improve your maths skills and see which area you are good at.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Your teacher should give you the level you need to do,");
            Console.WriteLine("if you don't know what level you are at please ask your teacherYour teacher should give");
            Console.WriteLine("you the level you need to do, if you don't know what level you are at please ask your teacher.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("This program will test your skills on Addition, Subtraction, Multiplication and Division.");
            Console.WriteLine("You can pick any of the category in any order you prefer.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("End of every test it will display if you have achieved over 75% or not.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================================================================================================");
            Console.ResetColor();
        }
        static void GoodBye()// graphical goodbye
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                                                                                                                     ");
            Console.WriteLine("                                                                   DDDDDDDD                                                                          ");
            Console.WriteLine("        GGGGGGGGGGGGG                                              D::::::D     BBBBBBBBBBBBBBBBB                                                    ");
            Console.WriteLine("     GGG::::::::::::G                                              D::::::D     B::::::::::::::::B                                                   ");
            Console.WriteLine("   GG:::::::::::::::G                                              D::::::D     B::::::BBBBBB:::::B                                                  ");
            Console.WriteLine("  G:::::GGGGGGGG::::G                                              D:::::D      BB:::::B     B:::::B                                                 ");
            Console.WriteLine(" G:::::G       GGGGGG   OOOOOOOOOO       OOOOOOOOOOO       DDDDDDDDD:::::D        B::::B     B:::::BYYYYYYY           YYYYYYY    EEEEEEEEEEEE        ");
            Console.WriteLine("G:::::G               OO:::::::::::OO  OO:::::::::::OO   DD::::::::::::::D        B::::B     B:::::B Y:::::Y         Y:::::Y   EE::::::::::::EE      ");
            Console.WriteLine("G:::::G              O:::::::::::::::OO:::::::::::::::O D::::::::::::::::D        B::::BBBBBB:::::B   Y:::::Y       Y:::::Y   E::::::EEEEE:::::EE    ");
            Console.WriteLine("G:::::G    GGGGGGGGGGO:::::OOOOO:::::OO:::::OOOOO:::::OD:::::::DDDDD:::::D        B:::::::::::::BB     Y:::::Y     Y:::::Y   E::::::E     E:::::E    ");
            Console.WriteLine("G:::::G    G::::::::GO::::O     O::::OO::::O     O::::OD::::::D    D:::::D        B::::BBBBBB:::::B     Y:::::Y   Y:::::Y    E:::::::EEEEE::::::E    ");
            Console.WriteLine("G:::::G    GGGGG::::Go::::O     O::::OO::::O     O::::OD:::::D     D:::::D        B::::B     B:::::B     Y:::::Y Y:::::Y     E:::::::::::::::::E     ");
            Console.WriteLine("G:::::G        G::::GO::::O     O::::OO::::O     O::::OD:::::D     D:::::D        B::::B     B:::::B      Y:::::Y:::::Y      E::::::EEEEEEEEEEE      ");
            Console.WriteLine(" G:::::G       G::::GO::::O     O::::OO::::O     O::::OD:::::D     D:::::D        B::::B     B:::::B       Y:::::::::Y       E:::::::E               ");
            Console.WriteLine("  G:::::GGGGGGGG::::GO:::::OOOOO:::::OO:::::OOOOO:::::OD::::::DDDDD::::::DD     BB:::::BBBBBB::::::B        Y:::::::Y        E::::::::E              ");
            Console.WriteLine("   GG:::::::::::::::GO:::::::::::::::OO:::::::::::::::O D:::::::::::::::::D     B:::::::::::::::::B          Y:::::Y          E::::::::EEEEEEEE      ");
            Console.WriteLine("     GGG::::::GGG:::G OO:::::::::::OO  OO:::::::::::OO   D:::::::::DDD::::D     B::::::::::::::::B          Y:::::Y            EE:::::::::::::E      ");
            Console.WriteLine("        GGGGGG   GGGG   OOOOOOOOOOO      OOOOOOOOOOO      DDDDDDDDD   DDDDD     BBBBBBBBBBBBBBBBB          Y:::::Y               EEEEEEEEEEEEEE      ");
            Console.WriteLine("                                                                                                          Y:::::Y                                    ");
            Console.WriteLine("                                                                                                         Y:::::Y                                     ");
            Console.WriteLine("                                                                                                        Y:::::Y                                      ");
            Console.WriteLine("                                                                                                       Y:::::Y                                       ");
            Console.WriteLine("                                                                                                      YYYYYYY                                        ");
            Console.WriteLine("                                                                                                                                                     ");
            Console.WriteLine("                                                                                                                                                     ");
            Console.ResetColor();
        }
        static int Redo1()
        {
            int redo = 0;

            bool answerone = false;
            do
            {
                answerone = false;
                Console.WriteLine(" ");
                Console.WriteLine("Please select from the followings");
                Console.WriteLine("     1. Go Back To The Menu");
                Console.WriteLine("     2. Exit");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string read = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    redo = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    answerone = false;
                }
                if ((redo < 1) || (redo > 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 2");
                    Console.ResetColor();
                    answerone = false;
                }

            } while (answerone == false);
            return redo;
        }
        static int Redo2()
        {
            int redo = 0;

            bool answerone = false;
            do
            {
                answerone = false;
                Console.WriteLine(" ");
                Console.WriteLine("Please select from the followings");
                Console.WriteLine("     1. Go Back To The Start");
                Console.WriteLine("     2. Exit");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string read = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    redo = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    answerone = false;
                }
                if ((redo < 1) || (redo > 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 2");
                    Console.ResetColor();
                    answerone = false;
                }

            } while (answerone == false);
            return redo;
        }

        static void IssueResponseRight()//show response if user gets the answer right
        {
            Random rnd = new Random();
            int rightans = rnd.Next(0, 4);
            switch (rightans)          // random switch statment
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Well Done!!"); Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Great Job!!"); Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You got it!!"); Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Genius!!"); Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("5*!!"); Console.ResetColor();
                    break;
            }
            Console.WriteLine("                    ");
        }
        static void IssueResponseWrong()//show response if user gets the answer right
        {
            Random rnd = new Random();
            int wrongans = rnd.Next(0, 3);
            switch (wrongans)  // random switch statment
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Sorry, please try agrain."); Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Wrong answer, please try agrain."); Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please try again"); Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Good effort but the answer is wrong, please try agrain."); Console.ResetColor();
                    break;
            }
            Console.WriteLine("                    ");
        }

        static void RandomnumberLvOne(ref int randomnumberlevelOneOne, ref int randomnumberlevelOneTwo)// random number generator for level 1
        {
            Random rnd = new Random();
            randomnumberlevelOneOne = rnd.Next(0, 9);
            randomnumberlevelOneTwo = rnd.Next(0, 9);
        }
        static void RandomnumberLvTwo(ref int randomnumberlevelTwoOne, ref int randomnumberlevelTwoTwo)// random number generator for level 2
        {
            Random rnd = new Random();
            randomnumberlevelTwoOne = rnd.Next(10, 99);
            randomnumberlevelTwoTwo = rnd.Next(10, 99);
        }

        static void Percentage(int score)// calculate the percentage (the the score from Main)
        {
            int percentage = score * 10; // percentage is equle to score x 10
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your score is {0}% ", percentage);
            Console.ResetColor();
            if (percentage >= 75) // if the the percentage is equle to or grater then 75 display message below
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have achieved more than 75%."); // message
                Console.ResetColor();
            }
            else // if it is not grater or equle to 75 75 display message below
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have achieved less than 75%. Please ask your teacher for extra help."); // message
                Console.ResetColor();
            }
        }

        static int Addition(int NumberOne, int NumberTwo) // take int NumberOne and int NumberTwo from qLevel1Addition or qLevel2Addition
        {
            int useranswer = 0;
            Console.WriteLine("What is {0} + {1}", NumberOne, NumberTwo); // ask user [What is {NumberOne} + {NumberTwo}]
            Console.ForegroundColor = ConsoleColor.Cyan;
            string read = Console.ReadLine(); // take the users answer and put it to string [read]
            Console.ResetColor();

            bool answerone = false; // bool means I can choose whether a bit of code is true or false.
            do
            {
                try
                {
                    useranswer = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    read = Console.ReadLine();
                    Console.ResetColor();
                    answerone = false;
                }
            } while (answerone == false); // untill the answerone is true loop
            return useranswer; // return useranswer
        }
        static int Subtraction(int NumberOne, int NumberTwo) // take int NumberOne and int NumberTwo from qLevel1Subtraction or qLevel2Subtraction
        {
            int useranswer = 0;
            Console.WriteLine("What is {0} - {1}", NumberOne, NumberTwo); // ask user [What is {NumberOne} - {NumberTwo}]
            Console.ForegroundColor = ConsoleColor.Cyan;
            string read = Console.ReadLine(); // take the users answer and put it to string [read]
            Console.ResetColor();

            bool answerone = false;// bool means I can choose whether a bit of code is true or false.
            do
            {
                try
                {
                    useranswer = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    read = Console.ReadLine();
                    Console.ResetColor();
                    answerone = false;
                }
            } while (answerone == false); // untill the answerone is true loop
            return useranswer; // return useranswer
        }
        static int Multiplication(int NumberOne, int NumberTwo) // take int NumberOne and int NumberTwo from qLevel1Multiplication or qLevel2Multiplication
        {
            int useranswer = 0;
            Console.WriteLine("What is {0} X {1}", NumberOne, NumberTwo); // ask user [What is {NumberOne} x {NumberTwo}]
            Console.ForegroundColor = ConsoleColor.Cyan;
            string read = Console.ReadLine(); // take the users answer and put it to string [read]
            Console.ResetColor();
            bool answerone = false;// bool means I can choose whether a bit of code is true or false.
            do
            {
                try
                {
                    useranswer = Convert.ToInt32(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!!!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    read = Console.ReadLine();
                    Console.ResetColor();
                    answerone = false;
                }
            } while (answerone == false); // untill the answerone is true loop
            return useranswer; // return useranswer
        }
        static double Division(double NumberOne, double NumberTwo) // take double NumberOne and double NumberTwo from qLevel1Division or qLevel2Division
        {
            double useranswer = 0;
            Console.WriteLine("What is {0} ÷ {1}", NumberOne, NumberTwo); // ask user [What is {NumberOne} ÷ {NumberTwo}]
            Console.ForegroundColor = ConsoleColor.Cyan;
            string read = Console.ReadLine(); // take the users answer and put it to string [read]
            Console.ResetColor();
            bool answerone = false;// bool means I can choose whether a bit of code is true or false.
            do
            {
                try
                {
                    useranswer = Convert.ToDouble(read);
                    answerone = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number with decimal!!!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    read = Console.ReadLine();
                    Console.ResetColor();
                    answerone = false;
                }
            } while (answerone == false); // untill the answerone is true loop
            return useranswer; // return useranswer
        }

        static void qLevel1Addition()
        {
            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelOneOne = 0;
            int randomnumberlevelOneTwo = 0;

            do
            {
                numberofquestions++; // add one to [numberofquestions]

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions); // display questions number
                Console.ResetColor();
                RandomnumberLvOne(ref randomnumberlevelOneOne, ref randomnumberlevelOneTwo); // take [randomnumberlevelOneOne] and  [randomnumberlevelOneTwo] from  [RandomnumberLvOne]

                int numberOne = randomnumberlevelOneOne; // [randomnumberlevelOneOne] from  [RandomnumberLvOne] and assign it to [numberOne]
                int numberTwo = randomnumberlevelOneTwo; // [randomnumberlevelOneTwo] from  [RandomnumberLvOne] and assign it to [numberOne]
                int userAnswer = Addition(numberOne, numberTwo); // take the return value of [Addition(numberOne, numberTwo)] and assign it to [userAnswer]
                int answer = numberOne + numberTwo; // add numberOne and numberTwo and assign it to answer
                if (userAnswer == answer)
                { // if the useranswer is same as answer then [IssueResponseRight] and add 1 to [score]
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }

                else // if it is not
                {

                    int numberoftries = 1;

                    IssueResponseWrong(); // display [IssueResponseWrong]

                    do
                    {

                        userAnswer = Addition(numberOne, numberTwo);
                        answer = numberOne + numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();

                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++; // add 1 to [numberoftries]
                    }
                    while (numberoftries < 3); // keep looping untill [numberoftries] is less the 3
                    Console.WriteLine("The correct answer is {0}", answer); // display the right asnwer
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10); // loop this 10 times
            Percentage(score);// display percentage
        }
        static void qLevel2Addition()
        {
            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelTwoOne = 0;
            int randomnumberlevelTwoTwo = 0;

            do
            {
                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvTwo(ref randomnumberlevelTwoOne, ref randomnumberlevelTwoTwo);
                int numberOne = randomnumberlevelTwoOne;
                int numberTwo = randomnumberlevelTwoTwo;
                int userAnswer = Addition(numberOne, numberTwo);
                int answer = numberOne + numberTwo;
                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }
                else
                {

                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {

                        userAnswer = Addition(numberOne, numberTwo);
                        answer = numberOne + numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();

                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10);
            Percentage(score);// percentage
        }
        static void qLevel1Subtraction()
        {

            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelOneOne = 0;
            int randomnumberlevelOneTwo = 0;


            do
            {
                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvOne(ref randomnumberlevelOneOne, ref randomnumberlevelOneTwo);
                int numberOne = randomnumberlevelOneOne;
                int numberTwo = randomnumberlevelOneTwo;
                int userAnswer = Subtraction(numberOne, numberTwo);
                int answer = numberOne - numberTwo;

                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }
                else
                {

                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {

                        userAnswer = Subtraction(numberOne, numberTwo);
                        answer = numberOne - numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();

                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10);

            Percentage(score);// percentage
        }
        static void qLevel2Subtraction()
        {
            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelTwoOne = 0;
            int randomnumberlevelTwoTwo = 0;

            do
            {
                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvTwo(ref randomnumberlevelTwoOne, ref randomnumberlevelTwoTwo);
                int numberOne = randomnumberlevelTwoOne;
                int numberTwo = randomnumberlevelTwoTwo;
                int userAnswer = Subtraction(numberOne, numberTwo);
                int answer = numberOne - numberTwo;
                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }
                else
                {
                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {
                        userAnswer = Subtraction(numberOne, numberTwo);
                        answer = numberOne - numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();
                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10);
            Percentage(score);// percentage
        }
        static void qLevel1Multiplication()
        {

            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelOneOne = 0;
            int randomnumberlevelOneTwo = 0;


            do
            {
                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvOne(ref randomnumberlevelOneOne, ref randomnumberlevelOneTwo);
                int numberOne = randomnumberlevelOneOne;
                int numberTwo = randomnumberlevelOneTwo;
                int userAnswer = Multiplication(numberOne, numberTwo);
                int answer = numberOne * numberTwo;

                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }
                else
                {

                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {

                        userAnswer = Multiplication(numberOne, numberTwo);
                        answer = numberOne * numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();

                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10);

            Percentage(score);// percentage
        }
        static void qLevel2Multiplication()
        {
            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelTwoOne = 0;
            int randomnumberlevelTwoTwo = 0;

            do
            {
                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvTwo(ref randomnumberlevelTwoOne, ref randomnumberlevelTwoTwo);
                int numberOne = randomnumberlevelTwoOne;
                int numberTwo = randomnumberlevelTwoTwo;
                int userAnswer = Multiplication(numberOne, numberTwo);
                int answer = numberOne * numberTwo;
                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }
                else
                {
                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {
                        userAnswer = Multiplication(numberOne, numberTwo);
                        answer = numberOne * numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();
                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10);
            Percentage(score);// percentage
        }
        static void qLevel1Division()
        {

            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelOneOne = 0;
            int randomnumberlevelOneTwo = 0;


            do
            {

                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvOne(ref randomnumberlevelOneOne, ref randomnumberlevelOneTwo);
                double numberOne = randomnumberlevelOneOne;
                double numberTwo = randomnumberlevelOneTwo;
                double userAnswer = Division(numberOne, numberTwo);
                double answer = numberOne / numberTwo;

                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                    score++;
                }
                else
                {

                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {

                        userAnswer = Division(numberOne, numberTwo);
                        answer = numberOne / numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();

                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=================================");
                    Console.ResetColor();
                }
            } while (numberofquestions < 10);

            Percentage(score);// percentage
        }
        static void qLevel2Division()
        {
            int numberofquestions = 0;
            int score = 0;
            int randomnumberlevelTwoOne = 0;
            int randomnumberlevelTwoTwo = 0;

            do
            {
                numberofquestions++;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("         Question No. {0}         ", numberofquestions);
                Console.ResetColor();
                RandomnumberLvTwo(ref randomnumberlevelTwoOne, ref randomnumberlevelTwoTwo);
                double numberOne = randomnumberlevelTwoOne;
                double numberTwo = randomnumberlevelTwoTwo;
                double userAnswer = Division(numberOne, numberTwo);
                double answer = numberOne / numberTwo;

                if (userAnswer == answer)
                {
                    IssueResponseRight();
                    score++;
                }
                else
                {

                    int numberoftries = 1;
                    IssueResponseWrong();

                    do
                    {

                        userAnswer = Division(numberOne, numberTwo);
                        answer = numberOne / numberTwo;

                        if (userAnswer == answer)
                        {
                            IssueResponseRight();

                        }
                        else
                        {
                            IssueResponseWrong();
                        }
                        numberoftries++;
                    }
                    while (numberoftries < 3);
                    Console.WriteLine("The correct answer is {0}", answer);
                }
            } while (numberofquestions < 10);
        }

        static void Main(string[] args)
        {
            int redo = 0; // redo the questions to category menu
            int redoTwo = 0; // redo the help to start menu

            do
            {

                int start = Start();

                if (start == 3)// Exit
                {
                    GoodBye();//This code means that if you enter 3 an GoodBye message will appear on the screen.
                }
                else if (start == 2)// Help
                {
                    Help(); //This code means that if you enter 2 an help menu will appear on the screen.
                    redoTwo = Redo2(); //This code will show the redo2 methord
                }
                else if (start == 1)//category menu
                {
                    Name();
                    int getLevel = Level();// user level
                    do
                    {
                        int getMenu = Menu();

                        // Level 1 Addition            
                        if (getLevel == 1 && getMenu == 1) //This code means that if you select level 1 and select category menu 1 the Addition level 1 quistions will appear on the screen.
                        {
                            qLevel1Addition();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 2 Addition
                        if (getLevel == 2 && getMenu == 1) //This code means that if you select level 2 and select category menu 1 the Addition level 2 quistions will appear on the screen.
                        {
                            qLevel2Addition();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 1 Subtraction
                        if (getLevel == 1 && getMenu == 2) //This code means that if you select level 1 and select category menu 2 the Subtraction level 1 quistions will appear on the screen.
                        {
                            qLevel1Subtraction();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 2 Subtraction
                        if (getLevel == 2 && getMenu == 2) //This code means that if you select level 2 and select category menu 2 the Subtraction level 2 quistions will appear on the screen.
                        {
                            qLevel2Subtraction();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 1 Multiplication
                        if (getLevel == 1 && getMenu == 3) //This code means that if you select level 1 and select category menu 3 the Multiplication level 1 quistions will appear on the screen.
                        {
                            qLevel1Multiplication();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 2 Multiplication
                        if (getLevel == 2 && getMenu == 3) //This code means that if you select level 2 and select category menu 3 the Multiplication level 2 quistions will appear on the screen.
                        {
                            qLevel2Multiplication();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 1 Division
                        if (getLevel == 1 && getMenu == 4) //This code means that if you select level 1 and select category menu 4 the Division level 1 quistions will appear on the screen.
                        {
                            qLevel1Division();
                            redo = Redo1(); //This code will show the redo1 methord
                        }
                        // Level 2 Division
                        if (getLevel == 2 && getMenu == 4) //This code means that if you select level 2 and select category menu 4 the Division level 2 quistions will appear on the screen.
                        {
                            qLevel2Division();
                            redo = Redo1(); //This code will show the redo1 methord

                        }
                    } while (redo == 1); // while loop for the questions to category menu
                    if (redo == 2)
                    {
                        GoodBye();
                    }
                }
            } while (redoTwo == 1); // while loop for the help to start menu

            if (redoTwo == 2) //This code means that if you enter 2 after each quistions the program will display GoodBye and exit
            {
                GoodBye();
            }
        }

    }
}
