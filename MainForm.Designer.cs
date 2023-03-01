namespace csharpCashier
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            back = new Button();
            comma = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            clear = new Button();
            add = new Button();
            button18 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            insertProductCode = new Button();
            itemsList = new ListBox();
            sumTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            produktyToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            listaProduktówToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.BackColor = SystemColors.MenuText;
            resultBox.BorderStyle = BorderStyle.None;
            resultBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultBox.ForeColor = SystemColors.ButtonFace;
            resultBox.Location = new Point(19, 32);
            resultBox.Margin = new Padding(10);
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(500, 32);
            resultBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(back, 2, 3);
            tableLayoutPanel1.Controls.Add(comma, 1, 3);
            tableLayoutPanel1.Controls.Add(button0, 0, 3);
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(19, 85);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(500, 283);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // back
            // 
            back.AutoSize = true;
            back.BackColor = Color.FromArgb(48, 48, 48);
            back.Dock = DockStyle.Fill;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = SystemColors.ButtonFace;
            back.Location = new Point(335, 213);
            back.Name = "back";
            back.Size = new Size(162, 67);
            back.TabIndex = 14;
            back.Text = "<-";
            back.UseVisualStyleBackColor = false;
            back.Click += clickBack;
            // 
            // comma
            // 
            comma.AutoSize = true;
            comma.BackColor = Color.FromArgb(48, 48, 48);
            comma.Dock = DockStyle.Fill;
            comma.FlatAppearance.BorderSize = 0;
            comma.FlatStyle = FlatStyle.Flat;
            comma.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            comma.ForeColor = SystemColors.ButtonFace;
            comma.Location = new Point(169, 213);
            comma.Name = "comma";
            comma.Size = new Size(160, 67);
            comma.TabIndex = 13;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = false;
            comma.Click += clickComma;
            // 
            // button0
            // 
            button0.AutoSize = true;
            button0.BackColor = Color.FromArgb(48, 48, 48);
            button0.Dock = DockStyle.Fill;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button0.ForeColor = SystemColors.ButtonFace;
            button0.Location = new Point(3, 213);
            button0.Name = "button0";
            button0.Size = new Size(160, 67);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += click0;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.BackColor = Color.FromArgb(48, 48, 48);
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(335, 143);
            button9.Name = "button9";
            button9.Size = new Size(162, 64);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += click9;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = Color.FromArgb(48, 48, 48);
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(169, 143);
            button8.Name = "button8";
            button8.Size = new Size(160, 64);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += click8;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.BackColor = Color.FromArgb(48, 48, 48);
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(3, 143);
            button7.Name = "button7";
            button7.Size = new Size(160, 64);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += click7;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.FromArgb(48, 48, 48);
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(335, 73);
            button6.Name = "button6";
            button6.Size = new Size(162, 64);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += click6;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.FromArgb(48, 48, 48);
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(169, 73);
            button5.Name = "button5";
            button5.Size = new Size(160, 64);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += click5;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(48, 48, 48);
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(3, 73);
            button4.Name = "button4";
            button4.Size = new Size(160, 64);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += click4;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(48, 48, 48);
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(335, 3);
            button3.Name = "button3";
            button3.Size = new Size(162, 64);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += click3;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(48, 48, 48);
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(169, 3);
            button2.Name = "button2";
            button2.Size = new Size(160, 64);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += click2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(48, 48, 48);
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(160, 64);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += click1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(clear, 0, 0);
            tableLayoutPanel3.Controls.Add(add, 0, 0);
            tableLayoutPanel3.Location = new Point(19, 374);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(500, 67);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // clear
            // 
            clear.AutoSize = true;
            clear.BackColor = Color.FromArgb(192, 0, 0);
            clear.Dock = DockStyle.Fill;
            clear.FlatAppearance.BorderSize = 0;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            clear.ForeColor = SystemColors.ButtonFace;
            clear.Location = new Point(253, 3);
            clear.Name = "clear";
            clear.Size = new Size(244, 61);
            clear.TabIndex = 15;
            clear.Text = "Czyść";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clickClear;
            // 
            // add
            // 
            add.AutoSize = true;
            add.BackColor = Color.FromArgb(0, 192, 0);
            add.Dock = DockStyle.Fill;
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            add.ForeColor = SystemColors.ButtonFace;
            add.Location = new Point(3, 3);
            add.Name = "add";
            add.Size = new Size(244, 61);
            add.TabIndex = 14;
            add.Text = "Dodaj";
            add.UseVisualStyleBackColor = false;
            add.Click += clickSubmit;
            // 
            // button18
            // 
            button18.AccessibleRole = AccessibleRole.None;
            button18.AutoEllipsis = true;
            button18.BackColor = Color.FromArgb(30, 166, 50);
            button18.Dock = DockStyle.Fill;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = SystemColors.ButtonFace;
            button18.Location = new Point(3, 66);
            button18.Name = "button18";
            button18.Size = new Size(414, 51);
            button18.TabIndex = 1;
            button18.Text = "Zapisz zamówienie";
            button18.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button18, 0, 2);
            tableLayoutPanel2.Controls.Add(insertProductCode, 0, 1);
            tableLayoutPanel2.Location = new Point(525, 322);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(420, 119);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // insertProductCode
            // 
            insertProductCode.BackColor = Color.FromArgb(48, 48, 48);
            insertProductCode.Dock = DockStyle.Fill;
            insertProductCode.FlatAppearance.BorderSize = 0;
            insertProductCode.FlatStyle = FlatStyle.Flat;
            insertProductCode.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            insertProductCode.ForeColor = SystemColors.ButtonFace;
            insertProductCode.Location = new Point(3, 11);
            insertProductCode.Name = "insertProductCode";
            insertProductCode.Size = new Size(414, 49);
            insertProductCode.TabIndex = 0;
            insertProductCode.Text = "Wpisz kod produktu";
            insertProductCode.UseVisualStyleBackColor = false;
            insertProductCode.Click += openProductCodeModal;
            // 
            // itemsList
            // 
            itemsList.BackColor = Color.FromArgb(48, 48, 48);
            itemsList.BorderStyle = BorderStyle.None;
            itemsList.ForeColor = SystemColors.ButtonFace;
            itemsList.FormattingEnabled = true;
            itemsList.ItemHeight = 15;
            itemsList.Location = new Point(529, 33);
            itemsList.Name = "itemsList";
            itemsList.Size = new Size(416, 255);
            itemsList.TabIndex = 4;
            // 
            // sumTextBox
            // 
            sumTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sumTextBox.BackColor = Color.FromArgb(23, 23, 23);
            sumTextBox.BorderStyle = BorderStyle.None;
            sumTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sumTextBox.ForeColor = SystemColors.ButtonFace;
            sumTextBox.Location = new Point(529, 289);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(416, 27);
            sumTextBox.TabIndex = 6;
            sumTextBox.Text = "Suma: 0zł";
            sumTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 23, 23);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { produktyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(923, 27);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(22, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 27);
            panel1.TabIndex = 8;
            // 
            // produktyToolStripMenuItem
            // 
            produktyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, listaProduktówToolStripMenuItem });
            produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            produktyToolStripMenuItem.Size = new Size(67, 27);
            produktyToolStripMenuItem.Text = "Produkty";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Dodaj produkt";
            // 
            // listaProduktówToolStripMenuItem
            // 
            listaProduktówToolStripMenuItem.Name = "listaProduktówToolStripMenuItem";
            listaProduktówToolStripMenuItem.Size = new Size(180, 22);
            listaProduktówToolStripMenuItem.Text = "Lista produktów";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(964, 452);
            Controls.Add(panel1);
            Controls.Add(sumTextBox);
            Controls.Add(itemsList);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(resultBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Padding = new Padding(20);
            Text = "E Kasjer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox resultBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button comma;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button back;
        private TableLayoutPanel tableLayoutPanel3;
        private Button clear;
        private Button add;
        private Button button18;
        private TableLayoutPanel tableLayoutPanel2;
        private Button insertProductCode;
        private ListBox itemsList;
        private TextBox sumTextBox;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private ToolStripMenuItem produktyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem listaProduktówToolStripMenuItem;
    }
}