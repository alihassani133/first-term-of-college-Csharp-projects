using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    public class QuestionFoodHandler
    {
        private readonly Input input = new();
        public List<string> QuestionsList = new()
        {
        /*0*/ "Do you want fast food? ",
        /*1*/ "Do you want traditional food? ",
        /*2*/ "Do you want pizza? ",
        /*3*/ "Do you want sandwich ",
        /*4*/ "Do you want Kebab? ",
        /*5*/ "Do you want Khoresht? ",
        /*6*/ "Do you want Pepperoni? ",
        /*7*/ "Do you want Baken pizza? ",
        /*8*/ "Do you want Bandari? ",
        /*9*/ "Do you want Falafel? ",
        /*10*/ "Do you want Koobideh? ",
        /*11*/ "Do you want Joojeh? ",
        /*12*/ "Do you want Ghorme-Sabzi? ",
        /*13*/ "Do you want Gheymeh? "
        };
        readonly string programReply1 = "Here you are!" + "\n" +
                       "If you want to choose again press y(yes) otherwise press n(no): ";

        readonly string programReply2 = "We only have the mentioned food, " +
                               "we don't have anything else." + "\n" +
                               "If you want to choose again press y(yes) otherwise press n(no): ";
        public void FastFoodCheck()
        {
            Console.Write(QuestionsList[2]);
            switch (input.GetAnswer())
            {
                //Pizza check
                case "Y":
                    Console.Write(QuestionsList[6]);
                    switch (input.GetAnswer())
                    {
                        case "Y":
                            Console.Write(programReply1);
                            break;
                        case "N":
                            Console.Write(QuestionsList[7]);
                            Console.Write(input.GetAnswer() == "Y" ? programReply1 : programReply2);
                            break;
                    }
                    break;

                //Sandwich check
                case "N":
                    Console.Write(QuestionsList[3]);
                    switch (input.GetAnswer())
                    {
                        case "Y":
                            Console.Write(QuestionsList[8]);
                            switch (input.GetAnswer())
                            {
                                case "Y":
                                    Console.Write(programReply1);
                                    break;
                                case "N":
                                    Console.Write(QuestionsList[9]);
                                    Console.Write(input.GetAnswer() == "Y" ? programReply1 : programReply2);
                                    break;
                            }
                            break;
                        case "N":
                            Console.Write(programReply2);
                            break;
                    }
                    break;

            }
        }

        public void TraditionalCheck()
        {
            Console.Write(QuestionsList[1]);
            switch (input.GetAnswer())
            {
                case "Y":
                    //Kebab Check
                    Console.Write(QuestionsList[4]);
                    switch (input.GetAnswer())
                    {
                        case "Y":
                            Console.Write(QuestionsList[10]);
                            switch (input.GetAnswer())
                            {
                                case "Y":
                                    Console.Write(programReply1);
                                    break;
                                case "N":
                                    Console.Write(QuestionsList[11]);
                                    Console.Write(input.GetAnswer() == "Y" ? programReply1 : programReply2);
                                    break;
                            }
                            break;

                        //Khoresht Check
                        case "N":
                            Console.Write(QuestionsList[5]);
                            switch (input.GetAnswer())
                            {
                                case "Y":
                                    Console.Write(QuestionsList[12]);
                                    switch (input.GetAnswer())
                                    {
                                        case "Y":
                                            Console.Write(programReply1);
                                            break;
                                        case "N":
                                            Console.Write(QuestionsList[13]);
                                            Console.Write(input.GetAnswer() == "Y" ? programReply1 : programReply2);
                                            break;
                                    }
                                    break;
                                case "N":
                                    Console.Write(programReply2);
                                    break;
                            }
                            break;
                    }
                    break;
                case "N":
                    Console.Write(programReply2);
                    break;
            }
        }
    }
}
