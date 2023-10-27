namespace RECEPT4DUMMIES
{
    public partial class MainForm : Form
    {
        public List<Recipe> recipes = new List<Recipe>();
        public List<Admin> admins = new List<Admin>();
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private Button SearchButton;
        private Button SignInButton;
        private Button signOutButton;
        private Button button1;
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

        private void InitializeComponent()
        {
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            SearchButton = new Button();
            SignInButton = new Button();
            signOutButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(78, 78);
            SearchTextbox.Margin = new Padding(4, 5, 4, 5);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(263, 31);
            SearchTextbox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title });
            dataGridView1.Location = new Point(78, 173);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(673, 383);
            dataGridView1.TabIndex = 4;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 8;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 150;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(373, 78);
            SearchButton.Margin = new Padding(4, 5, 4, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(107, 31);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(705, 13);
            SignInButton.Margin = new Padding(4, 5, 4, 5);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(111, 54);
            SignInButton.TabIndex = 6;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(824, 13);
            signOutButton.Margin = new Padding(4, 5, 4, 5);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(111, 55);
            signOutButton.TabIndex = 7;
            signOutButton.Text = "Sign out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(772, 173);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(147, 54);
            button1.TabIndex = 8;
            button1.Text = "Nytt Recept";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(948, 629);
            Controls.Add(button1);
            Controls.Add(signOutButton);
            Controls.Add(SignInButton);
            Controls.Add(SearchButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchTextbox);
            Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        // Ta bort markerad recipe
        private void DeleteSelectedRecipeButton_Click()
        {
            // Ta bort receptet fr�n listan

        }

    }
}