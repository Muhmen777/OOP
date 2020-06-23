using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Aircraft
    {
        //Instance variabler
        private string airline;
        private int passengers;
        private int model;

        //Properties
        public string Airline
        {
            get { return airline; }     //Get
            set { airline = value; }    //Set value
        }
        //Properties
        public int Passengers
        {
            get { return passengers; }  //Get
            set { passengers = value; } //Set value
        }
        //Properties
        public int Model    
        {
            get { return model; }   //Get
            set { model = value; }  //Set value
        }

    }
}
