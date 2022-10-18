using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public partial class FormQuiz : Form
    {
        private readonly int r_NumberOfQuestions = 2;
        private FacebookQuiz m_FacebookQuiz = new FacebookQuiz();
        private int m_Score = 0;

        public FormQuiz(User i_LoggedInUser)
        {
            InitializeComponent();
            SetQuiz(i_LoggedInUser);
        }

        private void SetQuiz(User i_User)
        {
            List<User> listOfFriends = new List<User>(i_User.Friends);
            User randomFetchedFriend = m_FacebookQuiz.GetGuessingFriend(listOfFriends);

            if (randomFetchedFriend == null)
            {
                MessageBox.Show("You have no friends that are registered");
                this.Close();
            }
            else
            {
                fetchedFriendsPictureBox.Image = randomFetchedFriend.ImageNormal;
                fetchedFriendsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                SetGroupBoxHeadlines();
                SetQuizQuestions(randomFetchedFriend);
            }
        }

        private void SetQuizQuestions(User i_FetchedFriend)
        {
            List<string> ageQuestionAnswers = m_FacebookQuiz.GetQuestionAnswersForAge();
            List<string> cityQuestionAnswers = m_FacebookQuiz.GetQuestionAnswersForCity();
            SetAnswersPerQuestion(ageQuestionAnswers, questionGroupBox1);
            SetAnswersPerQuestion(cityQuestionAnswers, questionGroupBox2);
        }

        private void SetGroupBoxHeadlines()
        {
            questionGroupBox1.Text = string.Format("What is {0}'s birthday?", m_FacebookQuiz.GuessingFriend);
            questionGroupBox2.Text = string.Format("What city {0} lives in?", m_FacebookQuiz.GuessingFriend);
        }

        private void SetAnswersPerQuestion(List<string> i_RangeOfAnswers, GroupBox i_QuestionGroupBox)
        {
            if (i_RangeOfAnswers != null && i_RangeOfAnswers.Count == 4)
            {
                int index = 0;
                foreach (RadioButton radioButton in i_QuestionGroupBox.Controls)
                {
                    radioButton.Text = i_RangeOfAnswers[index++];
                }
            }
            else
            {
                i_QuestionGroupBox.Enabled = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            m_Score = 0;
            CheckForScore();
            this.Close();
        }

        private void CheckForScore()
        {
            string birthdayAnswer, cityAnswer;
            birthdayAnswer = questionGroupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            cityAnswer = questionGroupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;

            if (m_FacebookQuiz.CheckIfBirthdayAnswerIsCorrect(birthdayAnswer))
            {
                m_Score++;
            }

            if (m_FacebookQuiz.CheckIfCityAnswerIsCorrect(cityAnswer))
            {
                m_Score++;
            }

            MessageBox.Show(string.Format("Nice game, you got {0} out of {1} answers correct", m_Score, r_NumberOfQuestions));
        }
    }
}
