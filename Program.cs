using System;
using System.Collections;

namespace blueConsole{

    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public class ListChanged : ArrayList{
        public event ChangedEventHandler? changed;

        protected virtual void OnChanged(EventArgs e){
            if(changed != null){
                changed(this, e);
            }
        }

        public override int Add(object? value)
        {
            OnChanged(EventArgs.Empty);
            return base.Add(value);
        }
    }

    public class MainClass{

        static void doPyramid(){
            Pyramid pyramid = new Pyramid();
            pyramid.requestInput();
            pyramid.buildPyramid();
        }

        static void Main(){
            
            //Console.BackgroundColor = ConsoleColor.DarkBlue;

            
            
        }
    }
}