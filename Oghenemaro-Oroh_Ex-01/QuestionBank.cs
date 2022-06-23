using System;
namespace Oghenemaro_Oroh_Ex_02
{
	public class QuestionBank
	{
		//Instance variables
		int[] answers = { 1, 2, 3, 4, 4 };
		int q = 0;
		double correct, incorrect = 0;
		double percentage = 0;
		public QuestionBank()
		{
		}

		public void SimulateQuestion()
        {
			//how to add a comment
			//how to print a blank new line in the console
			//how to import a name space
			//which loop requires more than one statement
			//how to differentiate overloaded methods
			String[] questions = { "How to add a comment? \n 1. #. \n 2. &. \n 3. <. \n 4. ~.", "How to print a blank new line in the console? \n 1. null. \n 2. Console.WriteLine(). \n println(). <. \n 4. print pls.", "How to import a name space? \n 1. import. \n 2. take. \n 3. Using. \n 4. borrow.", "Which loop requires more than one parameter? \n 1. if. \n 2. while. \n 3. else. \n 4. for.", "How to differentiate overloaded methods? \n 1. paraneter list. \n 2. return type. \n 3. name. \n 4. Signature." };

			Console.WriteLine(questions[q]);
				
            
        }
		public bool CheckAnswer(String answer)
		{
			int answerNumber = Int32.Parse(answer);
			if(answerNumber == answers[q])
            {
				return true;
            }
			return false;


		}
		public void GenerateMessage(bool tf)
		{
			Random rnd = new Random();
			String[] congratulary = { "Excellent!", "Good!", "Keep up the good work!", "Nice work!" };
			String[] wrong = { "No.Please try again", "Wrong.Try once more", "Don't give up!", "No.Keep trying.." };

			switch (tf)
            {
				case true:
					//generate random congratulatory message
					int index = rnd.Next(0, congratulary.Length);
					Console.WriteLine(congratulary[index]);
					correct++;
					break;
				case false:
					//generate random try again message
					int index1 = rnd.Next(0, wrong.Length);
					Console.WriteLine(wrong[index1]);
					incorrect++;
					break;

			}
		}
		public void InputAnswer()
		{
			Console.WriteLine("Welcome to the test, please answer by writing the correct number down \n");
			for (int i = 0; i < 5; i++)
			{
				SimulateQuestion();
				String answer = Console.ReadLine();
				GenerateMessage(CheckAnswer(answer));
				q++;
				Console.WriteLine();

				if(i == 4)
                {
					percentage = (correct / (correct + incorrect)) * 100;
					Console.WriteLine(String.Format("Test is Over. \n Number of correct answers is {0}, Number of incorrect answers is {1}, Percentage of correct answers is {2}%", correct, incorrect, percentage));
                }
			}
				
			

		}


	}
}

