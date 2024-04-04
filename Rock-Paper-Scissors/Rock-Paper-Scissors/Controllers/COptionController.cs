using Microsoft.AspNetCore.Mvc;
using Rock_Paper_Scissors.Models;
using System;

namespace Rock_Paper_Scissors.Controllers
{
    public class COptionController : Controller
    {
        public IActionResult Play()
        {
            return View();
        }

        public IActionResult PlayerVsComp(int id)
        {
            COption playerChoice = new COption() { Option = (Option)id };
            COption computerChoice = new COption() { Option = (Option)ComputerChoice() };
            string str;

            str = WinOrLose(playerChoice, computerChoice);

            ViewBag.Choices = "Player : " + playerChoice.Option.ToString() + "\nComputer :" + computerChoice.Option.ToString();
            ViewBag.Message = str;
            return View("Results");
        }

        public IActionResult CompVsComp()
        {
            COption computer1Choice = new COption() { Option = (Option)ComputerChoice() };
            COption computer2Choice = new COption() { Option = (Option)ComputerChoice() };
            string str = WinOrLose(computer1Choice, computer2Choice);
            ViewBag.Choices = "Computer 1 : " + computer1Choice.Option.ToString() + "\nComputer 2 : " + computer2Choice.Option.ToString();
            ViewBag.Message = str;
            return View("Results");
        }

        private int ComputerChoice()
        {
            Random ran = new Random();
            return ran.Next(0, 3);
        }

        private string WinOrLose(COption p1, COption p2)
        {
            string output = "";

            // Determine the winner
            if ((p1.Option == Option.Rock && p2.Option == Option.Scissors) ||
                (p1.Option == Option.Paper && p2.Option == Option.Rock) ||
                (p1.Option == Option.Scissors && p2.Option == Option.Paper))
            {
                output = "Congratulations! You Win!";
            }
            else if ((p1.Option == Option.Scissors && p2.Option == Option.Rock) ||
                     (p1.Option == Option.Rock && p2.Option == Option.Paper) ||
                     (p1.Option == Option.Paper && p2.Option == Option.Scissors))
            {
                output = "You Lose!";
            }
            else
            {
                output = "It's a DRAW!";
            }

            return output;
        }
    }
}

