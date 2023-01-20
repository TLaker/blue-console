using System;

namespace blueConsole{

    public class MainClass{

        static void doPyramid(){
            Console.Write('\n');
            Pyramid pyramid = new Pyramid();
            pyramid.requestInput();
            pyramid.buildPyramid();
        }

        static void doEvent(){
            Console.Write('\n');
            ListChanged list = new ListChanged();
            Listener listener = new Listener(list);
            list.Add("element");
        }

        static void letChoose(){
            Console.WriteLine("Choose a task by pressing the specific key.");
            Console.WriteLine("Press q to exit.");
            Console.WriteLine("Press 1 to create a pyramid of stars.");
            Console.WriteLine("Press 2 to create an example for an event listener.");
            char input = Console.ReadKey().KeyChar;
            int id = 0;
            try{
                if(input == 'q' || input == 'Q'){
                    Environment.Exit(0);
                }
                id = Convert.ToInt32(input.ToString());
                if(id < 1 || id > 5){
                    System.Console.WriteLine("\nInvalid input. Only integers from 1 to 2 are accepted.");
                    letChoose();
                }
            }
            catch(Exception){
                System.Console.WriteLine("\nInvalid input. Only integers from 1 to 2 are accepted.");
                letChoose();
            }

            switch(id){
                case 1:
                    doPyramid();
                    break;
                case 2:
                    doEvent();
                    break;
            }
            letChoose();
        }

        static void Main(){
            
            //Console.BackgroundColor = ConsoleColor.DarkBlue;

            letChoose();
            
        }
    }
}