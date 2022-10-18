using System;
using System.Windows.Forms;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public partial class FormSearch : Form
    {
        private ListBox m_SearchListBox = new ListBox();
        private FacebookSearch m_FacebookSearch = new FacebookSearch();

        public FormSearch(ListBox.ObjectCollection i_objectCollection)
        {
            InitializeComponent();
            this.m_SearchListBox.Items.AddRange(i_objectCollection);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchResultsListBox.Items.Clear();
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                foreach (object item in m_SearchListBox.Items)
                {
                    searchResultsListBox.Items.AddRange(m_FacebookSearch.Search(item, searchTextBox.Text).ToArray());
                }
            }
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchTextBox.Text = string.Empty;
        }
    }
}
