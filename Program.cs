using System;//S0287, Program #1, 2/16/2021, CIS 199-02

namespace Program_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //constant variables
            const int FeetToYards = 9;//constant int for feet to yards conversion
            const double Labor_Cost_Per_Yd = 3.25;//constant ariable for labor cost per yard
            const double Fertilizer_Cost_Per_Yd = 4.25;//constant variable for fertalizer cost per yard
            const double FIRSTGARDEN = 50.00;//constant variable of cost for first garden job
            const double SOILWASTE = 10.0;//constant variable for waste with extra soil
           


            //other key variables
            double width = 0.0;//variable represents width in the program
            double length = 0.0;//variable represents length in the program
            double Soil_Per_Sq_Yd = 0.0;//variable represents soil per square yard in the program
            int fertilizer; //interger for fertilizer in the program
            int firstGarden;//interger for first garden job in the program
        


            //prompt user and gather info
            Console.WriteLine("Welcome to the EZ-Garden and Landscaping Costs Estimator:");//Writes the welcoming line to the program 
            Console.WriteLine("Enter the max width of the garden (in feet):");//Writes the entering slot for width of garden in feet
            width = double.Parse(Console.ReadLine());//Reads width per square yard line 
            if (width > 0.0)//If statement for width
            Console.WriteLine("Enter the max length of the garden (in feet):");//Writes out max length in the program
            length = double.Parse(Console.ReadLine());//Reads length per square yard line
            if (length > 0.0)//If statement for length
            Console.WriteLine("Enter the soil price (per sq. yard):");//Writes out soil price in program
            Soil_Per_Sq_Yd = double.Parse(Console.ReadLine());//Reads soil per square yard line
            if (Soil_Per_Sq_Yd > 0.0)//If statement for soil per square yard
            


            //gather all the other inputs
            Console.WriteLine("Enter the whether fertilizer is needed (1 = YES, 0 = NO):");//Writes line asking if fertilizer is needed
            fertilizer = Convert.ToInt32(Console.ReadLine());//Reads fertilizer line and converts
            if(fertilizer==0 || fertilizer==1)//If statement for incluion of fertilizer 
            Console.WriteLine("Is this the first garden? (1 = YES, 0 = NO):");//Writes line asking question about first garden
            firstGarden = Convert.ToInt32(Console.ReadLine());//Reads first garden line and converts
            if(firstGarden==0 || firstGarden==1)//If statement for first garden job

            //perform calculations
            Math.Round((width * length) / 9, 1);//Calculates square yards in program
            double extraSoil = Soil_Per_Sq_Yd * (FeetToYards * (1 + SOILWASTE / 100));//Calculates cost of soil in the program
            double extraFertilizer = fertilizer * Fertilizer_Cost_Per_Yd * FeetToYards * (1 + SOILWASTE / 100);//Calculates cost of fertilizer in the program
            double laborCost = fertilizer * FeetToYards * Labor_Cost_Per_Yd;//Calculates labor cost in the program
            double firstGardenCost = firstGarden == 0 ? FIRSTGARDEN : 0.0;//Calculates first garden cost in program
            double totalCost = extraSoil + extraFertilizer + laborCost + firstGardenCost;//Calculates total cost in the program


            //output results
            Console.WriteLine("{0,20}{1,20}{2,20}{3,20}", "SOIL COST", "FERTILIZERCOST", "LABORCOST", "TOTALCOST");//displays category names 
            Console.WriteLine("{0,20}{1,20}{2,20}{3,20}",extraSoil.ToString("C0"),extraFertilizer.ToString("C0"),laborCost.ToString("C0"),totalCost.ToString("C0"));//creates strings for category names

            //write line
            Console.WriteLine($"Total Cost: {totalCost,10:C}");//Writes numbers in dollar currency form

        }
    }
}

