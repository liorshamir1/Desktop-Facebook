using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public class FacebookQuiz
    {
        private readonly int r_NumberOfWrongAnswers = 3;
        private readonly List<string> r_RangeOfAges = new List<string> { "6/6/1996", "12/3/1995", "7/2/1994", "1/5/1997", "28/12/1998", "13/4/1995", "9/10/1994", "24/1/1993", "16/9/1999", "18/7/1996", "22/2/1992", "15/2/1999" };
        private readonly List<string> r_RangeOfCities = new List<string> { "חולון", "ראשון לציון", "בת ים", "תל אביב", "נס ציונה", "פתח תקווה", "ראש העין", "חיפה", "כפר קאסם", "אריאל", "אילת", "נהריה" };
        private Random s_Random = new Random();
        private User m_GuessingFriend;

        public User GuessingFriend { get => m_GuessingFriend; set => m_GuessingFriend = value; }

        public List<string> GenerateAnswers(string i_CorrectAnswer, List<string> i_PossibleAnswers)
        {
            List<string> allAnswers = new List<string>();

            if (i_CorrectAnswer != null)
            {
                allAnswers.Add(i_CorrectAnswer);
                for (int i = 0; i < r_NumberOfWrongAnswers; ++i)
                {
                    int index = s_Random.Next(0, i_PossibleAnswers.Count);
                    if (i_CorrectAnswer != i_PossibleAnswers[index])
                    {
                        allAnswers.Add(i_PossibleAnswers[index]);
                    }
                    else
                    {
                        i--;
                    }

                    i_PossibleAnswers.RemoveAt(index);
                }
            }

            Shuffle(allAnswers);

            return allAnswers;
        }

        // shuffle based on the Fisher-Yates shuffle
        public void Shuffle<T>(List<T> io_list)
        {
            int numberOfEntittesInList = io_list.Count;
            while (numberOfEntittesInList > 1)
            {
                numberOfEntittesInList--;
                int randomGeneratedNumber = s_Random.Next(numberOfEntittesInList + 1);
                T value = io_list[randomGeneratedNumber];
                io_list[randomGeneratedNumber] = io_list[numberOfEntittesInList];
                io_list[numberOfEntittesInList] = value;
            }
        }

        public List<string> GetQuestionAnswersForAge()
        {
            List<string> answers = new List<string>();
            answers = GenerateAnswers(GuessingFriend.Birthday, r_RangeOfAges);
            return answers;
        }

        public List<string> GetQuestionAnswersForCity()
        {
            List<string> answers = new List<string>();
            answers = GenerateAnswers(GuessingFriend.Location.Name, r_RangeOfCities);
            return answers;
        }

        public User GetGuessingFriend(List<User> i_Friends)
        {
            if (i_Friends.Count != 0)
            {
                GuessingFriend = i_Friends[s_Random.Next(0, i_Friends.Count)];
            }
            else
            {
                GuessingFriend = null;
            }

            return GuessingFriend;
        }

        public bool CheckIfBirthdayAnswerIsCorrect(string i_BirthdayAnswer)
        {
            bool flag = false;

            if (i_BirthdayAnswer == m_GuessingFriend.Birthday)
            {
                flag = true;
            }

            return flag;
        }

        public bool CheckIfCityAnswerIsCorrect(string i_CityAnswer)
        {
            bool flag = false;

            if (i_CityAnswer == m_GuessingFriend.Location.Name)
            {
                flag = true;
            }

            return flag;
        }
    }
}
