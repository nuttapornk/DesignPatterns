using DesignPatterns.Memento.Models;
using DesignPatterns.Memento.Services;
using System;

namespace DesignPatterns.Memento
{

    class Program
    {
        static void Main(string[] args)
        {
            var stateManager = new CareTaker<Editor>();
            var e1 = new Editor("T1", "TEXT1", 14, "TH SarabunPSK");
            stateManager.Add(e1.GetState());

            e1.Text = "TEXT2";
            stateManager.Add(e1.GetState());

            e1.FontSize = 15;
            stateManager.Add(e1.GetState());

            e1.FontFace = "Tahoma";
            stateManager.Add(e1.GetState());

            e1.FontFace = "TH Sarabun New";
            stateManager.Add(e1.GetState());

            stateManager.Undo();
            var x = stateManager.Undo();
            stateManager.Add(x);
            e1.SetState(x);
            //stateManager.Undo();

            
            Console.WriteLine(e1);
        }
    }
}
