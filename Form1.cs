namespace PokemonDex
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Pokemon> pokemonDict = new Dictionary<string, Pokemon>();

        public Form1()
        {
            InitializeComponent();
            LoadPokemonList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadPokemonList()
        {
            pokemonDict["Pikachu"] = new Pikachu();
            pokemonDict["Snorlax"] = new Snorlax();
            pokemonDict["Weedle"] = new Weedle();
            pokemonDict["Ekans"] = new Ekans();
            pokemonDict["Nidoking"] = new Nidoking();
            pokemonDict["Zubat"] = new Zubat();


            displayPokemon(pokemonDict["Pikachu"]);
        }

        private void displayPokemon(Pokemon pokemon)
        {
            lbName.Text = pokemon.getName();
            lbType.Text = pokemon.getType();
            lbHp.Text = pokemon.getHP().ToString();
            lbAtk.Text = pokemon.getAttack().ToString();
            lbDef.Text = pokemon.getDefense().ToString();
            lbSplAtk.Text = pokemon.getSpecialAttack().ToString();
            lbSplDef.Text = pokemon.getSpecialDefense().ToString();
            lbSp.Text = pokemon.getSpeed().ToString();
            lbTotal.Text = pokemon.getTotal().ToString();
            lbH.Text = pokemon.getHeight().ToString() + " m";
            lbW.Text = pokemon.getWeight().ToString() + " kg";

            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnPikachuClick_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Pikachu"]);
        private void btnWeedleClick_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Weedle"]);
        private void btnNidokingClick_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Nidoking"]);
        private void btnEkansClick_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Ekans"]);
        private void btnZubatClick_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Zubat"]);
        private void btnSnorlaxClick_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Snorlax"]);      
    }
}
