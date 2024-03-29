﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH_project3
{
    public partial class PH_project : Form
    {

        class Person
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public char Spol { get; set; }
            public DateTime DatumRođenja { get; set; }
            public string Država { get; set; }
            public string MjestoRođenja { get; set; }
        }

        ObservableCollection<Person> ListOfPersons = new ObservableCollection<Person>()
        { new Person {
            Ime = "Peter",
            Prezime = "Falk",
            Spol = 'M',
            DatumRođenja = new DateTime(1927, 9, 16),
            Država = "SAD",
            MjestoRođenja = "New York" },
        new Person {
            Ime = "Antonio",
            Prezime = "Banderas",
            Spol = 'M',
            DatumRođenja = new DateTime(1960, 8, 10),
            Država = "Španjolska",
            MjestoRođenja = "Malaga" },
        new Person {
            Ime = "Tomislav",
            Prezime = "Trifunović",
            Spol = 'M',
            DatumRođenja = new DateTime(1947, 2, 22),
            Država = "Srbija",
            MjestoRođenja = "Mali Popović" },
        new Person {
            Ime = "Sonja",
            Prezime = "Kovač",
            Spol = 'F',
            DatumRođenja = new DateTime(1984, 6, 18),
            Država = "Hrvatska",
            MjestoRođenja = "Bjelovar" },
        new Person {
            Ime = "Michael",
            Prezime = "Kane",
            Spol = 'M',
            DatumRođenja = new DateTime(1933, 3, 14),
            Država = "Engleska",
            MjestoRođenja = "London" },
        new Person {
            Ime = "Michelle",
            Prezime = "Pfeiffer",
            Spol = 'F',
            DatumRođenja = new DateTime(1958, 4, 29),
            Država = "SAD",
            MjestoRođenja = "Santa Ana" },
        new Person {
            Ime = "Milla",
            Prezime = "Jovovich",
            Spol = 'F',
            DatumRođenja = new DateTime(1975, 12, 17),
            Država = "Ukrajina",
            MjestoRođenja = "Kijev" },
        new Person {
            Ime = "Keanu",
            Prezime = "Reeves",
            Spol = 'M',
            DatumRođenja = new DateTime(1964, 9, 2),
            Država = "Lebanon",
            MjestoRođenja = "Beirut" },
        new Person {
            Ime = "Robert",
            Prezime = "De Niro",
            Spol = 'M',
            DatumRođenja = new DateTime(1943, 8, 17),
            Država = "SAD",
            MjestoRođenja = "New York" }
        };

        //SP PROJECT
        public class Card
        {
            public string CardNumber { get; set; }
            public string CardSuit { get; set; }
            public string CardColor { get; set; }
        }

        List<Card> Deck = new List<Card>() {
            new Card{CardNumber = "A", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "A", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "2", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "2", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "3", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "3", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "4", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "4", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "5", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "5", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "6", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "6", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "7", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "7", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "8", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "8", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "9", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "9", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "10", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "10", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "J", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "J", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "Q", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "Q", CardSuit = "♦", CardColor = "red" },
            new Card{CardNumber = "K", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "K", CardSuit = "♦", CardColor = "red" }
        };

        
        //Methods
        public void removeCard(int index, Label label, Label labelcopy)
        {
            if (Deck[index].CardColor == "black")
            {
                label.Text = Deck[index].CardNumber + Deck[index].CardSuit;
                labelcopy.Text = Deck[index].CardSuit + Deck[index].CardNumber;
                label.ForeColor = Color.Black;
                labelcopy.ForeColor = Color.Black;
            }
            else
            {
                label.Text = Deck[index].CardNumber + Deck[index].CardSuit;
                labelcopy.Text = Deck[index].CardSuit + Deck[index].CardNumber;
                label.ForeColor = Color.Red;
                labelcopy.ForeColor = Color.Red;
            }

            Deck.RemoveAt(index);
            labelCardsInDeck.Text = Deck.Count.ToString();
        }

        //DID_IT - 03 Try adding tabs for possible other projects.
        //DID_IT - 03.1 Tabs added, just figure out how to implement it (could be with new project or something else).
        public PH_project()
        {
            InitializeComponent();

            dataPersonView.DataSource = ListOfPersons;

            spolBox.Items.Add('M');
            spolBox.Items.Add('F');
            spolBox.SelectedIndex = 0;
            progressBar.Value = 34;
            datumBox.Format = DateTimePickerFormat.Custom;
            datumBox.CustomFormat = "dd/MM/yyyy";
           
            labelCardsInDeck.Text = Deck.Count.ToString();
        }

        //DID_IT - 02 Finally get to the POINT and try list sorting.
        //DID_IT - 02.1 Sort works!! Now how to make individual column to sort by it self?
        //DID_IT - 02.2 Maybe some other sort of check, like a switch.
        bool IsColumnSorted = false;
        private void dataPersonView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var temp = new List<Person>();
            if (!IsColumnSorted)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        temp = ListOfPersons.OrderBy(x => x.Ime).ToList(); break;
                    case 1:
                        temp = ListOfPersons.OrderBy(x => x.Prezime).ToList(); break;
                    case 2:
                        temp = ListOfPersons.OrderBy(x => x.Spol).ToList(); break;
                    case 3:
                        temp = ListOfPersons.OrderBy(x => x.DatumRođenja).ToList(); break;
                    case 4:
                        temp = ListOfPersons.OrderBy(x => x.Država).ToList(); break;
                    case 5:
                        temp = ListOfPersons.OrderBy(x => x.MjestoRođenja).ToList(); break;
                }
                ListOfPersons = new ObservableCollection<Person>(temp);
                IsColumnSorted = true;

            }
            else if (IsColumnSorted)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        temp = ListOfPersons.OrderByDescending(x => x.Ime).ToList(); break;
                    case 1:
                        temp = ListOfPersons.OrderByDescending(x => x.Prezime).ToList(); break;
                    case 2:
                        temp = ListOfPersons.OrderByDescending(x => x.Spol).ToList(); break;
                    case 3:
                        temp = ListOfPersons.OrderByDescending(x => x.DatumRođenja).ToList(); break;
                    case 4:
                        temp = ListOfPersons.OrderByDescending(x => x.Država).ToList(); break;
                    case 5:
                        temp = ListOfPersons.OrderByDescending(x => x.MjestoRođenja).ToList(); break;
                }
                ListOfPersons = new ObservableCollection<Person>(temp);
                IsColumnSorted = false;

            }
            //ListOfPersons = (BindingList<Person>)ListOfPersons.OrderBy(x => x.Ime);
            //dataPersonView.DataSource = null;
            dataPersonView.DataSource = ListOfPersons;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (progressBar.Value >= 100)
            {
                //Za ObservableCollection mora biti postavljen DataSource = null, pa ponovno DataSource = listOf... 
                ListOfPersons.Add(new Person
                {
                    Ime = imeBox.Text,
                    Prezime = prezimeBox.Text,
                    Spol = (char)spolBox.SelectedItem,
                    DatumRođenja = datumBox.Value,
                    Država = drzavaBox.Text,
                    MjestoRođenja = mjestoBox.Text,
                });

                if (!checkKeepDataBox.Checked)
                {
                    progressBar.Value = 34;
                    imeBox.Text = string.Empty;
                    prezimeBox.Text = string.Empty;
                    drzavaBox.Text = string.Empty;
                    mjestoBox.Text = string.Empty;
                    IsImeEmpty = true;
                    IsPrezimeEmpty = true;
                    IsDrzavaEmpty = true;
                    IsMjestoEmpty = true;
                }

            }
            else
            {
                MessageBox.Show("Fill all data boxes.", "Fill error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataPersonView.DataSource = null;
            dataPersonView.DataSource = ListOfPersons;
        }

        bool IsImeEmpty = true;
        //DID_IT - 01 Make a bool for {value != ""} to fix a repeted progress bar fill.
        //DID_IT - 01.1 Some bug with bar emptying when a field is empty and field is changed.
        //DID_IT - 01.2 Another bug after adding value. Can't add another and 
        private void imeBox_Validated(object sender, EventArgs e)
        {
            if (imeBox.Text.Length > 0 && IsImeEmpty)
            {
                progressBar.Value += 17;
                IsImeEmpty = false;
            }
            else if (imeBox.Text == "" && progressBar.Value != 0 && !IsImeEmpty)
            {
                progressBar.Value -= 17;
                IsImeEmpty = true;
            }
        }
        bool IsPrezimeEmpty = true;
        private void prezimeBox_Validated(object sender, EventArgs e)
        {
            if (prezimeBox.Text.Length > 0 && IsPrezimeEmpty)
            {
                progressBar.Value += 17;
                IsPrezimeEmpty = false;
            }
            else if (prezimeBox.Text == "" && progressBar.Value != 0 && !IsPrezimeEmpty)
            {
                progressBar.Value -= 17;
                IsPrezimeEmpty = true;
            }
        }
        bool IsDrzavaEmpty = true;
        private void drzavaBox_Validated(object sender, EventArgs e)
        {
            if (drzavaBox.Text.Length > 0 && IsDrzavaEmpty)
            {
                progressBar.Value += 17;
                IsDrzavaEmpty = false;
            }
            else if (drzavaBox.Text == "" && progressBar.Value != 0 && !IsDrzavaEmpty)
            {
                progressBar.Value -= 17;
                IsDrzavaEmpty = true;
            }
        }
        bool IsMjestoEmpty = true;
        private void mjestoBox_Validated(object sender, EventArgs e)
        {
            if (mjestoBox.Text.Length > 0 && IsMjestoEmpty)
            {
                progressBar.Value += 17;
                IsMjestoEmpty = false;
            }
            else if (mjestoBox.Text == "" && progressBar.Value != 0 && !IsMjestoEmpty)
            {
                progressBar.Value -= 17;
                IsMjestoEmpty = true;
            }
        }

        //SP PROJECT
        Random random = new Random();
        int nCards;
        int indexCard;
        //DID_IT - 04 Make a method for removing cards
        private void buttonCardDraw_Click(object sender, EventArgs e)
        {
            if (Deck.Count == 0) { MessageBox.Show("No cards left.", "Reset the deck.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (Deck.Count > 1)
            {
                nCards = random.Next(0, 2);
                if (nCards == 0)
                {
                    labelSecondPile.Text = "   ";
                    labelSecondPile2.Text = "   ";
                    indexCard = random.Next(0, Deck.Count);
                    removeCard(indexCard, labelFirstPile, labelFirstPile2);
                }
                else
                {
                    indexCard = random.Next(0, Deck.Count);
                    removeCard(indexCard, labelFirstPile, labelFirstPile2);

                    indexCard = random.Next(0, Deck.Count);
                    removeCard(indexCard, labelSecondPile, labelSecondPile2);
                }
                labelCardsInDeck.Text = Deck.Count.ToString();
            }
            else
            {
                labelSecondPile.Text = "   ";
                labelSecondPile2.Text = "   ";
                indexCard = random.Next(0, Deck.Count);
                removeCard(indexCard, labelFirstPile, labelFirstPile2);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Deck.Clear();
            Deck = new List<Card>() {
                new Card{CardNumber = "A", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "A", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "A", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "2", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "2", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "2", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "3", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "3", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "3", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "4", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "4", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "4", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "5", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "5", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "5", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "6", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "6", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "6", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "7", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "7", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "7", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "8", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "8", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "8", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "9", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "9", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "9", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "10", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "10", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "10", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "J", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "J", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "J", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "Q", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "Q", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "Q", CardSuit = "♦", CardColor = "red" },
                new Card{CardNumber = "K", CardSuit = "♣", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♠", CardColor = "black" },new Card{CardNumber = "K", CardSuit = "♥", CardColor = "red" },new Card{CardNumber = "K", CardSuit = "♦", CardColor = "red" }
            };
            labelCardsInDeck.Text = Deck.Count.ToString();
            labelFirstPile.Text = "   ";
            labelFirstPile2.Text = "   ";
            labelSecondPile.Text = "   ";
            labelSecondPile2.Text = "   "; 
        }
    }
}