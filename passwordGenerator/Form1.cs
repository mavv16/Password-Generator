using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordGenerator {
    public partial class Form1 : Form {
        public int NumberCharacters;

        //alphabet
        public static List<int> file_Numbers = new List<int>();
        public static List<string> file_Letters = new List<string>();
        public static List<char> file_SpecialChar = new List<char>();

        //results
        public List<int> NumbersList;
        public List<string> LettersList;
        public List<char> SpecialCharList;
        public List<string> MixList1; //without special char
        public List<string> MixList2; //with special char


        public Form1() {
            InitializeComponent();
            uploadList1();
            uploadList2();
            uploadList3();
        }
        private void uploadList1() {
            StreamReader reader = new StreamReader("Letters.txt");

            string line = null;
            while ((line = reader.ReadLine()) != null) {
                file_Letters.Add(line);
            }
        }
        private void uploadList2() {
            StreamReader reader = new StreamReader("Numbers.txt");

            string line = null;
            while ((line = reader.ReadLine()) != null) {
                file_Numbers.Add(Convert.ToInt32(line));
            }
        }
        private void uploadList3() {
            StreamReader reader = new StreamReader("SpecialChar.txt");

            string line = null;
            while ((line = reader.ReadLine()) != null) {
                file_SpecialChar.Add(Convert.ToChar(line));
            }
        }

        private void button_generate_Click(object sender, EventArgs e) {
            textBox_result.Text = "";

            Random rand = new Random();
            var choose = rand.Next(0, 2);   //0|1

            if (choose == 0) {//put the words at the beggining
                foreach (var element in checkedListBox_words.CheckedItems) {
                    textBox_result.Text += element;
                }
                writeNumberOfcharacters();
                writeTypeOfCharacters();
            }
            else {//put the words at the ending
                writeNumberOfcharacters();
                writeTypeOfCharacters();
                foreach (var element in checkedListBox_words.CheckedItems) {
                    textBox_result.Text += element;
                }
            }
        }

        private void writeNumberOfcharacters() {
            if (radioButton_four.Checked) {
                NumberCharacters = 4;
            }
            else if (radioButton_six.Checked) {
                NumberCharacters = 6;
            }
            else if (radioButton_eight.Checked) {
                NumberCharacters = 8;
            }
            else if (radioButton_fifteen.Checked) {
                NumberCharacters = 15;
            }
            else if (radioButton_custom.Checked) {
                bool ok = int.TryParse(textBox_custom.Text, out int value);

                if (ok) {
                    NumberCharacters = Convert.ToInt32(textBox_custom.Text);
                    errorProvider.SetError(textBox_custom, "");
                }
                else {
                    errorProvider.SetError(textBox_custom, "Only integer values!!");
                }
            }
        }
        private void writeTypeOfCharacters() {
            if (radioButton_letters.Checked) {
                randomLetters();
                foreach (var element in LettersList) {
                    textBox_result.Text += element;
                }
            } 
            else if (radioButton_numbers.Checked) {
                randomNumbers();
                foreach (var element in NumbersList) {
                    textBox_result.Text += element;
                }
            } 
            else if (radioButton_specialChar.Checked) {
                randomSpecialCharacters();
                foreach (var element in SpecialCharList) {
                    textBox_result.Text += element;
                }
            } 
            else if (radioButton_mix1.Checked) {
                randomMix1();
                foreach (var element in MixList1) {
                    textBox_result.Text += element;
                }
            } 
            else if (radioButton_mix2.Checked) {
                randomMix2();
                foreach (var element in MixList2) {
                    textBox_result.Text += element;
                }
            }
        }

        //random
        private void randomLetters() {
            Random rand = new Random();
            LettersList = new List<string>();

            for (int i = 0; i < NumberCharacters; i++) {

                var letter = file_Letters[rand.Next(file_Letters.Count)];
                LettersList.Add(letter);
            }
        }
        private void randomNumbers() {
            Random rand = new Random();
            NumbersList = new List<int>();

            for (int i = 0; i < NumberCharacters; i++) {

                var nr = file_Numbers[rand.Next(file_Numbers.Count)];
                NumbersList.Add(nr);
            }
        }
        private void randomSpecialCharacters() {
            Random rand = new Random();
            SpecialCharList = new List<char>();

            for (int i = 0; i < NumberCharacters; i++) {

                var Schar = file_SpecialChar[rand.Next(file_SpecialChar.Count)];
                SpecialCharList.Add(Schar);
            }
        }
        private void randomMix1() {
            Random rand = new Random();
            MixList1 = new List<string>();

            for (int i = 0; i < NumberCharacters; i++) {

                var choose = rand.Next(0, 2);   //0|1

                if(choose == 0) {
                    var letter = file_Letters[rand.Next(file_Letters.Count)];
                    MixList1.Add(letter);
                }
                else {
                    var nr = file_Numbers[rand.Next(file_Numbers.Count)];
                    MixList1.Add(nr.ToString());
                }
            }
        }
        private void randomMix2() {
            Random rand = new Random();
            MixList2 = new List<string>();

            for (int i = 0; i < NumberCharacters; i++) {

                var choose = rand.Next(0, 3);   //0|1|2

                if (choose == 0) {
                    var letter = file_Letters[rand.Next(file_Letters.Count)];
                    MixList2.Add(letter);
                } else if (choose == 1) {
                    var nr = file_Numbers[rand.Next(file_Numbers.Count)];
                    MixList2.Add(nr.ToString());
                } else {
                    var Schar = file_SpecialChar[rand.Next(file_SpecialChar.Count)];
                    MixList2.Add(Schar.ToString());
                }
            }
        }

        private void button_insert_Click(object sender, EventArgs e) {
            if(textBox_insert.Text != null) {
                checkedListBox_words.Items.Add(textBox_insert.Text);
            }
        }

        private void textBox_insert_Click(object sender, EventArgs e) {
            textBox_insert.Text = "";
        }
    }
}
