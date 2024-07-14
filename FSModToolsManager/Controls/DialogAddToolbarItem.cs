namespace FSModToolsManager.Controls;
public partial class DialogAddToolbarItem : Form {

    public int SelectedType { get; private set; } = 0;
    public string Title {  get; private set; } = string.Empty;

    public DialogAddToolbarItem() {
        InitializeComponent();
        comboBox1.SelectedIndex = 0;

        button1.DialogResult = DialogResult.OK;
    }

    private void button1_Click(object sender, EventArgs e) {
        SelectedType = comboBox1.SelectedIndex;
        Title = textBox1.Text;
    }
}
