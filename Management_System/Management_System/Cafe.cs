using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management_System
{



    class Cafe
    {    


        //Default Constructor 
        public Cafe()
        {
            newlatte_Coffee = 0.0;
            newespresso_Coffee = 0.0;
            newilatte_Coffee = 0.0;
            newvale_Coffee = 0.0;
            newcapuccino_Coffee = 0.0;
            newicapuccino_Coffee = 0.0;
            newaCoffee_Coffee = 0.0;
            newAmCoffee_Coffee = 0.0;


            newcCake_Cake = 0.0;
            newRCake_Cake = 0.0;
            newBlCake_Cake = 0.0;
            newBSCake_Cake = 0.0;
            newLagosCake_Cake = 0.0;
            newSpCake_Cake = 0.0;
            newCreamyCake_Cake = 0.0;
            newMarritoCake_Cake = 0.0;

        
        }

        //Overloading constructor 

        public Cafe(double latte_Coffee, double espresso_Coffee, double ilatte_Coffee, double vale_Coffee, double capuccino_Coffee, double  icapuccino_Coffee,  double   aCoffee_Coffee, 
            
            double   AmCoffee_Coffee, double  cCake_Cake, double RCake_Cake, double  BlCake_Cake, double   BSCake_Cake, double  LagosCake_Cake, double   SpCake_Cake , double   CreamyCake_Cake , 
            double MarritoCake_Cake) 
        {

                newlatte_Coffee = latte_Coffee;
                newespresso_Coffee = espresso_Coffee;
                newilatte_Coffee = ilatte_Coffee;
                newvale_Coffee = vale_Coffee;
                newcapuccino_Coffee = capuccino_Coffee;
                newicapuccino_Coffee = icapuccino_Coffee;
                newaCoffee_Coffee =   aCoffee_Coffee;
                newAmCoffee_Coffee = AmCoffee_Coffee;

                newcCake_Cake = cCake_Cake;
                newRCake_Cake = RCake_Cake;
                newBlCake_Cake = BlCake_Cake;
                newBSCake_Cake = BSCake_Cake;
                newLagosCake_Cake = LagosCake_Cake;
                newSpCake_Cake = SpCake_Cake;
                newCreamyCake_Cake = CreamyCake_Cake;
                newMarritoCake_Cake = MarritoCake_Cake;
                
                

        }
        // public function  

        public double getlatte_coffee()
        {
            return newlatte_Coffee;
        }
        public double getespresso_Coffee()
        {
            return newespresso_Coffee;
        }

        public double getilatte_Coffee()
        {
            return newilatte_Coffee;
        }

        public double getvale_Coffee()
        {
            return newvale_Coffee;
        }

        public double getcapuccino_Coffee()
        {
            return newcapuccino_Coffee;

        }

        public double geticapuccino_Coffee()
        {
            return newicapuccino_Coffee;
        }
        public double getaCoffee_Coffee()
        {

            return newaCoffee_Coffee;
        }


     

        public double getAmCoffee_Coffee()
        {


            return newAmCoffee_Coffee;

        }

        public double getcCake_Cake ()
        {

                 return  newcCake_Cake;
        }


        public double getRCake_Cake()
        {

            return newRCake_Cake;
        }
        public double getBlCake_Cake()
        {

            return newBlCake_Cake;
        }
        public double getBSCake_Cake()
        {

            return newBSCake_Cake;
        }

        public double getLagosCake_Cake()
        {

            return newLagosCake_Cake;
        }
        public double getCreamyCake_Cake()
        {

            return newCreamyCake_Cake;
        }
        public double getSpCake_Cake()
        {

            return newSpCake_Cake;
        }
        public double getMarritoCake_Cake()
        {

            return newMarritoCake_Cake;
        }
       
        private double newlatte_Coffee;
        private double newespresso_Coffee;

        private double  newilatte_Coffee;
        private double  newvale_Coffee;
        private double  newcapuccino_Coffee;
        private double  newicapuccino_Coffee;
        private double   newaCoffee_Coffee;
        private double   newAmCoffee_Coffee;
               
         //Coffee   
        private double  newcCake_Cake;
        private double  newRCake_Cake ;
        private double  newBlCake_Cake;
        private double   newBSCake_Cake;
        private double  newLagosCake_Cake;
        private double   newSpCake_Cake;
        private double   newCreamyCake_Cake;
        private double newMarritoCake_Cake;
    }
}
