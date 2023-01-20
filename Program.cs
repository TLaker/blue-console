using System;

namespace blueConsole{

    struct Vector2{
            public int posX;
            public int posY;
        }
    public class MainClass{
        static char star = '*', space = '\x20';
    	static int number = 0;
        static Vector2 vector2;

        static int validateInput(){
            int number = 0;
            try{
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception){
                Console.WriteLine("Invalid entry!");
                number = validateInput();
            }
            return number;
        }

        static void requestInput(){
            Console.WriteLine("Enter the height of the pyramid: ");
            number = validateInput();

            Console.WriteLine("Enter the Vector2 for the hidden char.");
            Console.WriteLine("PosY: ");
            vector2.posY = validateInput();
            Console.WriteLine("PosX: ");
            do{
                vector2.posX = validateInput();
                if(!(vector2.posY >= vector2.posX)){
                    Console.WriteLine("PosX must not be smaller than PosY");
                }
                else if(!(vector2.posY <= number)){
                    Console.WriteLine("PosY must not be smaller than the height of the pyramid.");
                }
            }
            while(!(vector2.posY >= vector2.posX && vector2.posY <= number));
        }

        static void buildPyramid(){
            int t = number - 1;

            for(int i = 0; i < number; i++){
                for(int h = 0; h < t; h++){
                    Console.Write(space);
                }
                for(int j = 0; j <= i; j++){
                    if(i == vector2.posY-1 && j == vector2.posX-1){
                        Console.Write('"');
                        Console.Write(space);
                    }
                    else{
                    Console.Write(star);
                    Console.Write(space);
                    }
                }
                t--;
                Console.Write('\n');
            }
        }

        static void Main(){
            
            //Console.BackgroundColor = ConsoleColor.DarkBlue;

            requestInput();
            buildPyramid();

            
        }
    }
}