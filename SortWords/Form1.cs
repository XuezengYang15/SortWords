namespace SortWords
{
    public partial class Form1 : Form
    {
        int numOfWords = 0;
        int counter = 0;
        string numOfWordsString;
        string word;
        string[] wordArray;
        string labelMessage;



        public Form1()
        {
            InitializeComponent();

            sortWords.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputMessage_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return;
            }

            numOfWordsString = textBox.Text;
            numOfWords = Int32.Parse(numOfWordsString);

            textBox.Text = "";

            outputMessage.Text = "Please enter the word.";

            submitButton.Visible = false;

            submitWordButton.Visible = true;

            wordArray = new string[numOfWords];

        }

        private void sortWords_Click(object sender, EventArgs e)
        {

            arraySort(wordArray);

        }

        private void submitWordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return;
            }

            word = textBox.Text;

            textBox.Text = "";

            if (counter == (numOfWords - 1))
            {
                outputMessage.Text = "You entered the " + numOfWords + " word(s). Please " +
                                     "click the sort button to" +
                                     " to sort the words.";
                submitWordButton.Visible = false;
                sortWords.Visible = true;
            }

            wordArray[counter] = word;

            counter++;
        }

        private void arraySort(Array words)
        {
            Array.Sort(wordArray);

            for (int i = 0; i < wordArray.Length; i++)
            {
                labelMessage = labelMessage + wordArray[i] + "\n";
            }

            label.Text = labelMessage;
        }

        
    }
}