using System.Security.Cryptography.X509Certificates;

namespace VG___Uge2
{
    public partial class Form1 : Form
    {
        // lav array
        string[] navneArray = new string[10];
        // Til at bestemme plads i array
        int currentIndex = 0;

        // Til at må dopbbeltklikke på listbox

        public Form1()
        {
            InitializeComponent();

            // Display liste i starten
            DisplayArrayElements();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex < navneArray.Length)
            {
                string navn = tilføj_txtbox.Text;

                if (ErUnik(navn))
                {

                    navneArray[currentIndex] = navn;
                    currentIndex++;

                    // Opdater liste
                    DisplayArrayElements();
                }

                else
                {
                    MessageBox.Show("Entry findes allerede.");
                }
            }

            else
            {
                DialogResult result = MessageBox.Show("Array er fuldt. Vil du resize?", "Array Fuldt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ResizeArray();

                }
                else
                {
                    // Gør intet, og display tidligere vist array
                    DisplayArrayElements();
                }
            }

        }

        private bool ErUnik(string entry)
        {
            // Looper igennem og checker if unik
            for (int i = 0; i < currentIndex; i++)
            {
                if (navneArray[i] == entry)
                {
                    return false; // Findes allerede
                }
            }
            return true;
        }


        private void ResizeArray()
        {
            // Plus længde med en
            Array.Resize(ref navneArray, navneArray.Length + 1);
            string navn = tilføj_txtbox.Text;
            navneArray[currentIndex] = navn;
            currentIndex++;
            DisplayArrayElements();
        }

        // Function til at læse hvert array element ud i txtbox
        private void DisplayArrayElements()
        {
            // Clear the ListBox
            displayarr_listbox.Items.Clear();

            // Index 0 intet tilføjet
            displayarr_listbox.Text = "";
            if (currentIndex == 0)
            {
                displayarr_listbox.Items.Add("Intet tilføjet endnu");
                return;
            }

            // Tilføjer hvert element i array
            for (int i = 0; i < currentIndex; i++)
            {
                int nummer = i + 1;
                displayarr_listbox.Items.Add(nummer + " - " + navneArray[i]);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int slet_index;
            string slettxtbox;

            // Konvenvert til int
            if (int.TryParse(slet_txtbox.Text, out slet_index))
            {
                // Koriger for index 0
                slet_index--;

                DeleteAtIndex(slet_index);
                DisplayArrayElements();
            }
            else
            {
                slettxtbox = slet_txtbox.Text;
                DeleteNavn(slettxtbox);


            }
        }


        private void DeleteNavn(string slettxtbox)
        {
            string searchText = slettxtbox;
            int slet_index = Array.IndexOf(navneArray, searchText);

            if (slet_index != -1)
            {
                DeleteAtIndex(slet_index);
                DisplayArrayElements();
            }
            else
            {
                MessageBox.Show("Kan ikke findes i array");
                return;
            }
        }



        private void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= currentIndex)
            {
                MessageBox.Show("forkert index");
                return;
            }

            // Shift elements to the left starting from the index
            for (int i = index; i < currentIndex - 1; i++)
            {
                navneArray[i] = navneArray[i + 1];
            }

            // Decrement the currentIndex as one element is removed
            currentIndex--;
        }





        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void displayarr_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            // Copy af array
            string[] sortedArray = new string[currentIndex];
            Array.Copy(navneArray, sortedArray, currentIndex);

            // sorter
            Array.Sort(sortedArray);

            // Opdater orginalt array
            Array.Copy(sortedArray, navneArray, currentIndex);

            DisplayArrayElements();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Copy af array
            string[] reversedArray = new string[currentIndex];
            Array.Copy(navneArray, reversedArray, currentIndex);

            // sorter reverse
            Array.Reverse(reversedArray);

            // Opdater orginalt array
            Array.Copy(reversedArray, navneArray, currentIndex);

            DisplayArrayElements();
        }

        private void displayarr_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
            // Formater tekst uden nr.
            // Kun når det ikke er default txt
            string defaultstring = "Intet tilføjet endnu";

            if (displayarr_listbox.SelectedItem != defaultstring)
            {
                string valgtEntryFuld = displayarr_listbox.SelectedItem.ToString();
                string valgtEntry = valgtEntryFuld.Split('-')[1].Trim();

               

                DialogResult result = MessageBox.Show($"Vil du slette? '{valgtEntry}'?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteNavn(valgtEntry);
                    DisplayArrayElements();
                }
            }

        }
    }
}
