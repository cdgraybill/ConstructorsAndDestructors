using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAndDestructorExercise
{
    class Atom
    {
        public int Protons { get; set; }
        public int Electrons { get; set; }
    }

    class DestroyAtom
    {
        ~DestroyAtom()
        {
            Console.WriteLine("Oh no");
        }
    }
}
