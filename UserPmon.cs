// Pmon
// superclass User
//     l Pmon 
//     l Item 

// superclass Pmon
//     o Name
//     o Level
//     o Type
//     o Health
//     l move
//     *Status*
//     *Attributes*

// superclass Move
//     Name
//     Type
//     Power
//     *Accuracy*

// superclass Item
//     o Name
//     v Description*
//     o Effect
//     *Type*
using System;
using System.Collections.Generic;


namespace MyG{
    class Start {



            // Dictionary<string,string[]> Weak_Pairings;
            // Dictionary<string,string[]> Strong_Pairings;


        static void Main() {
            Dictionary<string,string[]> Weak_Pairings = new Dictionary<string, string[]>();
            Dictionary<string,string[]> Strong_Pairings = new Dictionary<string, string[]>();
            populate_dictionaries(Weak_Pairings, Strong_Pairings);
            var Pokemon = new Pmon("Pikachu");
            var Pokemon2 = new Pmon("Bulbasaur");
            var User = new User("Ash");
            User.Pmanager.Add(Pokemon);
            User.Pmanager.Add(Pokemon2);

            foreach (Pmon pmon in User.Pmanager){
                Console.WriteLine(pmon.name+":");
            }
            foreach (KeyValuePair<string,string[]> entry in Weak_Pairings){
                Console.WriteLine(entry.Key);
                foreach (var it in entry.Value){
                    Console.WriteLine(it);
                }
            }

        }

        static public void populate_dictionaries(Dictionary<string,string[]> Weak_Pairings,Dictionary<string,string[]> Strong_Pairings){
            Weak_Pairings["Fire"] = new string[] {"Water","test1"};
            Weak_Pairings["Grass"] = new string[] {"Fire"};
            Weak_Pairings["Water"] = new string[] {"Grass"};
            Strong_Pairings["Fire"] = new string[] {"Grass"};
            Strong_Pairings["Grass"] = new string[] {"Water"};
            Strong_Pairings["Water"] = new string[] {"Fire"};
        }


        public class Level {
            public int currentlvl {get; set;}
            public int startinglvl {get; set;}
            public Level (){
            }
        }

        public class Pmon : Itype{

            Ptype type = new Ptype();

            public string t_name {
                get{ return type.t_name;}
                set{ type.t_name = value;}
            }


            public string name {get; set;}
            public int lvl {get; set;}
            public int startinglvl {get; set;}

            public Pmon(string name){
                this.name = name;
            }
        }

        public class User {
            public string name {get; set;}
            public List<Pmon> Pmanager {get; set;}

            public User(string name){
                this.name = name;
                this.Pmanager = new List<Pmon>();
            }



        }    
        public interface Itype{
            string t_name{ get; set;}
        }
        public class Ptype : Itype{
            public string t_name {get; set;}

            public Ptype(){

            }

            public Ptype(string type){
                t_name = type;
            }
        }



    }

}







