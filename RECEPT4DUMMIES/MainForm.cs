namespace RECEPT4DUMMIES
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes = new List<Recipe>();
        public List<Admin> admins = new List<Admin>();

        public bool isAdmin;


        public MainForm()
        {
            InitializeComponent();
        }

        // L�gga till recept i recipe listan och i DataGridView
        private void LoadRecipes()
        {
            // Streamreader f�r att l�sa texfilen och f�r varje rad skapa en instans av "Recipe" klassen och l�gga till den i "recipes" listan
        }


        // L�gga till admins i admins listan
        private void LoadAdmin()
        {
            // Streamreader f�r att l�sa texfilen och f�r varje rad skapa en instans av "Admin" klassen och l�gga till den i "admins" listan
        }


        // Nollst�lla DataGridView
        private void ResetDataGridView()
        {
            // (namnet p� DatagridViewen).Rows.Clear();
        }


        // s�ka p� recept fr�n recipes listan och visa i DataGridView
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        // �ppna en ny Form n�r man klickar p� en rad f�r att visa detaljerad information (F�r tillf�llet kallar jag Formen f�r "RecipeDetailsForm"
        // Metod



        // Logga in som Admin
        private void SignInButton_Click(Object sender, EventArgs e)
        {
            // �ppna en ny Forms "FormLogIn" d�r man kan skriva Anv�ndarnamn och l�senord

            // Om inloggningen lyckas s� �ndras "isAdmin" variabeln i f�ltet p� denna klass till "true"

            // Efter att man har loggat in s� g�r man tillbaka till denna Form
        }


        // Ta bort markerad recipe
        private void DeleteSelectedRecipeButton_Click()
        {
            // Ta bort receptet fr�n listan

        }

    }
}