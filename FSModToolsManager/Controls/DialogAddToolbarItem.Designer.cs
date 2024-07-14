namespace FSModToolsManager.Controls;

partial class DialogAddToolbarItem {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        comboBox1 = new ComboBox();
        label1 = new Label();
        textBox1 = new TextBox();
        label2 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Linklist", "Launcherlist" });
        comboBox1.Location = new Point(83, 12);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(242, 40);
        comboBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(65, 32);
        label1.TabIndex = 1;
        label1.Text = "Type";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(83, 70);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(242, 39);
        textBox1.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 73);
        label2.Name = "label2";
        label2.Size = new Size(60, 32);
        label2.TabIndex = 3;
        label2.Text = "Title";
        // 
        // button1
        // 
        button1.Location = new Point(12, 124);
        button1.Name = "button1";
        button1.Size = new Size(313, 46);
        button1.TabIndex = 4;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // DialogAddToolbarItem
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(339, 185);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "DialogAddToolbarItem";
        Text = "Add toolbar item";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox comboBox1;
    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private Button button1;
}